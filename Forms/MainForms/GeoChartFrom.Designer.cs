namespace Covid_Data.Forms.MainForms
{
    partial class GeoChartFrom
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeoChartFrom));
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnRefresh = new FontAwesome.Sharp.IconButton();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.panelBottomRight = new System.Windows.Forms.Panel();
            this.pbGlobalRecoverd = new System.Windows.Forms.PictureBox();
            this.pbGlobalDeaths = new System.Windows.Forms.PictureBox();
            this.pbGlobalCases = new System.Windows.Forms.PictureBox();
            this.lblGlobalTotalRecoverd = new System.Windows.Forms.Label();
            this.lblGlobalTotalDeaths = new System.Windows.Forms.Label();
            this.lblGlobalTotalCases = new System.Windows.Forms.Label();
            this.lblTotalDeaths = new System.Windows.Forms.Label();
            this.lblTotalComfirmed = new System.Windows.Forms.Label();
            this.lblCountryName = new System.Windows.Forms.Label();
            this.MapPanel = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelTop.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.panelBottomRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGlobalRecoverd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGlobalDeaths)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGlobalCases)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panelTop.Controls.Add(this.btnRefresh);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1128, 52);
            this.panelTop.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnRefresh.FlatAppearance.BorderSize = 2;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRefresh.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnRefresh.IconChar = FontAwesome.Sharp.IconChar.NotesMedical;
            this.btnRefresh.IconColor = System.Drawing.Color.Gainsboro;
            this.btnRefresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRefresh.IconSize = 32;
            this.btnRefresh.Location = new System.Drawing.Point(0, 0);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(142, 52);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Refresh chart";
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panelBottom.Controls.Add(this.panelBottomRight);
            this.panelBottom.Controls.Add(this.lblTotalDeaths);
            this.panelBottom.Controls.Add(this.lblTotalComfirmed);
            this.panelBottom.Controls.Add(this.lblCountryName);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 561);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(1128, 128);
            this.panelBottom.TabIndex = 1;
            // 
            // panelBottomRight
            // 
            this.panelBottomRight.Controls.Add(this.pbGlobalRecoverd);
            this.panelBottomRight.Controls.Add(this.pbGlobalDeaths);
            this.panelBottomRight.Controls.Add(this.pbGlobalCases);
            this.panelBottomRight.Controls.Add(this.lblGlobalTotalRecoverd);
            this.panelBottomRight.Controls.Add(this.lblGlobalTotalDeaths);
            this.panelBottomRight.Controls.Add(this.lblGlobalTotalCases);
            this.panelBottomRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelBottomRight.Location = new System.Drawing.Point(513, 0);
            this.panelBottomRight.Name = "panelBottomRight";
            this.panelBottomRight.Size = new System.Drawing.Size(615, 128);
            this.panelBottomRight.TabIndex = 4;
            // 
            // pbGlobalRecoverd
            // 
            this.pbGlobalRecoverd.Image = ((System.Drawing.Image)(resources.GetObject("pbGlobalRecoverd.Image")));
            this.pbGlobalRecoverd.Location = new System.Drawing.Point(34, 88);
            this.pbGlobalRecoverd.Name = "pbGlobalRecoverd";
            this.pbGlobalRecoverd.Size = new System.Drawing.Size(42, 37);
            this.pbGlobalRecoverd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGlobalRecoverd.TabIndex = 11;
            this.pbGlobalRecoverd.TabStop = false;
            // 
            // pbGlobalDeaths
            // 
            this.pbGlobalDeaths.Image = ((System.Drawing.Image)(resources.GetObject("pbGlobalDeaths.Image")));
            this.pbGlobalDeaths.Location = new System.Drawing.Point(34, 46);
            this.pbGlobalDeaths.Name = "pbGlobalDeaths";
            this.pbGlobalDeaths.Size = new System.Drawing.Size(42, 37);
            this.pbGlobalDeaths.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGlobalDeaths.TabIndex = 10;
            this.pbGlobalDeaths.TabStop = false;
            // 
            // pbGlobalCases
            // 
            this.pbGlobalCases.Image = ((System.Drawing.Image)(resources.GetObject("pbGlobalCases.Image")));
            this.pbGlobalCases.Location = new System.Drawing.Point(34, 3);
            this.pbGlobalCases.Name = "pbGlobalCases";
            this.pbGlobalCases.Size = new System.Drawing.Size(42, 37);
            this.pbGlobalCases.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGlobalCases.TabIndex = 9;
            this.pbGlobalCases.TabStop = false;
            // 
            // lblGlobalTotalRecoverd
            // 
            this.lblGlobalTotalRecoverd.AutoSize = true;
            this.lblGlobalTotalRecoverd.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGlobalTotalRecoverd.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblGlobalTotalRecoverd.Location = new System.Drawing.Point(82, 92);
            this.lblGlobalTotalRecoverd.Name = "lblGlobalTotalRecoverd";
            this.lblGlobalTotalRecoverd.Size = new System.Drawing.Size(183, 27);
            this.lblGlobalTotalRecoverd.TabIndex = 8;
            this.lblGlobalTotalRecoverd.Text = "global recoverds: ";
            // 
            // lblGlobalTotalDeaths
            // 
            this.lblGlobalTotalDeaths.AutoSize = true;
            this.lblGlobalTotalDeaths.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGlobalTotalDeaths.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblGlobalTotalDeaths.Location = new System.Drawing.Point(82, 54);
            this.lblGlobalTotalDeaths.Name = "lblGlobalTotalDeaths";
            this.lblGlobalTotalDeaths.Size = new System.Drawing.Size(149, 27);
            this.lblGlobalTotalDeaths.TabIndex = 7;
            this.lblGlobalTotalDeaths.Text = "Global deaths ";
            // 
            // lblGlobalTotalCases
            // 
            this.lblGlobalTotalCases.AutoSize = true;
            this.lblGlobalTotalCases.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGlobalTotalCases.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblGlobalTotalCases.Location = new System.Drawing.Point(82, 13);
            this.lblGlobalTotalCases.Name = "lblGlobalTotalCases";
            this.lblGlobalTotalCases.Size = new System.Drawing.Size(141, 27);
            this.lblGlobalTotalCases.TabIndex = 4;
            this.lblGlobalTotalCases.Text = "Global cases: ";
            // 
            // lblTotalDeaths
            // 
            this.lblTotalDeaths.AutoSize = true;
            this.lblTotalDeaths.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDeaths.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTotalDeaths.Location = new System.Drawing.Point(39, 81);
            this.lblTotalDeaths.Name = "lblTotalDeaths";
            this.lblTotalDeaths.Size = new System.Drawing.Size(137, 25);
            this.lblTotalDeaths.TabIndex = 3;
            this.lblTotalDeaths.Text = "Total deaths: ";
            // 
            // lblTotalComfirmed
            // 
            this.lblTotalComfirmed.AutoSize = true;
            this.lblTotalComfirmed.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalComfirmed.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTotalComfirmed.Location = new System.Drawing.Point(39, 47);
            this.lblTotalComfirmed.Name = "lblTotalComfirmed";
            this.lblTotalComfirmed.Size = new System.Drawing.Size(164, 25);
            this.lblTotalComfirmed.TabIndex = 2;
            this.lblTotalComfirmed.Text = "Total comfirmed";
            // 
            // lblCountryName
            // 
            this.lblCountryName.AutoSize = true;
            this.lblCountryName.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountryName.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblCountryName.Location = new System.Drawing.Point(39, 13);
            this.lblCountryName.Name = "lblCountryName";
            this.lblCountryName.Size = new System.Drawing.Size(154, 25);
            this.lblCountryName.TabIndex = 1;
            this.lblCountryName.Text = "Country name: ";
            // 
            // MapPanel
            // 
            this.MapPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MapPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.MapPanel.Location = new System.Drawing.Point(12, 58);
            this.MapPanel.Name = "MapPanel";
            this.MapPanel.Size = new System.Drawing.Size(1104, 497);
            this.MapPanel.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // GeoChartFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1128, 689);
            this.Controls.Add(this.MapPanel);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.Name = "GeoChartFrom";
            this.Text = "GeoChartFrom";
            this.Load += new System.EventHandler(this.GeoChartFrom_Load);
            this.panelTop.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            this.panelBottomRight.ResumeLayout(false);
            this.panelBottomRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGlobalRecoverd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGlobalDeaths)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGlobalCases)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private FontAwesome.Sharp.IconButton btnRefresh;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Label lblTotalDeaths;
        private System.Windows.Forms.Label lblTotalComfirmed;
        private System.Windows.Forms.Label lblCountryName;
        private System.Windows.Forms.Panel panelBottomRight;
        private System.Windows.Forms.Label lblGlobalTotalRecoverd;
        private System.Windows.Forms.Label lblGlobalTotalDeaths;
        private System.Windows.Forms.Label lblGlobalTotalCases;
        private System.Windows.Forms.PictureBox pbGlobalRecoverd;
        private System.Windows.Forms.PictureBox pbGlobalDeaths;
        private System.Windows.Forms.PictureBox pbGlobalCases;
        private System.Windows.Forms.Panel MapPanel;
        private System.Windows.Forms.Timer timer1;
    }
}