namespace Covid_Data.Forms.MainForms.InformationForms
{
    partial class ServerDataShowForm
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
            this.tbData = new System.Windows.Forms.TextBox();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFindinText = new FontAwesome.Sharp.IconButton();
            this.tbFind = new System.Windows.Forms.TextBox();
            this.btnExcelExport = new FontAwesome.Sharp.IconButton();
            this.btnFont = new FontAwesome.Sharp.IconButton();
            this.btnJsonWhatIsIt = new FontAwesome.Sharp.IconButton();
            this.btnRefresh = new FontAwesome.Sharp.IconButton();
            this.panelJsonInfo = new System.Windows.Forms.Panel();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.panelTop.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelJsonInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbData
            // 
            this.tbData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.tbData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbData.ForeColor = System.Drawing.Color.Gainsboro;
            this.tbData.Location = new System.Drawing.Point(12, 82);
            this.tbData.Multiline = true;
            this.tbData.Name = "tbData";
            this.tbData.ReadOnly = true;
            this.tbData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbData.Size = new System.Drawing.Size(1212, 614);
            this.tbData.TabIndex = 0;
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.panel1);
            this.panelTop.Controls.Add(this.btnExcelExport);
            this.panelTop.Controls.Add(this.btnFont);
            this.panelTop.Controls.Add(this.btnJsonWhatIsIt);
            this.panelTop.Controls.Add(this.btnRefresh);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1236, 76);
            this.panelTop.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnFindinText);
            this.panel1.Controls.Add(this.tbFind);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(663, 0);
            this.panel1.MinimumSize = new System.Drawing.Size(514, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(573, 76);
            this.panel1.TabIndex = 5;
            // 
            // btnFindinText
            // 
            this.btnFindinText.FlatAppearance.BorderSize = 0;
            this.btnFindinText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindinText.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnFindinText.IconColor = System.Drawing.Color.Gainsboro;
            this.btnFindinText.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFindinText.IconSize = 40;
            this.btnFindinText.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFindinText.Location = new System.Drawing.Point(433, 12);
            this.btnFindinText.Name = "btnFindinText";
            this.btnFindinText.Size = new System.Drawing.Size(61, 49);
            this.btnFindinText.TabIndex = 4;
            this.btnFindinText.UseVisualStyleBackColor = true;
            this.btnFindinText.Click += new System.EventHandler(this.btnFindinText_Click);
            // 
            // tbFind
            // 
            this.tbFind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.tbFind.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbFind.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbFind.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.tbFind.Location = new System.Drawing.Point(14, 12);
            this.tbFind.Multiline = true;
            this.tbFind.Name = "tbFind";
            this.tbFind.Size = new System.Drawing.Size(413, 50);
            this.tbFind.TabIndex = 3;
            this.tbFind.Text = "find fraze";
            this.tbFind.Enter += new System.EventHandler(this.tbFind_Enter);
            this.tbFind.Leave += new System.EventHandler(this.tbFind_Leave);
            // 
            // btnExcelExport
            // 
            this.btnExcelExport.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnExcelExport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(105)))), ((int)(((byte)(30)))));
            this.btnExcelExport.FlatAppearance.BorderSize = 2;
            this.btnExcelExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcelExport.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnExcelExport.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnExcelExport.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.btnExcelExport.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(105)))), ((int)(((byte)(30)))));
            this.btnExcelExport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExcelExport.IconSize = 45;
            this.btnExcelExport.Location = new System.Drawing.Point(408, 0);
            this.btnExcelExport.Name = "btnExcelExport";
            this.btnExcelExport.Size = new System.Drawing.Size(194, 76);
            this.btnExcelExport.TabIndex = 4;
            this.btnExcelExport.Text = "Excel export";
            this.btnExcelExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcelExport.UseVisualStyleBackColor = true;
            this.btnExcelExport.Click += new System.EventHandler(this.btnExcelExport_Click);
            this.btnExcelExport.MouseLeave += new System.EventHandler(this.btnExcelExport_MouseLeave);
            this.btnExcelExport.MouseHover += new System.EventHandler(this.btnExcelExport_MouseHover);
            // 
            // btnFont
            // 
            this.btnFont.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnFont.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(108)))), ((int)(((byte)(0)))));
            this.btnFont.FlatAppearance.BorderSize = 2;
            this.btnFont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFont.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnFont.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnFont.IconChar = FontAwesome.Sharp.IconChar.Font;
            this.btnFont.IconColor = System.Drawing.Color.Gainsboro;
            this.btnFont.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFont.IconSize = 45;
            this.btnFont.Location = new System.Drawing.Point(330, 0);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(78, 76);
            this.btnFont.TabIndex = 2;
            this.btnFont.UseVisualStyleBackColor = true;
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // btnJsonWhatIsIt
            // 
            this.btnJsonWhatIsIt.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnJsonWhatIsIt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(92)))));
            this.btnJsonWhatIsIt.FlatAppearance.BorderSize = 2;
            this.btnJsonWhatIsIt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJsonWhatIsIt.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnJsonWhatIsIt.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnJsonWhatIsIt.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnJsonWhatIsIt.IconColor = System.Drawing.Color.Black;
            this.btnJsonWhatIsIt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnJsonWhatIsIt.IconSize = 32;
            this.btnJsonWhatIsIt.Location = new System.Drawing.Point(206, 0);
            this.btnJsonWhatIsIt.Name = "btnJsonWhatIsIt";
            this.btnJsonWhatIsIt.Size = new System.Drawing.Size(124, 76);
            this.btnJsonWhatIsIt.TabIndex = 1;
            this.btnJsonWhatIsIt.Text = "JSON ?";
            this.btnJsonWhatIsIt.UseVisualStyleBackColor = true;
            this.btnJsonWhatIsIt.MouseLeave += new System.EventHandler(this.btnJsonWhatIsIt_MouseLeave);
            this.btnJsonWhatIsIt.MouseHover += new System.EventHandler(this.btnJsonWhatIsIt_MouseHover);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRefresh.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnRefresh.IconChar = FontAwesome.Sharp.IconChar.SyncAlt;
            this.btnRefresh.IconColor = System.Drawing.Color.Gainsboro;
            this.btnRefresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRefresh.Location = new System.Drawing.Point(0, 0);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(206, 76);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Refresh data";
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            this.btnRefresh.MouseLeave += new System.EventHandler(this.btnRefresh_MouseLeave);
            this.btnRefresh.MouseHover += new System.EventHandler(this.btnRefresh_MouseHover);
            // 
            // panelJsonInfo
            // 
            this.panelJsonInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelJsonInfo.Controls.Add(this.pb2);
            this.panelJsonInfo.Controls.Add(this.pb1);
            this.panelJsonInfo.Location = new System.Drawing.Point(171, 145);
            this.panelJsonInfo.Name = "panelJsonInfo";
            this.panelJsonInfo.Size = new System.Drawing.Size(883, 437);
            this.panelJsonInfo.TabIndex = 2;
            this.panelJsonInfo.Visible = false;
            this.panelJsonInfo.Resize += new System.EventHandler(this.panelJsonInfo_Resize);
            // 
            // pb2
            // 
            this.pb2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pb2.Location = new System.Drawing.Point(598, 0);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(285, 437);
            this.pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb2.TabIndex = 1;
            this.pb2.TabStop = false;
            // 
            // pb1
            // 
            this.pb1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pb1.Location = new System.Drawing.Point(0, 0);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(284, 437);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb1.TabIndex = 0;
            this.pb1.TabStop = false;
            // 
            // ServerDataShowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(1236, 708);
            this.Controls.Add(this.panelJsonInfo);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.tbData);
            this.MinimumSize = new System.Drawing.Size(1254, 755);
            this.Name = "ServerDataShowForm";
            this.Text = "ServerDataShowForm";
            this.Load += new System.EventHandler(this.ServerDataShowForm_Load);
            this.panelTop.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelJsonInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbData;
        private System.Windows.Forms.Panel panelTop;
        private FontAwesome.Sharp.IconButton btnRefresh;
        private FontAwesome.Sharp.IconButton btnJsonWhatIsIt;
        private System.Windows.Forms.Panel panelJsonInfo;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.PictureBox pb1;
        private FontAwesome.Sharp.IconButton btnFont;
        private System.Windows.Forms.TextBox tbFind;
        private FontAwesome.Sharp.IconButton btnExcelExport;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnFindinText;
    }
}