namespace Covid_Data.Forms.MessageBoxes
{
    partial class OneDayForm
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
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblDeaths = new System.Windows.Forms.Label();
            this.lblConfirned = new System.Windows.Forms.Label();
            this.pbDeaths = new FontAwesome.Sharp.IconPictureBox();
            this.pbComirmed = new FontAwesome.Sharp.IconPictureBox();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeaths)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbComirmed)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panelTop.Controls.Add(this.btnExit);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(832, 44);
            this.panelTop.TabIndex = 0;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnExit.IconColor = System.Drawing.Color.Gainsboro;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 40;
            this.btnExit.Location = new System.Drawing.Point(765, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(67, 44);
            this.btnExit.TabIndex = 2;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDate.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblDate.Location = new System.Drawing.Point(69, 65);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(138, 51);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "label1";
            // 
            // lblDeaths
            // 
            this.lblDeaths.AutoSize = true;
            this.lblDeaths.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDeaths.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblDeaths.Location = new System.Drawing.Point(163, 175);
            this.lblDeaths.Name = "lblDeaths";
            this.lblDeaths.Size = new System.Drawing.Size(208, 38);
            this.lblDeaths.TabIndex = 2;
            this.lblDeaths.Text = "New deaths: ";
            // 
            // lblConfirned
            // 
            this.lblConfirned.AutoSize = true;
            this.lblConfirned.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblConfirned.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblConfirned.Location = new System.Drawing.Point(163, 269);
            this.lblConfirned.Name = "lblConfirned";
            this.lblConfirned.Size = new System.Drawing.Size(251, 38);
            this.lblConfirned.TabIndex = 3;
            this.lblConfirned.Text = "New Comirned: ";
            // 
            // pbDeaths
            // 
            this.pbDeaths.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.pbDeaths.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.pbDeaths.IconChar = FontAwesome.Sharp.IconChar.Skull;
            this.pbDeaths.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.pbDeaths.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pbDeaths.IconSize = 78;
            this.pbDeaths.Location = new System.Drawing.Point(75, 155);
            this.pbDeaths.Name = "pbDeaths";
            this.pbDeaths.Size = new System.Drawing.Size(82, 78);
            this.pbDeaths.TabIndex = 4;
            this.pbDeaths.TabStop = false;
            // 
            // pbComirmed
            // 
            this.pbComirmed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.pbComirmed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(139)))), ((int)(((byte)(47)))));
            this.pbComirmed.IconChar = FontAwesome.Sharp.IconChar.Virus;
            this.pbComirmed.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(139)))), ((int)(((byte)(47)))));
            this.pbComirmed.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pbComirmed.IconSize = 78;
            this.pbComirmed.Location = new System.Drawing.Point(75, 250);
            this.pbComirmed.Name = "pbComirmed";
            this.pbComirmed.Size = new System.Drawing.Size(82, 78);
            this.pbComirmed.TabIndex = 5;
            this.pbComirmed.TabStop = false;
            // 
            // OneDayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(832, 432);
            this.Controls.Add(this.pbComirmed);
            this.Controls.Add(this.pbDeaths);
            this.Controls.Add(this.lblConfirned);
            this.Controls.Add(this.lblDeaths);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OneDayForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OneDayForm";
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbDeaths)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbComirmed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private FontAwesome.Sharp.IconButton btnExit;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblDeaths;
        private System.Windows.Forms.Label lblConfirned;
        private FontAwesome.Sharp.IconPictureBox pbDeaths;
        private FontAwesome.Sharp.IconPictureBox pbComirmed;
    }
}