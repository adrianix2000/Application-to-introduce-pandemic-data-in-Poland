using LiveCharts.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using Covid_Data.DataLayer.DataModels;
using Covid_Data.DataLayer;
using System.Net.NetworkInformation;
using Covid_Data.Forms.MessageBoxes;

namespace Covid_Data.Forms.MainForms
{
    public partial class GeoChartFrom : Form
    {

        #region Declaring Values

        private GeoMap map = new GeoMap();

        private bool WiFiConnectionFlag { get; set; }

        private SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer();

        private List<CountryClass> countriesInfo = new List<CountryClass>();

        private DataHttpMenager httpMenager = new DataHttpMenager();

        private GlobalInfoClass GlobalInfo = new GlobalInfoClass();

        private bool IfMapIsFine = false;



        #endregion

        #region Constructor

        public GeoChartFrom()
        {
            InitializeComponent();

            WiFiConnectionFlag = NetworkInterface.GetIsNetworkAvailable();

            try
            {
                speechSynthesizer.SelectVoice("Microsoft David Desktop");
            }
            catch
            {
                speechSynthesizer.SpeakAsync("przed użyciem, Zainstaluj angielski aparat mowy");
                Application.Exit();
            }

            if (WiFiConnectionFlag == false)
            {
                speechSynthesizer.SpeakAsync("check your wi-fi connection");
                timer1.Enabled = true;
            }

            map.Source = $"{Application.StartupPath}\\World.xml";


            map.Dock = DockStyle.Fill;
            MapPanel.Controls.Add(map);

        }

        #endregion


        #region Chart Inicialization Method

        private async void InicializationOfMapChart()
        {
            speechSynthesizer.Pause();

            
            WiFiConnectionFlag = NetworkInterface.GetIsNetworkAvailable();
            if(WiFiConnectionFlag == false)
            {
                LackOfConnectionMessageBox lackOfConnectionMessageBox = new LackOfConnectionMessageBox();
                lackOfConnectionMessageBox.ShowDialog();
                return;
            }
            

            btnRefresh.Enabled = false;

            Dictionary<string, double> keyValues = new Dictionary<string, double>();

            try
            {
                countriesInfo = await httpMenager.GetListOfCountries();
                GlobalInfo = await httpMenager.GetGlobalInfo();

            }catch(Exception ex)
            {
                speechSynthesizer.SpeakAsync("problem with data download..");
                return;
            }

            foreach(var country in countriesInfo)
            {
                try
                {
                    double CountryCases = country.TotalConfirmed;

                    keyValues[country.CountryCode] = CountryCases;

                }catch(Exception ex)
                {
                    continue;
                }
            }

            map.BackColor = Color.Black;

            map.HeatMap = keyValues;

            map.Source = $"{Application.StartupPath}\\World.xml";


            if (GlobalInfo != null)
            {
                lblGlobalTotalCases.Text = "Global cases:  " + GlobalInfo.TotalConfirmed;
                lblGlobalTotalDeaths.Text = "Global deaths:  " + GlobalInfo.TotalDeaths;
                lblGlobalTotalRecoverd.Text = "Global recoverds:  " + GlobalInfo.TotalRecovered;
            }

            MapPanel.Controls.Add(map);
            map.Dock = DockStyle.Fill;

            map.LandClick += Map_LandClick;

            IfMapIsFine = true;

            btnRefresh.Enabled = true;

        }

        private void Map_LandClick(object arg1, LiveCharts.Maps.MapData arg2)
        {

            speechSynthesizer.Pause();
            speechSynthesizer = new SpeechSynthesizer();
            speechSynthesizer.SelectVoice("Microsoft David Desktop");

            var country = countriesInfo.Where(c => 
                          c.CountryCode == arg2.Id).FirstOrDefault();

            if(country == null)
            {
                return;
            }

            speechSynthesizer.SpeakAsync(country.Country);
            speechSynthesizer.SpeakAsync(country.TotalDeaths.ToString() + " total deaths");

            lblCountryName.Text = "Country name:  " + country.Country;
            lblTotalComfirmed.Text = "Total comfirmed:  " + country.TotalConfirmed;
            lblTotalDeaths.Text = "Total deaths:  " + country.TotalDeaths;
        }

        #endregion



        private void timer1_Tick(object sender, EventArgs e)
        {
            WiFiConnectionFlag = NetworkInterface.GetIsNetworkAvailable();
            if (WiFiConnectionFlag == true)
            {
                speechSynthesizer.SpeakAsync("you're online again");
                timer1.Enabled = false;
            }
        }

        private void GeoChartFrom_Load(object sender, EventArgs e)
        {
            InicializationOfMapChart();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            InicializationOfMapChart();
        }
    }
}
