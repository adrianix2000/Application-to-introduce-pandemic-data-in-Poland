namespace Covid_Data.Forms.MainForms
{
    partial class PolandDataForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelAlgorithms = new System.Windows.Forms.Panel();
            this.gbSearchDate = new System.Windows.Forms.GroupBox();
            this.tbDate = new System.Windows.Forms.TextBox();
            this.gbMinMaxComfirmed = new System.Windows.Forms.GroupBox();
            this.lblMinComfirmed = new System.Windows.Forms.Label();
            this.lblMinComfirmedDate = new System.Windows.Forms.Label();
            this.lblMaxComfirmed = new System.Windows.Forms.Label();
            this.lblMaxComfirmedDate = new System.Windows.Forms.Label();
            this.gbMaxMinDeaths = new System.Windows.Forms.GroupBox();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblMinDate = new System.Windows.Forms.Label();
            this.lblMaxNumber = new System.Windows.Forms.Label();
            this.lblMaxDate = new System.Windows.Forms.Label();
            this.panelDataGrid = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newConfirmedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalConfirmedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newDeathsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDeathsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oneDayOfPolandBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelTimeRange = new System.Windows.Forms.Label();
            this.btnRefresh = new FontAwesome.Sharp.IconButton();
            this.btnExcelExport = new FontAwesome.Sharp.IconButton();
            this.panelCharts = new System.Windows.Forms.Panel();
            this.chartConfirmed = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartDeaths = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.panelAlgorithms.SuspendLayout();
            this.gbSearchDate.SuspendLayout();
            this.gbMinMaxComfirmed.SuspendLayout();
            this.gbMaxMinDeaths.SuspendLayout();
            this.panelDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oneDayOfPolandBindingSource)).BeginInit();
            this.panelTop.SuspendLayout();
            this.panelCharts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartConfirmed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDeaths)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAlgorithms
            // 
            this.panelAlgorithms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.panelAlgorithms.Controls.Add(this.gbSearchDate);
            this.panelAlgorithms.Controls.Add(this.gbMinMaxComfirmed);
            this.panelAlgorithms.Controls.Add(this.gbMaxMinDeaths);
            this.panelAlgorithms.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelAlgorithms.Location = new System.Drawing.Point(756, 0);
            this.panelAlgorithms.Name = "panelAlgorithms";
            this.panelAlgorithms.Size = new System.Drawing.Size(388, 694);
            this.panelAlgorithms.TabIndex = 0;
            // 
            // gbSearchDate
            // 
            this.gbSearchDate.Controls.Add(this.monthCalendar1);
            this.gbSearchDate.Controls.Add(this.tbDate);
            this.gbSearchDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbSearchDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbSearchDate.ForeColor = System.Drawing.Color.Gainsboro;
            this.gbSearchDate.Location = new System.Drawing.Point(0, 354);
            this.gbSearchDate.Name = "gbSearchDate";
            this.gbSearchDate.Size = new System.Drawing.Size(388, 340);
            this.gbSearchDate.TabIndex = 2;
            this.gbSearchDate.TabStop = false;
            this.gbSearchDate.Text = "Search date";
            // 
            // tbDate
            // 
            this.tbDate.Location = new System.Drawing.Point(34, 248);
            this.tbDate.Name = "tbDate";
            this.tbDate.Size = new System.Drawing.Size(325, 30);
            this.tbDate.TabIndex = 1;
            // 
            // gbMinMaxComfirmed
            // 
            this.gbMinMaxComfirmed.Controls.Add(this.lblMinComfirmed);
            this.gbMinMaxComfirmed.Controls.Add(this.lblMinComfirmedDate);
            this.gbMinMaxComfirmed.Controls.Add(this.lblMaxComfirmed);
            this.gbMinMaxComfirmed.Controls.Add(this.lblMaxComfirmedDate);
            this.gbMinMaxComfirmed.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbMinMaxComfirmed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbMinMaxComfirmed.ForeColor = System.Drawing.Color.Gainsboro;
            this.gbMinMaxComfirmed.Location = new System.Drawing.Point(0, 186);
            this.gbMinMaxComfirmed.Name = "gbMinMaxComfirmed";
            this.gbMinMaxComfirmed.Size = new System.Drawing.Size(388, 168);
            this.gbMinMaxComfirmed.TabIndex = 1;
            this.gbMinMaxComfirmed.TabStop = false;
            this.gbMinMaxComfirmed.Text = "Min/Max new Comfirmed";
            // 
            // lblMinComfirmed
            // 
            this.lblMinComfirmed.AutoSize = true;
            this.lblMinComfirmed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMinComfirmed.Location = new System.Drawing.Point(30, 143);
            this.lblMinComfirmed.Name = "lblMinComfirmed";
            this.lblMinComfirmed.Size = new System.Drawing.Size(101, 20);
            this.lblMinComfirmed.TabIndex = 4;
            this.lblMinComfirmed.Text = "Min deaths: ";
            // 
            // lblMinComfirmedDate
            // 
            this.lblMinComfirmedDate.AutoSize = true;
            this.lblMinComfirmedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMinComfirmedDate.Location = new System.Drawing.Point(30, 113);
            this.lblMinComfirmedDate.Name = "lblMinComfirmedDate";
            this.lblMinComfirmedDate.Size = new System.Drawing.Size(83, 20);
            this.lblMinComfirmedDate.TabIndex = 5;
            this.lblMinComfirmedDate.Text = "Min date: ";
            // 
            // lblMaxComfirmed
            // 
            this.lblMaxComfirmed.AutoSize = true;
            this.lblMaxComfirmed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMaxComfirmed.Location = new System.Drawing.Point(26, 65);
            this.lblMaxComfirmed.Name = "lblMaxComfirmed";
            this.lblMaxComfirmed.Size = new System.Drawing.Size(134, 20);
            this.lblMaxComfirmed.TabIndex = 4;
            this.lblMaxComfirmed.Text = "Max comfirmed: ";
            // 
            // lblMaxComfirmedDate
            // 
            this.lblMaxComfirmedDate.AutoSize = true;
            this.lblMaxComfirmedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMaxComfirmedDate.Location = new System.Drawing.Point(26, 36);
            this.lblMaxComfirmedDate.Name = "lblMaxComfirmedDate";
            this.lblMaxComfirmedDate.Size = new System.Drawing.Size(87, 20);
            this.lblMaxComfirmedDate.TabIndex = 1;
            this.lblMaxComfirmedDate.Text = "Max date: ";
            // 
            // gbMaxMinDeaths
            // 
            this.gbMaxMinDeaths.Controls.Add(this.lblMin);
            this.gbMaxMinDeaths.Controls.Add(this.lblMinDate);
            this.gbMaxMinDeaths.Controls.Add(this.lblMaxNumber);
            this.gbMaxMinDeaths.Controls.Add(this.lblMaxDate);
            this.gbMaxMinDeaths.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbMaxMinDeaths.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbMaxMinDeaths.ForeColor = System.Drawing.Color.Gainsboro;
            this.gbMaxMinDeaths.Location = new System.Drawing.Point(0, 0);
            this.gbMaxMinDeaths.Name = "gbMaxMinDeaths";
            this.gbMaxMinDeaths.Size = new System.Drawing.Size(388, 186);
            this.gbMaxMinDeaths.TabIndex = 0;
            this.gbMaxMinDeaths.TabStop = false;
            this.gbMaxMinDeaths.Text = "Min/Max new deaths";
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMin.Location = new System.Drawing.Point(26, 144);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(101, 20);
            this.lblMin.TabIndex = 3;
            this.lblMin.Text = "Min deaths: ";
            // 
            // lblMinDate
            // 
            this.lblMinDate.AutoSize = true;
            this.lblMinDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMinDate.Location = new System.Drawing.Point(26, 115);
            this.lblMinDate.Name = "lblMinDate";
            this.lblMinDate.Size = new System.Drawing.Size(83, 20);
            this.lblMinDate.TabIndex = 2;
            this.lblMinDate.Text = "Min date: ";
            // 
            // lblMaxNumber
            // 
            this.lblMaxNumber.AutoSize = true;
            this.lblMaxNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMaxNumber.Location = new System.Drawing.Point(26, 68);
            this.lblMaxNumber.Name = "lblMaxNumber";
            this.lblMaxNumber.Size = new System.Drawing.Size(105, 20);
            this.lblMaxNumber.TabIndex = 1;
            this.lblMaxNumber.Text = "Max deaths: ";
            // 
            // lblMaxDate
            // 
            this.lblMaxDate.AutoSize = true;
            this.lblMaxDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMaxDate.Location = new System.Drawing.Point(26, 39);
            this.lblMaxDate.Name = "lblMaxDate";
            this.lblMaxDate.Size = new System.Drawing.Size(87, 20);
            this.lblMaxDate.TabIndex = 0;
            this.lblMaxDate.Text = "Max date: ";
            // 
            // panelDataGrid
            // 
            this.panelDataGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.panelDataGrid.Controls.Add(this.dataGridView1);
            this.panelDataGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelDataGrid.Location = new System.Drawing.Point(0, 508);
            this.panelDataGrid.Name = "panelDataGrid";
            this.panelDataGrid.Size = new System.Drawing.Size(756, 186);
            this.panelDataGrid.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.newConfirmedDataGridViewTextBoxColumn,
            this.totalConfirmedDataGridViewTextBoxColumn,
            this.newDeathsDataGridViewTextBoxColumn,
            this.totalDeathsDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.oneDayOfPolandBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(756, 186);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // newConfirmedDataGridViewTextBoxColumn
            // 
            this.newConfirmedDataGridViewTextBoxColumn.DataPropertyName = "NewConfirmed";
            this.newConfirmedDataGridViewTextBoxColumn.HeaderText = "NewConfirmed";
            this.newConfirmedDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.newConfirmedDataGridViewTextBoxColumn.Name = "newConfirmedDataGridViewTextBoxColumn";
            this.newConfirmedDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalConfirmedDataGridViewTextBoxColumn
            // 
            this.totalConfirmedDataGridViewTextBoxColumn.DataPropertyName = "TotalConfirmed";
            this.totalConfirmedDataGridViewTextBoxColumn.HeaderText = "TotalConfirmed";
            this.totalConfirmedDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalConfirmedDataGridViewTextBoxColumn.Name = "totalConfirmedDataGridViewTextBoxColumn";
            this.totalConfirmedDataGridViewTextBoxColumn.Width = 125;
            // 
            // newDeathsDataGridViewTextBoxColumn
            // 
            this.newDeathsDataGridViewTextBoxColumn.DataPropertyName = "NewDeaths";
            this.newDeathsDataGridViewTextBoxColumn.HeaderText = "NewDeaths";
            this.newDeathsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.newDeathsDataGridViewTextBoxColumn.Name = "newDeathsDataGridViewTextBoxColumn";
            this.newDeathsDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalDeathsDataGridViewTextBoxColumn
            // 
            this.totalDeathsDataGridViewTextBoxColumn.DataPropertyName = "TotalDeaths";
            this.totalDeathsDataGridViewTextBoxColumn.HeaderText = "TotalDeaths";
            this.totalDeathsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalDeathsDataGridViewTextBoxColumn.Name = "totalDeathsDataGridViewTextBoxColumn";
            this.totalDeathsDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 125;
            // 
            // oneDayOfPolandBindingSource
            // 
            this.oneDayOfPolandBindingSource.DataSource = typeof(Covid_Data.DataLayer.DataModels.OneDayOfPoland);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.panelTop.Controls.Add(this.labelTimeRange);
            this.panelTop.Controls.Add(this.btnRefresh);
            this.panelTop.Controls.Add(this.btnExcelExport);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(756, 64);
            this.panelTop.TabIndex = 2;
            // 
            // labelTimeRange
            // 
            this.labelTimeRange.AutoSize = true;
            this.labelTimeRange.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelTimeRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTimeRange.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelTimeRange.Location = new System.Drawing.Point(194, 0);
            this.labelTimeRange.Name = "labelTimeRange";
            this.labelTimeRange.Size = new System.Drawing.Size(146, 29);
            this.labelTimeRange.TabIndex = 7;
            this.labelTimeRange.Text = "Time Range";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRefresh.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnRefresh.IconChar = FontAwesome.Sharp.IconChar.SyncAlt;
            this.btnRefresh.IconColor = System.Drawing.Color.Gainsboro;
            this.btnRefresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRefresh.Location = new System.Drawing.Point(583, 0);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(173, 64);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "Refresh data";
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
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
            this.btnExcelExport.Location = new System.Drawing.Point(0, 0);
            this.btnExcelExport.Name = "btnExcelExport";
            this.btnExcelExport.Size = new System.Drawing.Size(194, 64);
            this.btnExcelExport.TabIndex = 5;
            this.btnExcelExport.Text = "Excel export";
            this.btnExcelExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcelExport.UseVisualStyleBackColor = true;
            this.btnExcelExport.Click += new System.EventHandler(this.btnExcelExport_Click);
            this.btnExcelExport.MouseLeave += new System.EventHandler(this.btnExcelExport_MouseLeave);
            this.btnExcelExport.MouseHover += new System.EventHandler(this.btnExcelExport_MouseHover);
            // 
            // panelCharts
            // 
            this.panelCharts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panelCharts.Controls.Add(this.chartConfirmed);
            this.panelCharts.Controls.Add(this.chartDeaths);
            this.panelCharts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCharts.Location = new System.Drawing.Point(0, 64);
            this.panelCharts.Name = "panelCharts";
            this.panelCharts.Size = new System.Drawing.Size(756, 444);
            this.panelCharts.TabIndex = 3;
            // 
            // chartConfirmed
            // 
            chartArea3.Name = "ChartArea1";
            this.chartConfirmed.ChartAreas.Add(chartArea3);
            this.chartConfirmed.Dock = System.Windows.Forms.DockStyle.Left;
            legend3.Name = "Legend1";
            this.chartConfirmed.Legends.Add(legend3);
            this.chartConfirmed.Location = new System.Drawing.Point(352, 0);
            this.chartConfirmed.Name = "chartConfirmed";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartConfirmed.Series.Add(series3);
            this.chartConfirmed.Size = new System.Drawing.Size(300, 444);
            this.chartConfirmed.TabIndex = 1;
            this.chartConfirmed.Text = "chart2";
            // 
            // chartDeaths
            // 
            chartArea4.Name = "ChartArea1";
            this.chartDeaths.ChartAreas.Add(chartArea4);
            this.chartDeaths.Dock = System.Windows.Forms.DockStyle.Left;
            legend4.Name = "Legend1";
            this.chartDeaths.Legends.Add(legend4);
            this.chartDeaths.Location = new System.Drawing.Point(0, 0);
            this.chartDeaths.Name = "chartDeaths";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartDeaths.Series.Add(series4);
            this.chartDeaths.Size = new System.Drawing.Size(352, 444);
            this.chartDeaths.TabIndex = 0;
            this.chartDeaths.Text = "chart1";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(34, 35);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 2;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // PolandDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(1144, 694);
            this.Controls.Add(this.panelCharts);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelDataGrid);
            this.Controls.Add(this.panelAlgorithms);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1162, 741);
            this.Name = "PolandDataForm";
            this.Text = "PolandDataForm";
            this.Load += new System.EventHandler(this.PolandDataForm_Load);
            this.Resize += new System.EventHandler(this.PolandDataForm_Resize);
            this.panelAlgorithms.ResumeLayout(false);
            this.gbSearchDate.ResumeLayout(false);
            this.gbSearchDate.PerformLayout();
            this.gbMinMaxComfirmed.ResumeLayout(false);
            this.gbMinMaxComfirmed.PerformLayout();
            this.gbMaxMinDeaths.ResumeLayout(false);
            this.gbMaxMinDeaths.PerformLayout();
            this.panelDataGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oneDayOfPolandBindingSource)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelCharts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartConfirmed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDeaths)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAlgorithms;
        private System.Windows.Forms.Panel panelDataGrid;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn newConfirmedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalConfirmedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn newDeathsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDeathsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource oneDayOfPolandBindingSource;
        private System.Windows.Forms.Panel panelTop;
        private FontAwesome.Sharp.IconButton btnExcelExport;
        private System.Windows.Forms.GroupBox gbMaxMinDeaths;
        private System.Windows.Forms.Label lblMaxDate;
        private System.Windows.Forms.Label lblMaxNumber;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblMinDate;
        private System.Windows.Forms.GroupBox gbMinMaxComfirmed;
        private System.Windows.Forms.Label lblMinComfirmed;
        private System.Windows.Forms.Label lblMinComfirmedDate;
        private System.Windows.Forms.Label lblMaxComfirmed;
        private System.Windows.Forms.Label lblMaxComfirmedDate;
        private System.Windows.Forms.Panel panelCharts;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartConfirmed;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDeaths;
        private System.Windows.Forms.Label labelTimeRange;
        private FontAwesome.Sharp.IconButton btnRefresh;
        private System.Windows.Forms.GroupBox gbSearchDate;
        private System.Windows.Forms.TextBox tbDate;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}