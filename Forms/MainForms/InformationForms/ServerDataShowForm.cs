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

namespace Covid_Data.Forms.MainForms.InformationForms
{

    public partial class ServerDataShowForm : Form
    {

        #region Decalering Vlues

        private string JSONData = string.Empty;

        private DataHttpMenager httpMenager = new DataHttpMenager();

        private bool WifiConnectionFlag;

        private const int EM_SETRECT = 0xB3;

        private List<CountryClass> ListOfCountries = new List<CountryClass>();

        private ExcelMenager excelMenager = new ExcelMenager();


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


        #region Constructor

        public ServerDataShowForm()
        {
            //sdfsfddsfSetPadding(tbData, new Padding(10, 10, 10, 10));
            InitializeComponent();

            SetPadding(tbFind, new Padding(5, 5, 5, 5));

            tbFind.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, tbFind.Width, tbFind.Height, 20, 20));

            WifiConnectionFlag = NetworkInterface.GetIsNetworkAvailable();

            panelJsonInfo.Visible = false;
            panelJsonInfo.SendToBack();

            pb1.Image = Covid_Data.Properties.Resources.GlobalInfoClassPhoto;
            pb2.Image = Covid_Data.Properties.Resources.JSONFormatPhoto;
        }

        #endregion


        #region JSON load Method

        private async void LoadJSON()
        {
            btnRefresh.Enabled = false;
            try
            {
                JSONData = await httpMenager.GetJSONString();
                ListOfCountries = await httpMenager.GetListOfCountries();

            }catch(Exception ex)
            {
                LackOfConnectionMessageBox lackOfConnectionMessageBox = new LackOfConnectionMessageBox();
                lackOfConnectionMessageBox.ShowDialog();
                btnRefresh.Enabled = true;
                return;
            }

            btnRefresh.Enabled = true;
            tbData.Text = JSONData;
        }

        #endregion


        #region Control's actions

        private void ServerDataShowForm_Load(object sender, EventArgs e)
        {
    
            WifiConnectionFlag = NetworkInterface.GetIsNetworkAvailable();
            if(WifiConnectionFlag == false)
            {
                LackOfConnectionMessageBox lackOfConnectionMessageBox = new LackOfConnectionMessageBox();
                lackOfConnectionMessageBox.ShowDialog();
                return;
            }
            LoadJSON();
        }

        private void btnRefresh_MouseHover(object sender, EventArgs e)
        {
            btnRefresh.IconSize = 60;
            btnRefresh.IconChar = FontAwesome.Sharp.IconChar.Sync;
        }

        private void btnRefresh_MouseLeave(object sender, EventArgs e)
        {
            btnRefresh.IconSize = 48;
            btnRefresh.IconChar = FontAwesome.Sharp.IconChar.SyncAlt;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            WifiConnectionFlag = NetworkInterface.GetIsNetworkAvailable();
            if(WifiConnectionFlag == false)
            {
                LackOfConnectionMessageBox lackOfConnectionMessageBox = new LackOfConnectionMessageBox();
                lackOfConnectionMessageBox.ShowDialog();
                return;
            }
            LoadJSON();
        }

        #endregion

        private void btnJsonWhatIsIt_MouseHover(object sender, EventArgs e)
        {
            btnJsonWhatIsIt.FlatAppearance.BorderSize = 4;

            panelJsonInfo.Visible = true;
            panelJsonInfo.BringToFront();
        }

        private void btnJsonWhatIsIt_MouseLeave(object sender, EventArgs e)
        {
            btnJsonWhatIsIt.FlatAppearance.BorderSize = 2;

            panelJsonInfo.Visible = false;
            panelJsonInfo.SendToBack();
        }




        private void panelJsonInfo_Resize(object sender, EventArgs e)
        {
            int ImageWth = panelJsonInfo.Size.Width / 2;
            panelJsonInfo.Size = new Size(panelJsonInfo.Size.Width, panelJsonInfo.Size.Width / 2);

            pb1.Size = new Size(ImageWth, pb1.Size.Height);
            pb2.Size = new Size(ImageWth, pb2.Size.Height);
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                tbData.Font = fd.Font;
            }
        }

        private void tbFind_Enter(object sender, EventArgs e)
        {
            if(tbFind.Text == "find fraze")
            {
                tbFind.Text = "";
                tbFind.ForeColor = Color.Gainsboro;
            }
        }

        private void tbFind_Leave(object sender, EventArgs e)
        {
            if(tbFind.Text == "")
            {
                tbFind.Text = "find fraze";
                tbFind.ForeColor = Color.FromArgb(129, 129, 129);
            }
        }



        private async void btnExcelExport_Click(object sender, EventArgs e)
        {
            // await excelMenager.WriteToExcel(ListOfCountries);

            if(string.IsNullOrEmpty(tbData.Text.Trim()) || string.IsNullOrWhiteSpace(tbData.Text.Trim()))
            {
                LackOfConnectionMessageBox lackOfConnectionMessageBox = new LackOfConnectionMessageBox();
                lackOfConnectionMessageBox.ShowDialog();
                return;

            }

            ExcelExportForm exportForm = new ExcelExportForm(ListOfCountries, new List<OneDayOfPoland>(), 1);
            exportForm.ShowDialog();
        }

        private void btnFindinText_Click(object sender, EventArgs e)
        {
            /*
            int start = 0;
            int end = tbData.Text.LastIndexOf(tbData.Text);

            while(start < end)
            {
                tbData.FindFrom(tbData.Text, start, tbData.TextLength, RichTextBoxFinds.MatchCase);
            }
            */
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
    }
}
