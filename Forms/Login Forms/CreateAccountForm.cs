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

namespace Covid_Data.Forms.Login_Forms
{
    public partial class CreateAccountForm : Form
    {
        #region Dll Imports

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

        #endregion

        public CreateAccountForm()
        {
            InitializeComponent();

            btnCreate.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btnCreate.Width, btnCreate.Height, 20, 20));
        }
    }
}
