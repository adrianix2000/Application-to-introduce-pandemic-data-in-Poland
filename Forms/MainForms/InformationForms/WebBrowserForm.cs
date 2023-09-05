using Covid_Data.Forms.Login_Forms.InformationForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Covid_Data.Forms.MainForms.InformationForms
{
    public partial class WebBrowserForm : Form
    {
        private MainWindow mainWindow;

        private string Url;

        public WebBrowserForm(MainWindow mainWindow, string url)
        {
            InitializeComponent();

            btnBack.Enabled = false;

            this.mainWindow = mainWindow;
            this.Url = url;
        }

        private async void WebBrowserForm_Load(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                try
                {
                    WebBrowser.Navigate(Url);
                }
                catch { };
            });
        }

        private void WebBrowser_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            if(e.CurrentProgress > 0 && e.MaximumProgress > 0)
            {
                LoadDocumentProgressBar.Value = (int)(e.CurrentProgress * 100 / e.MaximumProgress);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            mainWindow.OpenChildForm(new MainIformationForm(mainWindow));
        }

        private void WebBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            btnBack.Enabled = true;
        }
    }
}
