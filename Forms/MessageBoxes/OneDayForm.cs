using Covid_Data.DataLayer.DataModels;
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

namespace Covid_Data.Forms.MessageBoxes
{
    public partial class OneDayForm : Form
    {
        #region Variables

        private OneDayOfPoland OneDay = new OneDayOfPoland();

        public const int WM_NCLBUTTONDWON = 0xA1;
        public const int HT_CAPTION = 0x2;

        #endregion

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

        public OneDayForm(OneDayOfPoland oneDay)
        {
            InitializeComponent();

            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            OneDay = oneDay;

            lblDate.Text = OneDay.Date;

            lblDeaths.Text = "New deaths: " + OneDay.NewDeaths;
            lblConfirned.Text = "New deaths: " + OneDay.NewConfirmed;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDWON, HT_CAPTION, 0);
        }
    }
}
