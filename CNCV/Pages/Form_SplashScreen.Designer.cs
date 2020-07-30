namespace CNCV.Pages
{
    partial class Form_SplashScreen
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
            this.cLabel_Version = new CCL.Controls.CLabel();
            this.cLabel1 = new CCL.Controls.CLabel();
            this.cLabel2 = new CCL.Controls.CLabel();
            this.cLabel4 = new CCL.Controls.CLabel();
            this.SuspendLayout();
            // 
            // cLabel_Version
            // 
            this.cLabel_Version.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cLabel_Version.AutoSize = true;
            this.cLabel_Version.BackColor = System.Drawing.Color.Transparent;
            this.cLabel_Version.Font = new System.Drawing.Font("Armata", 8F);
            this.cLabel_Version.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cLabel_Version.Location = new System.Drawing.Point(12, 257);
            this.cLabel_Version.Name = "cLabel_Version";
            this.cLabel_Version.Size = new System.Drawing.Size(29, 14);
            this.cLabel_Version.TabIndex = 1;
            this.cLabel_Version.Text = "v0.1";
            this.cLabel_Version.TextStyle = CCL.eTextStyle.Small;
            // 
            // cLabel1
            // 
            this.cLabel1.AutoSize = true;
            this.cLabel1.BackColor = System.Drawing.Color.Transparent;
            this.cLabel1.Font = new System.Drawing.Font("Armata", 16F, System.Drawing.FontStyle.Bold);
            this.cLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cLabel1.Location = new System.Drawing.Point(117, 160);
            this.cLabel1.Name = "cLabel1";
            this.cLabel1.Size = new System.Drawing.Size(356, 27);
            this.cLabel1.TabIndex = 3;
            this.cLabel1.Text = "CNC CONTROLLING SOFTWARE";
            this.cLabel1.TextStyle = CCL.eTextStyle.Title3;
            // 
            // cLabel2
            // 
            this.cLabel2.AutoSize = true;
            this.cLabel2.BackColor = System.Drawing.Color.Transparent;
            this.cLabel2.Font = new System.Drawing.Font("Armata", 10F);
            this.cLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cLabel2.Location = new System.Drawing.Point(221, 187);
            this.cLabel2.Name = "cLabel2";
            this.cLabel2.Size = new System.Drawing.Size(148, 18);
            this.cLabel2.TabIndex = 4;
            this.cLabel2.Text = "FOR GRBL MACHINES";
            this.cLabel2.TextStyle = CCL.eTextStyle.Normal;
            // 
            // cLabel4
            // 
            this.cLabel4.AutoSize = true;
            this.cLabel4.BackColor = System.Drawing.Color.Transparent;
            this.cLabel4.Font = new System.Drawing.Font("Armata", 20F, System.Drawing.FontStyle.Bold);
            this.cLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cLabel4.Location = new System.Drawing.Point(207, 57);
            this.cLabel4.Name = "cLabel4";
            this.cLabel4.Size = new System.Drawing.Size(176, 33);
            this.cLabel4.TabIndex = 7;
            this.cLabel4.Text = "CNC VISION";
            this.cLabel4.TextStyle = CCL.eTextStyle.Title1;
            // 
            // Form_SplahsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 280);
            this.ControlBox = false;
            this.Controls.Add(this.cLabel4);
            this.Controls.Add(this.cLabel2);
            this.Controls.Add(this.cLabel1);
            this.Controls.Add(this.cLabel_Version);
            this.Name = "Form_SplahsScreen";
            this.Sizable = false;
            this.TransparentTitleBar = true;
            this.Load += new System.EventHandler(this.Form_SplahsScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CCL.Controls.CLabel cLabel_Version;
        private CCL.Controls.CLabel cLabel1;
        private CCL.Controls.CLabel cLabel2;
        private CCL.Controls.CLabel cLabel4;
    }
}