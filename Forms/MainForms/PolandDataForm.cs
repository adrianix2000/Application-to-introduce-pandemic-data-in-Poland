using Covid_Data.DataLayer.DataModels;
using Covid_Data.Forms.MessageBoxes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Covid_Data.Forms.MainForms
{
    public partial class PolandDataForm : Form
    {
        #region Variables

        private List<OneDayOfPoland> PolandDays = new List<OneDayOfPoland>();

        private Model1 DbModel = new Model1();

        private int MaxDeath = 0;
        private string MaxDeathsS = string.Empty;

        private int MinDeaths = 0;
        private string MinDeathsS = string.Empty;

        private int MaxComfirmed = 0;
        private string MaxComfirmedS = string.Empty;

        private int MinComfirmed = 0;
        private string MinComirmedS = string.Empty;

        private string TimeRangeDown = string.Empty;
        private string TimeRangeUp = string.Empty;

        #endregion

        public PolandDataForm()
        {
            InitializeComponent();
        }

        private async void Inicialization()
        {
            btnRefresh.Enabled = false;

            PolandDays = await DbModel.GetListOfDays();
            dataGridView1.DataSource = PolandDays;

            TimeRangeDown = PolandDays[0].Date;
            TimeRangeUp = PolandDays[PolandDays.Count() - 1].Date;

            labelTimeRange.Text = TimeRangeDown + " - " + TimeRangeUp;

            MaxDeath = PolandDays[0].NewDeaths;
            MaxDeathsS = PolandDays[0].Date;

            MinDeaths = MaxDeath;
            MinDeathsS = MaxDeathsS;

            MaxComfirmed = PolandDays[0].NewConfirmed;
            MaxComfirmedS = PolandDays[0].Date;

            MinComfirmed = MaxComfirmed;
            MinComirmedS = MaxComfirmedS;

            foreach(var day in PolandDays)
            {
                if(day.NewDeaths > MaxDeath)
                {
                    MaxDeath = day.NewDeaths;
                    MaxDeathsS = day.Date;
                }
                if(day.NewDeaths < MinDeaths)
                {
                    MinDeaths = day.NewDeaths;
                    MinDeathsS = day.Date;
                }
                if(day.NewConfirmed > MaxComfirmed)
                {
                    MaxComfirmed = day.NewConfirmed;
                    MaxComfirmedS = day.Date;
                }
                if(day.NewConfirmed < MinComfirmed)
                {
                    MinComfirmed = day.NewConfirmed;
                    MinComirmedS = day.Date;
                }
            }

            lblMaxDate.Text = "Max date: " + MaxDeathsS;
            lblMaxNumber.Text = "Max deaths: " + MaxDeath;

            lblMinDate.Text = "Min date: " + MinDeathsS;
            lblMin.Text = "Min deaths: " + MinDeaths;

            lblMaxComfirmedDate.Text = "Max date: " + MaxComfirmedS;
            lblMaxComfirmed.Text = "Max comfirmed: " + MaxComfirmed;

            lblMinComfirmedDate.Text = "Min date: " + MinComirmedS;
            lblMinComfirmed.Text = "Min comfirmed: " + MinComfirmed;


            var objChart1 = chartDeaths.ChartAreas[0];
            var objChart2 = chartConfirmed.ChartAreas[0];

            objChart1.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;

            objChart1.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            objChart1.AxisY.Minimum = MinDeaths;
            objChart1.AxisY.Maximum = 1000;



            objChart2.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;

            objChart2.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            objChart2.AxisY.Minimum = MinComfirmed;
            objChart2.AxisY.Maximum = MaxComfirmed;

            chartDeaths.Series.Clear();
            chartConfirmed.Series.Clear();

            Random r = new Random();

            chartDeaths.Series.Add("Deaths");
            chartDeaths.Series["Deaths"].Color = Color.FromArgb(r.Next(256), r.Next(256), r.Next(256));

            chartConfirmed.Series.Add("Confirmed");
            chartConfirmed.Series["Confirmed"].Color = Color.FromArgb(r.Next(256), r.Next(256), r.Next(256));

            int maxid = PolandDays[PolandDays.Count() - 1].Id;

            for(int i=1; i<maxid; i++)
            {
                chartDeaths.Series["Deaths"].Points.AddXY(i, PolandDays[i - 1].NewDeaths);
                chartConfirmed.Series["Confirmed"].Points.AddXY(i, PolandDays[i - 1].NewConfirmed);
            }

            btnRefresh.Enabled = true;
        }

        private async void PolandDataForm_Load(object sender, EventArgs e)
        {
            // PolandDays = await DbModel.GetListOfDays();
            // dataGridView1.DataSource = PolandDays;

            Inicialization();
        }

        private void btnExcelExport_MouseHover(object sender, EventArgs e)
        {
            btnExcelExport.IconSize = 60;
            btnExcelExport.FlatAppearance.BorderSize = 3;
        }

        private void btnExcelExport_MouseLeave(object sender, EventArgs e)
        {
            btnExcelExport.IconSize = 45;
            btnExcelExport.FlatAppearance.BorderSize = 2;
        }

        private void btnExcelExport_Click(object sender, EventArgs e)
        {
            ExcelExportForm excelExportForm = new ExcelExportForm(new List<CountryClass>(), PolandDays, 2);
            excelExportForm.ShowDialog();
        }

        private void PolandDataForm_Resize(object sender, EventArgs e)
        {
            int AlgoritmPanelWth = this.Size.Width / 4;
            int ChartWth = panelCharts.Size.Width / 2;
            int DateWth = panelTop.Size.Width / 3;

            labelTimeRange.Size = new Size(DateWth, labelTimeRange.Size.Height);

            panelAlgorithms.Size = new Size(AlgoritmPanelWth, panelAlgorithms.Size.Height);

            chartDeaths.Size = new Size(ChartWth, chartDeaths.Size.Height);
            chartConfirmed.Size = new Size(ChartWth, chartConfirmed.Size.Height);
        }


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Inicialization();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            string selectionDay = monthCalendar1.SelectionStart.ToString("D");

            var day = PolandDays.Where(d => 
                       d.Date == selectionDay).FirstOrDefault(); 

            if(day == null)
            {
                return;
            }

            OneDayForm oneDayForm = new OneDayForm(day);
            oneDayForm.ShowDialog();
            
        }
    }
}
