namespace Covid_Data.Forms.MessageBoxes
{
    partial class LackOfConnectionMessageBox
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
            this.lblInformation = new System.Windows.Forms.Label();
            this.btnOk = new FontAwesome.Sharp.IconButton();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.pbConnectionImge = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbConnectionImge)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInformation
            // 
            this.lblInformation.AutoSize = true;
            this.lblInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblInformation.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblInformation.Location = new System.Drawing.Point(287, 106);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Size = new System.Drawing.Size(303, 32);
            this.lblInformation.TabIndex = 0;
            this.lblInformation.Text = "Check your connection";
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.btnOk.FlatAppearance.BorderSize = 0;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOk.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnOk.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnOk.IconColor = System.Drawing.Color.Black;
            this.btnOk.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnOk.Location = new System.Drawing.Point(293, 172);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(237, 46);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 244);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(780, 42);
            this.panelBottom.TabIndex = 3;
            // 
            // pbConnectionImge
            // 
            this.pbConnectionImge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.pbConnectionImge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.pbConnectionImge.IconChar = FontAwesome.Sharp.IconChar.Wifi;
            this.pbConnectionImge.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.pbConnectionImge.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pbConnectionImge.IconSize = 83;
            this.pbConnectionImge.Location = new System.Drawing.Point(178, 74);
            this.pbConnectionImge.Name = "pbConnectionImge";
            this.pbConnectionImge.Size = new System.Drawing.Size(93, 83);
            this.pbConnectionImge.TabIndex = 4;
            this.pbConnectionImge.TabStop = false;
            // 
            // LackOfConnectionMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(780, 286);
            this.Controls.Add(this.pbConnectionImge);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblInformation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LackOfConnectionMessageBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LackOfConnectionMessageBox";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LackOfConnectionMessageBox_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbConnectionImge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInformation;
        private FontAwesome.Sharp.IconButton btnOk;
        private System.Windows.Forms.Panel panelBottom;
        private FontAwesome.Sharp.IconPictureBox pbConnectionImge;
    }
}