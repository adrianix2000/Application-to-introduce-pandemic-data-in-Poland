using Covid_Data.DataLayer;
using Covid_Data.DataLayer.DataModels;
using Covid_Data.Forms.MessageBoxes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace Covid_Data.Forms.MainForms
{
    public partial class YesterdaySituationForm : Form
    {

        #region Variabels


        private bool WifiConnectionFlag;

        private List<CountryClass> countries = new List<CountryClass>();

        private List<string> NamesOfCountries = new List<string>();

        private DataHttpMenager httpMenager = new DataHttpMenager();

        private const int EM_SETRECT = 0xB3;

        private SpeechSynthesizer Synthesizer = new SpeechSynthesizer();
             
        #endregion


        #region DllImports

        [DllImportAttribute("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        [DllImport(@"User32.dll", EntryPoint = @"SendMessage", CharSet = CharSet.Auto)]
        private static extern int SendMessageRefRect(IntPtr hWnd, uint msg, int wParam, ref RECT rect);

        [StructLayout(LayoutKind.Sequential)]
        private struct RECT
        {
            public readonly int Left;
            public readonly int Top;
            public readonly int Right;
            public readonly int Bottom;

            private RECT(int left, int top, int right, int bottom)
            {
                Left = left;
                Top = top;
                Right = right;
                Bottom = bottom;
            }

            public RECT(Rectangle r) : this(r.Left, r.Top, r.Right, r.Bottom)
            {
            }
        }
        public void SetPadding(TextBox textBox, Padding padding)
        {
            var rect = new Rectangle(padding.Left, padding.Top, textBox.ClientSize.Width - padding.Left - padding.Right, textBox.ClientSize.Height - padding.Top - padding.Bottom);
            RECT rc = new RECT(rect);
            SendMessageRefRect(textBox.Handle, EM_SETRECT, 0, ref rc);
        }


        #endregion


        public YesterdaySituationForm()
        {
            InitializeComponent();

            Synthesizer.SelectVoice("Microsoft David Desktop");

            lblDate.Text = "Cases from: " + DateTime.Today.AddDays(-1).ToString("yyyy-MM-dd");

            tbSearch.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, tbSearch.Width, tbSearch.Height, 20, 20));
            btnSearch.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btnSearch.Width, btnSearch.Height, 20, 20));

            WifiConnectionFlag = NetworkInterface.GetIsNetworkAvailable();
            if(WifiConnectionFlag == false)
            {
                LackOfConnectionMessageBox lackOfConnectionMessageBox = new LackOfConnectionMessageBox();
                lackOfConnectionMessageBox.ShowDialog();


            }
            else
            {
                Inicialization();

            }
        }

        private async void Inicialization()
        {
            countries = await httpMenager.GetListOfCountries();

            foreach(var country in countries)
            {
                NamesOfCountries.Add(country.Country);
            }
        }

        private void YesterdaySituationForm_Resize(object sender, EventArgs e)
        {
            int PanelSearchWth = this.Size.Width / 3;
            int SearchTextBoxWth = panelSearchTop.Size.Width / 4;

            //panelSearch.Size = new Size(PanelSearchWth, panelSearch.Size.Height);

           // tbSearch.Size = new Size(SearchTextBoxWth * 3, tbSearch.Size.Height);
           // btnSearch.Size = new Size(SearchTextBoxWth, btnSearch.Size.Height);

            /*
            tbSearch.Size = new Size(SearchTextBoxWth - 20 , tbSearch.Size.Height);
            */
        }

        private void tbSearch_Enter(object sender, EventArgs e)
        {
            if (tbSearch.Text == "Search country")
            {
                tbSearch.Text = "";
                tbSearch.ForeColor = Color.Gainsboro;
            }
        }

        private void tbSearch_Leave(object sender, EventArgs e)
        {
            if (tbSearch.Text == "")
            {
                tbSearch.Text = "Search country";
                tbSearch.ForeColor = Color.FromArgb(129, 129, 129);
            }
        }

        private void lbCoutriesNames_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void tbSearch_KeyUp(object sender, KeyEventArgs e)
        {
            lbCoutriesNames.Items.Clear();

            foreach (var name in NamesOfCountries)
            {
                if (name.Trim().ToLower().StartsWith(tbSearch.Text.ToLower()))
                {
                    lbCoutriesNames.Items.Add(name);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {


            lblCountryCode.Text = "Country code: ";
            lblCountryName.Text = "Country name: ";
            lblNewDeaths.Text = "New deaths: ";
            lblNewComfirmed.Text = "New confirmed: ";

            var temp_Country = countries.Where(c => 
                               c.Country == tbSearch.Text.Trim()).FirstOrDefault();

            if (temp_Country == null)
            {
                Synthesizer.SpeakAsync("no country with that name");

                return;
            }

            lblCountryName.Text += temp_Country.Country;
            lblNewComfirmed.Text += " " + temp_Country.NewConfirmed.ToString();
            lblNewDeaths.Text += " " + temp_Country.NewDeaths.ToString();
            lblCountryCode.Text += " " + temp_Country.CountryCode.ToString();

            tbSearch.Text = string.Empty;

            foreach (var name in NamesOfCountries)
            {
                lbCoutriesNames.Items.Add(name);
            }
        }

        private void lbCoutriesNames_MouseClick(object sender, MouseEventArgs e)
        {
            if (lbCoutriesNames.SelectedItem == null)
            {
                return;
            }

            tbSearch.Text = lbCoutriesNames.SelectedItem.ToString();
            lbCoutriesNames.Items.Clear();
        }
    }
}
