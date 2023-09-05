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

namespace Covid_Data.Forms.MessageBoxes
{
    public partial class LackOfConnectionMessageBox : Form
    {

        public const int WM_NCLBUTTONDWON = 0xA1;
        public const int HT_CAPTION = 0x2;

        private SpeechSynthesizer synthesizer = new SpeechSynthesizer();

        #region DLL import

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

        public LackOfConnectionMessageBox()
        {
            InitializeComponent();
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            btnOk.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btnOk.Width, btnOk.Height, 20, 20));

            synthesizer.SelectVoice("Microsoft David Desktop");

            synthesizer.SpeakAsync("check your connection");

        }

        #endregion

        private void LackOfConnectionMessageBox_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDWON, HT_CAPTION, 0);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            synthesizer.Pause();
            this.Close();
        }
    }
}
