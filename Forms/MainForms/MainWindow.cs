using Covid_Data.Forms.Login_Forms.InformationForms;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Covid_Data.Forms.MainForms
{
    public partial class MainWindow : Form
    {
        #region Declaring values

        public const int WM_NCLBUTTONDWON = 0xA1;
        public const int HT_CAPTION = 0x2;

        private const int cGrip = 16;
        private const int cCaption = 32;

        private IconButton CurrentButton;
        private Panel LeftBorderOfCurrentBtn;

        private ColorsMenager colorsMenager;

        private bool WifiNetworkConnection;

        public Form CurrentChildForm;

        private DateTime Yesterday = DateTime.Today.AddDays(-1);

        #endregion

        #region Dll Imports

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParm, int lParm);

        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

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

        [DllImportAttribute("Gdi32.dll", EntryPoint = "DeleteObject")]
        public static extern bool DeleteObject(IntPtr hObject);

        #endregion

        #region Constructor and load actions

        public MainWindow()
        {
            InitializeComponent();

            //btnInfo.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btnInfo.Width, btnInfo.Height, 20, 20));

            LeftBorderOfCurrentBtn = new Panel();
            LeftBorderOfCurrentBtn.Size = new Size(10, btnInfo.Size.Height);
            panelMenu.Controls.Add(LeftBorderOfCurrentBtn);

            CurrentButton = new IconButton();

            this.BringToFront();

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            colorsMenager = new ColorsMenager();

            CurrentChildForm = new Form();

            btnYesterday.Text = Yesterday.ToString("yyyy-MM-dd");

            tbDataBaseServer.Text = "DESKTOP-828H3C4";
            tbPublicServer.Text = "https://api.covid19api.com/summary";

            Color tempColor = colorsMenager.DrawLightColor();
            ActivateCurrButton(btnInfo, tempColor);
            OpenChildForm(new MainIformationForm(this));

            //LeftBorderOfCurrentBtn.Location = new Point(0, CurrentButton.Location.Y);
            LeftBorderOfCurrentBtn.Size = new Size(LeftBorderOfCurrentBtn.Size.Width, btnInfo.Size.Height);
        }

        #endregion

        #region Form Menagment Functions

        private void ActivateCurrButton(object sender, Color color)
        {
            if(sender != null)
            {
                DisEnableButton();

                CurrentButton = sender as IconButton;

                CurrentButton.BackColor = ColorTranslator.FromHtml("#464646");
                CurrentButton.ForeColor = color;
                CurrentButton.TextAlign = ContentAlignment.MiddleCenter;
                CurrentButton.IconColor = color;
                CurrentButton.TextImageRelation = TextImageRelation.TextBeforeImage;
                CurrentButton.ImageAlign = ContentAlignment.MiddleCenter;

                pbActualPage.IconChar = CurrentButton.IconChar;
                pbActualPage.IconColor = CurrentButton.IconColor;

                LeftBorderOfCurrentBtn.BackColor = color;
                LeftBorderOfCurrentBtn.Location = new Point(0, CurrentButton.Location.Y);
                LeftBorderOfCurrentBtn.Size = new Size(LeftBorderOfCurrentBtn.Size.Width, btnGeoChart.Size.Height);
                LeftBorderOfCurrentBtn.Visible = true;

                LeftBorderOfCurrentBtn.BringToFront();
            }
        }

        private void DisEnableButton()
        {
            if(CurrentButton != null)
            {
                CurrentButton.BackColor = Color.FromArgb(46, 46, 46);
                CurrentButton.ForeColor = Color.Gainsboro;
                CurrentButton.TextAlign = ContentAlignment.MiddleLeft;
                CurrentButton.IconColor = Color.Gainsboro;
                CurrentButton.TextImageRelation = TextImageRelation.ImageBeforeText;
                CurrentButton.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void Reset()
        {
            DisEnableButton();
            LeftBorderOfCurrentBtn.Visible = false;
        }

        public async void OpenChildForm(Form form)
        {
            if(CurrentChildForm != null)
            {
                CurrentChildForm.Close();
            }

            CurrentChildForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(form);
            panelDesktop.Tag = form;
            form.BringToFront();
            form.Show();
            
        }

        #endregion

        #region Control's actions

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDWON, HT_CAPTION, 0);
        }

        private void btnMaximized_Click(object sender, EventArgs e)
        {

            if(WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
            //LeftBorderOfCurrentBtn.Size = new Size(LeftBorderOfCurrentBtn.Size.Width, btnInfo.Size.Height);
        }

        private void btnMinimized_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        #endregion

        private async void btnInfo_Click(object sender, EventArgs e)
        {
            Color tempColor = colorsMenager.DrawLightColor();
            ActivateCurrButton(sender, tempColor);
            OpenChildForm(new MainIformationForm(this));
        }

        private void btnGeoChart_Click(object sender, EventArgs e)
        {
            Color tempColor = colorsMenager.DrawLightColor();
            ActivateCurrButton(sender, tempColor);
            OpenChildForm(new GeoChartFrom());
        }

        private async void MainWindow_Resize(object sender, EventArgs e)
        {
            int MenuPanelWith = this.Size.Width / 6;
            int MiddlePanelHeigh = this.Size.Height / 11;
            int ButtonsHeigh = panelMenu.Size.Height / 8;

            panelMenu.Size = new Size(MenuPanelWith, panelMenu.Size.Height);

            /*
            btnInfo.Size = new Size(btnInfo.Size.Width, ButtonsHeigh);
            btnGeoChart.Size = new Size(btnGeoChart.Size.Width, ButtonsHeigh);
            btnPoland.Size = new Size(btnPoland.Size.Width, ButtonsHeigh);


            LeftBorderOfCurrentBtn.Size = new Size(LeftBorderOfCurrentBtn.Size.Width, ButtonsHeigh);
            */

            panelMiddle.Size = new Size(panelMiddle.Size.Width, MiddlePanelHeigh);

            //LeftBorderOfCurrentBtn.Location = new Point(0, CurrentButton.Location.Y);
           

        }

        private void btnInfo_MouseHover(object sender, EventArgs e)
        {
            btnInfo.FlatAppearance.BorderSize = 5;
            btnInfo.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#565656");

            LeftBorderOfCurrentBtn.Size = new Size(LeftBorderOfCurrentBtn.Size.Width, btnInfo.Size.Height);
        }

        private void btnInfo_MouseLeave(object sender, EventArgs e)
        {
            btnInfo.FlatAppearance.BorderSize = 1;
            btnInfo.FlatAppearance.BorderColor = Color.FromArgb(113, 113, 113);
        }

        private void btnGeoChart_MouseHover(object sender, EventArgs e)
        {
            btnGeoChart.FlatAppearance.BorderSize = 5;
            btnGeoChart.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#565656");
        }

        private void btnGeoChart_MouseLeave(object sender, EventArgs e)
        {
            btnGeoChart.FlatAppearance.BorderSize = 1;
            btnGeoChart.FlatAppearance.BorderColor = Color.FromArgb(113, 113, 113);
        }

        private void btnPoland_MouseHover(object sender, EventArgs e)
        {
            btnPoland.FlatAppearance.BorderSize = 5;
            btnPoland.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#565656");
        }

        private void btnPoland_MouseLeave(object sender, EventArgs e)
        {
            btnPoland.FlatAppearance.BorderSize = 1;
            btnPoland.FlatAppearance.BorderColor = Color.FromArgb(113, 113, 113);
        }

        private void iconButton2_MouseHover(object sender, EventArgs e)
        {
            btnYesterday.FlatAppearance.BorderSize = 5;
            btnYesterday.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#565656");
        }

        private void iconButton2_MouseLeave(object sender, EventArgs e)
        {
            btnYesterday.FlatAppearance.BorderSize = 1;
            btnYesterday.FlatAppearance.BorderColor = Color.FromArgb(113, 113, 113);
        }

        private void btnYesterday_Click(object sender, EventArgs e)
        {
            Color tempColor = colorsMenager.DrawLightColor();
            ActivateCurrButton(sender, tempColor);
            OpenChildForm(new YesterdaySituationForm());
        }

        private void btnPoland_Click(object sender, EventArgs e)
        {
            Color tempColor = colorsMenager.DrawLightColor();
            ActivateCurrButton(sender, tempColor);
            OpenChildForm(new PolandDataForm());
        }
    }
}
