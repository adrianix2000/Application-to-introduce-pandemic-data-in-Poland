using Covid_Data.Forms.MainForms;
using Covid_Data.Forms.MainForms.InformationForms;
using Covid_Data.Forms.MessageBoxes;
using FontAwesome.Sharp;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Covid_Data.Forms.Login_Forms.InformationForms
{
    public partial class MainIformationForm : Form
    {
        private MainWindow mainWindow;

        private bool WiFiConnectionFlag;

        public MainIformationForm(MainWindow mainWindow)
        {
            InitializeComponent();

            this.mainWindow = mainWindow;

            WiFiConnectionFlag = NetworkInterface.GetIsNetworkAvailable();
        }

        private void MainIformationForm_Resize(object sender, EventArgs e)
        {
            int Buttonswth = panelTopButtons.Size.Width / 2;
            int MainPanelHeight = panelButtons.Size.Height / 2;

            panelTopButtons.Size = new Size(panelTopButtons.Size.Width, MainPanelHeight);

            btnWipedia.Size = new Size(Buttonswth, btnWipedia.Size.Height);
            btnWho.Size = new Size(Buttonswth, btnWho.Size.Height);

            btnDataView.Size = new Size(Buttonswth, btnDataView.Size.Height);
            btnAboutProject.Size = new Size(Buttonswth, btnAboutProject.Size.Height);

            this.Refresh();
        }

        private void btnWipedia_Click(object sender, EventArgs e)
        {
            WiFiConnectionFlag = NetworkInterface.GetIsNetworkAvailable();

            if (WiFiConnectionFlag == false)
            {
                LackOfConnectionMessageBox connectionMessageBox = new LackOfConnectionMessageBox();
                connectionMessageBox.ShowDialog();
                return;
            }

            try
            {
                mainWindow.OpenChildForm(new WebBrowserForm(mainWindow, "https://www.who.int/health-topics/coronavirus#tab=tab_1"));
            }catch(Exception ex)
            {

            }
        }

        private void btnWho_Click(object sender, EventArgs e)
        {
            WiFiConnectionFlag = NetworkInterface.GetIsNetworkAvailable();

            if (WiFiConnectionFlag == false)
            {
                LackOfConnectionMessageBox connectionMessageBox = new LackOfConnectionMessageBox();
                connectionMessageBox.ShowDialog();
                return;
            }

            try
            {
                mainWindow.OpenChildForm(new WebBrowserForm(mainWindow, "https://www.who.int/emergencies/diseases/novel-coronavirus-2019/covid-19-vaccines"));
            }catch(Exception ex)
            {

            }

        }

        private void btnDataView_Click(object sender, EventArgs e)
        {
            WiFiConnectionFlag = NetworkInterface.GetIsNetworkAvailable();

            if(WiFiConnectionFlag == false)
            {
                LackOfConnectionMessageBox connectionMessageBox = new LackOfConnectionMessageBox();
                connectionMessageBox.ShowDialog();
                return;
            }

            mainWindow.OpenChildForm(new ServerDataShowForm());
        }

        private void btnWipedia_MouseHover(object sender, EventArgs e)
        {
            btnWipedia.IconSize = 160;
            btnWipedia.IconColor = ColorTranslator.FromHtml("#339966");
            btnWipedia.FlatAppearance.BorderSize = 10;

        }

        private void btnWipedia_MouseLeave(object sender, EventArgs e)
        {
            btnWipedia.IconSize = 120;
            btnWipedia.IconColor = Color.Gainsboro;
            btnWipedia.FlatAppearance.BorderSize = 6;
        }

        private void btnWho_MouseHover(object sender, EventArgs e)
        {
            btnWho.IconSize = 160;
            btnWho.IconColor = ColorTranslator.FromHtml("#0097a7");
            btnWho.FlatAppearance.BorderSize = 10;
        }

        private void btnWho_MouseLeave(object sender, EventArgs e)
        {
            btnWho.IconSize = 120;
            btnWho.IconColor = Color.Gainsboro;
            btnWho.FlatAppearance.BorderSize = 6;
        }

        private void btnDataView_MouseHover(object sender, EventArgs e)
        {
            btnDataView.IconSize = 160;
            btnDataView.IconColor = ColorTranslator.FromHtml("#afb42b");
            btnDataView.FlatAppearance.BorderSize = 10;
        }

        private void btnDataView_MouseLeave(object sender, EventArgs e)
        {
            btnDataView.IconSize = 120;
            btnDataView.IconColor = Color.Gainsboro;
            btnDataView.FlatAppearance.BorderSize = 6;
        }

        private void btnAboutProject_MouseHover(object sender, EventArgs e)
        {
            btnAboutProject.IconSize = 160;
            btnAboutProject.IconColor = ColorTranslator.FromHtml("#d84315");
            btnAboutProject.FlatAppearance.BorderSize = 10;
        }

        private void btnAboutProject_MouseLeave(object sender, EventArgs e)
        {
            btnAboutProject.IconSize = 120;
            btnAboutProject.IconColor = Color.Gainsboro;
            btnAboutProject.FlatAppearance.BorderSize = 6;
        }

        /*
        private void TitleWho_Click(object sender, EventArgs e)
        {
            
            mainWindow.OpenChildForm(new WebBrowserForm(mainWindow, "https://www.who.int/emergencies/diseases/novel-coronavirus-2019/covid-19-vaccines"));
        }

        private void TitleWikipedia_Click(object sender, EventArgs e)
        {
            mainWindow.OpenChildForm(new WebBrowserForm(mainWindow, "https://www.youtube.com/watch?v=NMre6IAAAiU"));
        }

        private void TitleAboutProject_Click(object sender, EventArgs e)
        {

        }

        private void TitleData_Click(object sender, EventArgs e)
        {

        }
        */
    }
}
