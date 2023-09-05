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
using System.Speech.Synthesis;

namespace Covid_Data.Forms.Login_Forms
{
    public partial class MainLoginForm : Form
    {
        #region Declearing Values

        public const int WM_NCLBUTTONDWON = 0xA1;
        public const int HT_CAPTION = 0x2;

        private IconButton ActiveButton;
        private Form CurrentForm = new Form();

        private ColorsMenager colorsMenager = new ColorsMenager();

        private SpeechSynthesizer synthesizer = new SpeechSynthesizer();

        private List<string> InstalledLanguages = new List<string>();

        #endregion

        #region Dll imports

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

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParm, int lParm);

        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        #endregion

        #region Constructor

        public MainLoginForm()
        {
            InitializeComponent();

            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            //iconButton1.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, iconButton1.Width, iconButton1.Height, 20, 20));

            // download instaled system languages
            foreach(var voice in synthesizer.GetInstalledVoices())
            {
                InstalledLanguages.Add(voice.VoiceInfo.Name);
            }

            // choose correct language system, project this...
            synthesizer.SelectVoice(InstalledLanguages[2]);

            synthesizer.SpeakAsync("welcome in the Covid 19 project");
        }

        #endregion

        #region Colors Pallette

        private struct ColorsFromRGB
        {
            public static Color color1 = ColorTranslator.FromHtml("#5a5a5a");
            public static Color color2 = ColorTranslator.FromHtml("#4f4f4f");
            public static Color color3 = ColorTranslator.FromHtml("#464646");
            public static Color color4 = ColorTranslator.FromHtml("#666666");
            public static Color color5 = ColorTranslator.FromHtml("#3f3f3f");
            public static Color color6 = ColorTranslator.FromHtml("#434343");           
        }

        #endregion

        #region Managment functions

        private void OpenChildForm(Form form)
        {
            CurrentForm.Close();

            ActiveButton = btnLogIn;

            CurrentForm = form;
            form.FormBorderStyle = FormBorderStyle.None;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;

            panelDesktop.Controls.Add(form);
            panelDesktop.Tag = form;

            form.BringToFront();
            form.Show();
        }

        private void DisableButton()
        {
            if(ActiveButton != null)
            {
                ActiveButton.FlatAppearance.BorderColor = Color.FromArgb(95, 95, 95);
                ActiveButton.FlatAppearance.BorderSize = 0;
               // ActiveButton.FlatAppearance.BorderColor = Color.FromArgb(95, 95, 95);

                Color color = Color.FromArgb(95, 95, 95);
                ActiveButton.BackColor = color;
                ActiveButton.Enabled = true;
            }
        }

        private void ActivateButton(object sender)
        {
            if(sender != null)
            {
                DisableButton();

                ActiveButton = sender as IconButton;
                ActiveButton.FlatAppearance.BorderSize = 1;

                Color color = colorsMenager.DrawLightColor();
                ActiveButton.FlatAppearance.BorderColor = color;

                panelMiddle.BackColor = colorsMenager.ChangeBrightness(color, -0.3);

                ActiveButton.BackColor = colorsMenager.DrawAColor();
            }
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


        private void btnLogIn_Click(object sender, EventArgs e)
        {
            Color color = Color.FromArgb(95, 95, 95);
            btnCreate.FlatAppearance.BorderSize = 0;
            btnCreate.BackColor = color;

            ActivateButton(sender);
            OpenChildForm(new LoginForm());
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new CreateAccountForm());
        }


        private void btnHome_Click(object sender, EventArgs e)
        {
            Color color = Color.FromArgb(95, 95, 95);
            btnCreate.FlatAppearance.BorderSize = 0;
            btnCreate.BackColor = color;

            color = Color.FromArgb(113, 113, 113);
            panelMiddle.BackColor = color;

            DisableButton();
            OpenChildForm(new HomeForm());
        }

        #endregion
    }
}

