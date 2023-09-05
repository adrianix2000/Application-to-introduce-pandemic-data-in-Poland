using Covid_Data.DataLayer;
using Covid_Data.DataLayer.DataModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Covid_Data.Forms.MainForms
{
    public partial class ExcelExportForm : Form
    {
        #region Variables

        string folderName = string.Empty;

        string fileName = string.Empty;

        string fullPath = string.Empty;

        string sheetName = string.Empty;

        private ExcelMenager excelMenager = new ExcelMenager();

        private List<CountryClass> Lista = new List<CountryClass>();

        private List<OneDayOfPoland> DaysOfPoland = new List<OneDayOfPoland>();

        private int WhatWeSaving;

        #endregion

        #region Constructor

        public ExcelExportForm(List<CountryClass> List, List<OneDayOfPoland> Polandays, int wws)
        {
            InitializeComponent();

            Lista = List;

            WhatWeSaving = wws;

            DaysOfPoland = Polandays;
        }

        #endregion

        private void btnChangePath_Click(object sender, EventArgs e)
        {
            if(tbFileName.Text.Trim() == string.Empty)
            {
                return;
            }

            fileName = tbFileName.Text.Trim();

            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();

            DialogResult result = folderBrowser.ShowDialog();
            if(result == DialogResult.OK)
            {
                folderName = folderBrowser.SelectedPath;
                fullPath = folderName + "\\" + fileName + ".xlsx";
                tbPath.Text = fullPath;
            }

        }

        private async void btnCreate_Click(object sender, EventArgs e)
        {
            string msg = string.Empty;
            if(tbFileName.Text.Trim() == string.Empty)
            {
                msg = "file name can not be empty.";
                MessageBox.Show(msg, "empty file name", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(tbPath.Text.Trim() == string.Empty)
            {
                msg = "path can not be empty";
                MessageBox.Show(msg, "empty save path", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(tbSheetName.Text.Trim() == string.Empty)
            {
                msg = "call the sheet";
                MessageBox.Show(msg, "empty sheet name", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                sheetName = tbSheetName.Text;

                if (WhatWeSaving == 1)
                {
                    await excelMenager.WriteToExcel(Lista, fullPath, sheetName);
                }
                else
                {
                    await excelMenager.WriteToExcel2(DaysOfPoland, fullPath, sheetName);
                }

                Process process = new Process();
                try
                {
                    process.StartInfo.FileName = fullPath;
                    process.Start();

                }catch(Exception ex)
                {

                }

                this.Close();
            }
            
        }
    }
}
