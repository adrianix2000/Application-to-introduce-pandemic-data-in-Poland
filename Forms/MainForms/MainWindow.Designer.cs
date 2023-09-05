namespace Covid_Data.Forms.MainForms
{
    partial class MainWindow
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
            this.pbIcon = new FontAwesome.Sharp.IconPictureBox();
            this.lblDataCovid = new System.Windows.Forms.Label();
            this.btnMinimized = new FontAwesome.Sharp.IconButton();
            this.btnMaximized = new FontAwesome.Sharp.IconButton();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.panelMiddle = new System.Windows.Forms.Panel();
            this.panelDataSourceInfo = new System.Windows.Forms.Panel();
            this.tbDataBaseServer = new System.Windows.Forms.TextBox();
            this.tbPublicServer = new System.Windows.Forms.TextBox();
            this.pbDatabaseServer = new FontAwesome.Sharp.IconPictureBox();
            this.pbPublicServer = new FontAwesome.Sharp.IconPictureBox();
            this.lblDataBaseServerName = new System.Windows.Forms.Label();
            this.lblPublicServerAdress = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnYesterday = new FontAwesome.Sharp.IconButton();
            this.btnPoland = new FontAwesome.Sharp.IconButton();
            this.btnGeoChart = new FontAwesome.Sharp.IconButton();
            this.btnInfo = new FontAwesome.Sharp.IconButton();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.pbActualPage = new FontAwesome.Sharp.IconPictureBox();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            this.panelFooter.SuspendLayout();
            this.panelMiddle.SuspendLayout();
            this.panelDataSourceInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDatabaseServer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPublicServer)).BeginInit();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbActualPage)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.panelTop.Controls.Add(this.pbIcon);
            this.panelTop.Controls.Add(this.lblDataCovid);
            this.panelTop.Controls.Add(this.btnMinimized);
            this.panelTop.Controls.Add(this.btnMaximized);
            this.panelTop.Controls.Add(this.btnExit);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1420, 36);
            this.panelTop.TabIndex = 0;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // pbIcon
            // 
            this.pbIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.pbIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.pbIcon.IconChar = FontAwesome.Sharp.IconChar.Virus;
            this.pbIcon.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.pbIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pbIcon.IconSize = 36;
            this.pbIcon.Location = new System.Drawing.Point(0, 0);
            this.pbIcon.Name = "pbIcon";
            this.pbIcon.Size = new System.Drawing.Size(45, 36);
            this.pbIcon.TabIndex = 4;
            this.pbIcon.TabStop = false;
            // 
            // lblDataCovid
            // 
            this.lblDataCovid.AutoSize = true;
            this.lblDataCovid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDataCovid.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblDataCovid.Location = new System.Drawing.Point(62, 7);
            this.lblDataCovid.Name = "lblDataCovid";
            this.lblDataCovid.Size = new System.Drawing.Size(129, 20);
            this.lblDataCovid.TabIndex = 1;
            this.lblDataCovid.Text = "Covid data 2021";
            // 
            // btnMinimized
            // 
            this.btnMinimized.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimized.FlatAppearance.BorderSize = 0;
            this.btnMinimized.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimized.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimized.IconColor = System.Drawing.Color.Gainsboro;
            this.btnMinimized.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimized.IconSize = 32;
            this.btnMinimized.Location = new System.Drawing.Point(1261, 0);
            this.btnMinimized.Name = "btnMinimized";
            this.btnMinimized.Size = new System.Drawing.Size(53, 36);
            this.btnMinimized.TabIndex = 3;
            this.btnMinimized.UseVisualStyleBackColor = true;
            this.btnMinimized.Click += new System.EventHandler(this.btnMinimized_Click);
            // 
            // btnMaximized
            // 
            this.btnMaximized.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximized.FlatAppearance.BorderSize = 0;
            this.btnMaximized.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximized.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btnMaximized.IconColor = System.Drawing.Color.Gainsboro;
            this.btnMaximized.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximized.IconSize = 32;
            this.btnMaximized.Location = new System.Drawing.Point(1314, 0);
            this.btnMaximized.Name = "btnMaximized";
            this.btnMaximized.Size = new System.Drawing.Size(53, 36);
            this.btnMaximized.TabIndex = 2;
            this.btnMaximized.UseVisualStyleBackColor = true;
            this.btnMaximized.Click += new System.EventHandler(this.btnMaximized_Click);
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnExit.IconColor = System.Drawing.Color.Gainsboro;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 32;
            this.btnExit.Location = new System.Drawing.Point(1367, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(53, 36);
            this.btnExit.TabIndex = 1;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.panelFooter.Controls.Add(this.lblAuthor);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 782);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(1420, 55);
            this.panelFooter.TabIndex = 1;
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAuthor.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblAuthor.Location = new System.Drawing.Point(32, 15);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(149, 20);
            this.lblAuthor.TabIndex = 0;
            this.lblAuthor.Text = "Author: Adrian Sak";
            // 
            // panelMiddle
            // 
            this.panelMiddle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.panelMiddle.Controls.Add(this.pbActualPage);
            this.panelMiddle.Controls.Add(this.panelDataSourceInfo);
            this.panelMiddle.Controls.Add(this.lblTitle);
            this.panelMiddle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMiddle.Location = new System.Drawing.Point(0, 36);
            this.panelMiddle.Name = "panelMiddle";
            this.panelMiddle.Size = new System.Drawing.Size(1420, 71);
            this.panelMiddle.TabIndex = 2;
            // 
            // panelDataSourceInfo
            // 
            this.panelDataSourceInfo.Controls.Add(this.tbDataBaseServer);
            this.panelDataSourceInfo.Controls.Add(this.tbPublicServer);
            this.panelDataSourceInfo.Controls.Add(this.pbDatabaseServer);
            this.panelDataSourceInfo.Controls.Add(this.pbPublicServer);
            this.panelDataSourceInfo.Controls.Add(this.lblDataBaseServerName);
            this.panelDataSourceInfo.Controls.Add(this.lblPublicServerAdress);
            this.panelDataSourceInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelDataSourceInfo.Location = new System.Drawing.Point(941, 0);
            this.panelDataSourceInfo.Name = "panelDataSourceInfo";
            this.panelDataSourceInfo.Size = new System.Drawing.Size(479, 71);
            this.panelDataSourceInfo.TabIndex = 1;
            // 
            // tbDataBaseServer
            // 
            this.tbDataBaseServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.tbDataBaseServer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDataBaseServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbDataBaseServer.ForeColor = System.Drawing.Color.Gainsboro;
            this.tbDataBaseServer.Location = new System.Drawing.Point(215, 41);
            this.tbDataBaseServer.Name = "tbDataBaseServer";
            this.tbDataBaseServer.Size = new System.Drawing.Size(252, 17);
            this.tbDataBaseServer.TabIndex = 3;
            // 
            // tbPublicServer
            // 
            this.tbPublicServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.tbPublicServer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPublicServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbPublicServer.ForeColor = System.Drawing.Color.Gainsboro;
            this.tbPublicServer.Location = new System.Drawing.Point(215, 14);
            this.tbPublicServer.Name = "tbPublicServer";
            this.tbPublicServer.Size = new System.Drawing.Size(252, 17);
            this.tbPublicServer.TabIndex = 2;
            // 
            // pbDatabaseServer
            // 
            this.pbDatabaseServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.pbDatabaseServer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(171)))), ((int)(((byte)(0)))));
            this.pbDatabaseServer.IconChar = FontAwesome.Sharp.IconChar.Database;
            this.pbDatabaseServer.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(171)))), ((int)(((byte)(0)))));
            this.pbDatabaseServer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pbDatabaseServer.Location = new System.Drawing.Point(3, 33);
            this.pbDatabaseServer.Name = "pbDatabaseServer";
            this.pbDatabaseServer.Size = new System.Drawing.Size(42, 32);
            this.pbDatabaseServer.TabIndex = 0;
            this.pbDatabaseServer.TabStop = false;
            // 
            // pbPublicServer
            // 
            this.pbPublicServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.pbPublicServer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.pbPublicServer.IconChar = FontAwesome.Sharp.IconChar.Server;
            this.pbPublicServer.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.pbPublicServer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pbPublicServer.Location = new System.Drawing.Point(3, 3);
            this.pbPublicServer.Name = "pbPublicServer";
            this.pbPublicServer.Size = new System.Drawing.Size(42, 32);
            this.pbPublicServer.TabIndex = 0;
            this.pbPublicServer.TabStop = false;
            // 
            // lblDataBaseServerName
            // 
            this.lblDataBaseServerName.AutoSize = true;
            this.lblDataBaseServerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDataBaseServerName.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblDataBaseServerName.Location = new System.Drawing.Point(51, 41);
            this.lblDataBaseServerName.Name = "lblDataBaseServerName";
            this.lblDataBaseServerName.Size = new System.Drawing.Size(128, 18);
            this.lblDataBaseServerName.TabIndex = 1;
            this.lblDataBaseServerName.Text = "Data base server: ";
            // 
            // lblPublicServerAdress
            // 
            this.lblPublicServerAdress.AutoSize = true;
            this.lblPublicServerAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPublicServerAdress.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblPublicServerAdress.Location = new System.Drawing.Point(51, 14);
            this.lblPublicServerAdress.Name = "lblPublicServerAdress";
            this.lblPublicServerAdress.Size = new System.Drawing.Size(158, 18);
            this.lblPublicServerAdress.TabIndex = 0;
            this.lblPublicServerAdress.Text = "Public server address: ";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitle.Location = new System.Drawing.Point(21, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(332, 36);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Covid data project 2021";
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.panelMenu.Controls.Add(this.btnYesterday);
            this.panelMenu.Controls.Add(this.btnPoland);
            this.panelMenu.Controls.Add(this.btnGeoChart);
            this.panelMenu.Controls.Add(this.btnInfo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 107);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(281, 675);
            this.panelMenu.TabIndex = 3;
            // 
            // btnYesterday
            // 
            this.btnYesterday.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnYesterday.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.btnYesterday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYesterday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnYesterday.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnYesterday.IconChar = FontAwesome.Sharp.IconChar.Globe;
            this.btnYesterday.IconColor = System.Drawing.Color.Gainsboro;
            this.btnYesterday.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnYesterday.IconSize = 36;
            this.btnYesterday.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYesterday.Location = new System.Drawing.Point(0, 222);
            this.btnYesterday.Name = "btnYesterday";
            this.btnYesterday.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnYesterday.Size = new System.Drawing.Size(281, 72);
            this.btnYesterday.TabIndex = 3;
            this.btnYesterday.Text = "yyyy-mm-dd";
            this.btnYesterday.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYesterday.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnYesterday.UseVisualStyleBackColor = true;
            this.btnYesterday.Click += new System.EventHandler(this.btnYesterday_Click);
            this.btnYesterday.MouseLeave += new System.EventHandler(this.iconButton2_MouseLeave);
            this.btnYesterday.MouseHover += new System.EventHandler(this.iconButton2_MouseHover);
            // 
            // btnPoland
            // 
            this.btnPoland.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPoland.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.btnPoland.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPoland.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPoland.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPoland.IconChar = FontAwesome.Sharp.IconChar.Question;
            this.btnPoland.IconColor = System.Drawing.Color.Gainsboro;
            this.btnPoland.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPoland.IconSize = 36;
            this.btnPoland.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPoland.Location = new System.Drawing.Point(0, 150);
            this.btnPoland.Name = "btnPoland";
            this.btnPoland.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnPoland.Size = new System.Drawing.Size(281, 72);
            this.btnPoland.TabIndex = 2;
            this.btnPoland.Text = "Poland case";
            this.btnPoland.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPoland.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPoland.UseVisualStyleBackColor = true;
            this.btnPoland.Click += new System.EventHandler(this.btnPoland_Click);
            this.btnPoland.MouseLeave += new System.EventHandler(this.btnPoland_MouseLeave);
            this.btnPoland.MouseHover += new System.EventHandler(this.btnPoland_MouseHover);
            // 
            // btnGeoChart
            // 
            this.btnGeoChart.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGeoChart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.btnGeoChart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeoChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnGeoChart.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnGeoChart.IconChar = FontAwesome.Sharp.IconChar.GlobeEurope;
            this.btnGeoChart.IconColor = System.Drawing.Color.Gainsboro;
            this.btnGeoChart.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGeoChart.IconSize = 36;
            this.btnGeoChart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGeoChart.Location = new System.Drawing.Point(0, 78);
            this.btnGeoChart.Name = "btnGeoChart";
            this.btnGeoChart.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnGeoChart.Size = new System.Drawing.Size(281, 72);
            this.btnGeoChart.TabIndex = 1;
            this.btnGeoChart.Text = "World chart";
            this.btnGeoChart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGeoChart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGeoChart.UseVisualStyleBackColor = true;
            this.btnGeoChart.Click += new System.EventHandler(this.btnGeoChart_Click);
            this.btnGeoChart.MouseLeave += new System.EventHandler(this.btnGeoChart_MouseLeave);
            this.btnGeoChart.MouseHover += new System.EventHandler(this.btnGeoChart_MouseHover);
            // 
            // btnInfo
            // 
            this.btnInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInfo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnInfo.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnInfo.IconChar = FontAwesome.Sharp.IconChar.Question;
            this.btnInfo.IconColor = System.Drawing.Color.Gainsboro;
            this.btnInfo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInfo.IconSize = 36;
            this.btnInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfo.Location = new System.Drawing.Point(0, 0);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnInfo.Size = new System.Drawing.Size(281, 78);
            this.btnInfo.TabIndex = 0;
            this.btnInfo.Text = "Information";
            this.btnInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            this.btnInfo.MouseLeave += new System.EventHandler(this.btnInfo_MouseLeave);
            this.btnInfo.MouseHover += new System.EventHandler(this.btnInfo_MouseHover);
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(281, 107);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1139, 675);
            this.panelDesktop.TabIndex = 4;
            // 
            // pbActualPage
            // 
            this.pbActualPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.pbActualPage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pbActualPage.IconChar = FontAwesome.Sharp.IconChar.None;
            this.pbActualPage.IconColor = System.Drawing.SystemColors.ControlText;
            this.pbActualPage.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pbActualPage.IconSize = 60;
            this.pbActualPage.Location = new System.Drawing.Point(369, 5);
            this.pbActualPage.Name = "pbActualPage";
            this.pbActualPage.Size = new System.Drawing.Size(78, 60);
            this.pbActualPage.TabIndex = 2;
            this.pbActualPage.TabStop = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1420, 837);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelMiddle);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panelTop);
            this.MinimumSize = new System.Drawing.Size(1150, 707);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainWindow";
            this.Resize += new System.EventHandler(this.MainWindow_Resize);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
            this.panelFooter.ResumeLayout(false);
            this.panelFooter.PerformLayout();
            this.panelMiddle.ResumeLayout(false);
            this.panelMiddle.PerformLayout();
            this.panelDataSourceInfo.ResumeLayout(false);
            this.panelDataSourceInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDatabaseServer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPublicServer)).EndInit();
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbActualPage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private FontAwesome.Sharp.IconButton btnExit;
        private FontAwesome.Sharp.IconButton btnMinimized;
        private FontAwesome.Sharp.IconButton btnMaximized;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Panel panelMiddle;
        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnInfo;
        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconButton btnGeoChart;
        private FontAwesome.Sharp.IconButton btnYesterday;
        private FontAwesome.Sharp.IconButton btnPoland;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelDataSourceInfo;
        private FontAwesome.Sharp.IconPictureBox pbPublicServer;
        private System.Windows.Forms.Label lblDataBaseServerName;
        private System.Windows.Forms.Label lblPublicServerAdress;
        private FontAwesome.Sharp.IconPictureBox pbDatabaseServer;
        private System.Windows.Forms.TextBox tbDataBaseServer;
        private System.Windows.Forms.TextBox tbPublicServer;
        private System.Windows.Forms.Label lblDataCovid;
        private System.Windows.Forms.Label lblAuthor;
        private FontAwesome.Sharp.IconPictureBox pbIcon;
        private FontAwesome.Sharp.IconPictureBox pbActualPage;
    }
}