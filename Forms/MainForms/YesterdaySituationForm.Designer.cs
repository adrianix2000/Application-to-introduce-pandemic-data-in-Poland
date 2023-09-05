namespace Covid_Data.Forms.MainForms
{
    partial class YesterdaySituationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.panelSearchTop = new System.Windows.Forms.Panel();
            this.btnSearch = new FontAwesome.Sharp.IconButton();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.lblCountryCode = new System.Windows.Forms.Label();
            this.lblCountryName = new System.Windows.Forms.Label();
            this.lblNewDeaths = new System.Windows.Forms.Label();
            this.lbCoutriesNames = new System.Windows.Forms.ListBox();
            this.lblNewComfirmed = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            this.panelSearch.SuspendLayout();
            this.panelSearchTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.panelTop.Controls.Add(this.lblDate);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(993, 56);
            this.panelTop.TabIndex = 0;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblDate.Location = new System.Drawing.Point(24, 9);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(139, 30);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "cases from: ";
            // 
            // panelSearch
            // 
            this.panelSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.panelSearch.Controls.Add(this.lbCoutriesNames);
            this.panelSearch.Controls.Add(this.panelSearchTop);
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelSearch.Location = new System.Drawing.Point(588, 56);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(405, 567);
            this.panelSearch.TabIndex = 1;
            // 
            // panelSearchTop
            // 
            this.panelSearchTop.Controls.Add(this.btnSearch);
            this.panelSearchTop.Controls.Add(this.tbSearch);
            this.panelSearchTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearchTop.Location = new System.Drawing.Point(0, 0);
            this.panelSearchTop.Name = "panelSearchTop";
            this.panelSearchTop.Size = new System.Drawing.Size(405, 52);
            this.panelSearchTop.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSearch.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSearch.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSearch.IconColor = System.Drawing.Color.DimGray;
            this.btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearch.Location = new System.Drawing.Point(326, 0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(73, 52);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.tbSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSearch.Dock = System.Windows.Forms.DockStyle.Left;
            this.tbSearch.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.tbSearch.Location = new System.Drawing.Point(0, 0);
            this.tbSearch.Multiline = true;
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(326, 52);
            this.tbSearch.TabIndex = 4;
            this.tbSearch.Text = "Search country";
            this.tbSearch.Enter += new System.EventHandler(this.tbSearch_Enter);
            this.tbSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbSearch_KeyUp);
            this.tbSearch.Leave += new System.EventHandler(this.tbSearch_Leave);
            // 
            // lblCountryCode
            // 
            this.lblCountryCode.AutoSize = true;
            this.lblCountryCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCountryCode.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblCountryCode.Location = new System.Drawing.Point(54, 85);
            this.lblCountryCode.Name = "lblCountryCode";
            this.lblCountryCode.Size = new System.Drawing.Size(198, 32);
            this.lblCountryCode.TabIndex = 2;
            this.lblCountryCode.Text = "Country code: ";
            // 
            // lblCountryName
            // 
            this.lblCountryName.AutoSize = true;
            this.lblCountryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCountryName.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblCountryName.Location = new System.Drawing.Point(54, 140);
            this.lblCountryName.Name = "lblCountryName";
            this.lblCountryName.Size = new System.Drawing.Size(207, 32);
            this.lblCountryName.TabIndex = 3;
            this.lblCountryName.Text = "Country name: ";
            // 
            // lblNewDeaths
            // 
            this.lblNewDeaths.AutoSize = true;
            this.lblNewDeaths.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNewDeaths.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblNewDeaths.Location = new System.Drawing.Point(54, 197);
            this.lblNewDeaths.Name = "lblNewDeaths";
            this.lblNewDeaths.Size = new System.Drawing.Size(179, 32);
            this.lblNewDeaths.TabIndex = 4;
            this.lblNewDeaths.Text = "New deaths: ";
            // 
            // lbCoutriesNames
            // 
            this.lbCoutriesNames.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbCoutriesNames.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.lbCoutriesNames.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbCoutriesNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbCoutriesNames.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbCoutriesNames.FormattingEnabled = true;
            this.lbCoutriesNames.ItemHeight = 36;
            this.lbCoutriesNames.Location = new System.Drawing.Point(8, 58);
            this.lbCoutriesNames.Name = "lbCoutriesNames";
            this.lbCoutriesNames.Size = new System.Drawing.Size(318, 504);
            this.lbCoutriesNames.TabIndex = 10;
            this.lbCoutriesNames.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbCoutriesNames_MouseClick);
            this.lbCoutriesNames.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lbCoutriesNames_KeyUp);
            // 
            // lblNewComfirmed
            // 
            this.lblNewComfirmed.AutoSize = true;
            this.lblNewComfirmed.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNewComfirmed.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblNewComfirmed.Location = new System.Drawing.Point(54, 257);
            this.lblNewComfirmed.Name = "lblNewComfirmed";
            this.lblNewComfirmed.Size = new System.Drawing.Size(218, 32);
            this.lblNewComfirmed.TabIndex = 5;
            this.lblNewComfirmed.Text = "New confirmed: ";
            // 
            // YesterdaySituationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(993, 623);
            this.Controls.Add(this.lblNewComfirmed);
            this.Controls.Add(this.lblNewDeaths);
            this.Controls.Add(this.lblCountryName);
            this.Controls.Add(this.lblCountryCode);
            this.Controls.Add(this.panelSearch);
            this.Controls.Add(this.panelTop);
            this.Name = "YesterdaySituationForm";
            this.Text = "YesterdaySituationForm";
            this.Resize += new System.EventHandler(this.YesterdaySituationForm_Resize);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelSearch.ResumeLayout(false);
            this.panelSearchTop.ResumeLayout(false);
            this.panelSearchTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Panel panelSearchTop;
        private FontAwesome.Sharp.IconButton btnSearch;
        private System.Windows.Forms.Label lblCountryCode;
        private System.Windows.Forms.Label lblCountryName;
        private System.Windows.Forms.Label lblNewDeaths;
        private System.Windows.Forms.ListBox lbCoutriesNames;
        private System.Windows.Forms.Label lblNewComfirmed;
    }
}