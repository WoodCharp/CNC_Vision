namespace CNCV.Pages
{
    partial class Form_CheckFile
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
            this.cRichTextBox_ok = new CCL.Controls.CRichTextBox();
            this.cLabel1 = new CCL.Controls.CLabel();
            this.cLabel2 = new CCL.Controls.CLabel();
            this.cRichTextBox_NotOk = new CCL.Controls.CRichTextBox();
            this.cButton_Close = new CCL.Controls.CButton();
            this.cPanel1 = new CCL.Controls.CPanel();
            this.cButtonCancel = new CCL.Controls.CButton();
            this.cProgressBar1 = new CCL.Controls.CProgressBar();
            this.cLabel4 = new CCL.Controls.CLabel();
            this.cLabel3 = new CCL.Controls.CLabel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cRichTextBox_ok
            // 
            this.cRichTextBox_ok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.cRichTextBox_ok.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cRichTextBox_ok.Font = new System.Drawing.Font("Armata", 10F);
            this.cRichTextBox_ok.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cRichTextBox_ok.Location = new System.Drawing.Point(12, 61);
            this.cRichTextBox_ok.Name = "cRichTextBox_ok";
            this.cRichTextBox_ok.Size = new System.Drawing.Size(481, 265);
            this.cRichTextBox_ok.TabIndex = 0;
            this.cRichTextBox_ok.Text = "";
            this.cRichTextBox_ok.TextStyle = CCL.eTextStyle.Normal;
            // 
            // cLabel1
            // 
            this.cLabel1.AutoSize = true;
            this.cLabel1.BackColor = System.Drawing.Color.Transparent;
            this.cLabel1.Font = new System.Drawing.Font("Armata", 16F, System.Drawing.FontStyle.Bold);
            this.cLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cLabel1.Location = new System.Drawing.Point(12, 31);
            this.cLabel1.Name = "cLabel1";
            this.cLabel1.OverrideFontSize = 12F;
            this.cLabel1.Size = new System.Drawing.Size(45, 27);
            this.cLabel1.TabIndex = 1;
            this.cLabel1.Text = "OK";
            this.cLabel1.TextStyle = CCL.eTextStyle.Title3;
            this.cLabel1.UseFontSizeOverride = false;
            // 
            // cLabel2
            // 
            this.cLabel2.AutoSize = true;
            this.cLabel2.BackColor = System.Drawing.Color.Transparent;
            this.cLabel2.Font = new System.Drawing.Font("Armata", 16F, System.Drawing.FontStyle.Bold);
            this.cLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cLabel2.Location = new System.Drawing.Point(12, 329);
            this.cLabel2.Name = "cLabel2";
            this.cLabel2.OverrideFontSize = 12F;
            this.cLabel2.Size = new System.Drawing.Size(131, 27);
            this.cLabel2.TabIndex = 3;
            this.cLabel2.Text = "Not so OK";
            this.cLabel2.TextStyle = CCL.eTextStyle.Title3;
            this.cLabel2.UseFontSizeOverride = false;
            // 
            // cRichTextBox_NotOk
            // 
            this.cRichTextBox_NotOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.cRichTextBox_NotOk.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cRichTextBox_NotOk.Font = new System.Drawing.Font("Armata", 10F);
            this.cRichTextBox_NotOk.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cRichTextBox_NotOk.Location = new System.Drawing.Point(12, 359);
            this.cRichTextBox_NotOk.Name = "cRichTextBox_NotOk";
            this.cRichTextBox_NotOk.Size = new System.Drawing.Size(481, 265);
            this.cRichTextBox_NotOk.TabIndex = 2;
            this.cRichTextBox_NotOk.Text = "";
            this.cRichTextBox_NotOk.TextStyle = CCL.eTextStyle.Normal;
            // 
            // cButton_Close
            // 
            this.cButton_Close.DrawBorder = true;
            this.cButton_Close.Font = new System.Drawing.Font("Armata", 10F);
            this.cButton_Close.Location = new System.Drawing.Point(393, 630);
            this.cButton_Close.Name = "cButton_Close";
            this.cButton_Close.Size = new System.Drawing.Size(100, 35);
            this.cButton_Close.TabIndex = 4;
            this.cButton_Close.Text = "Close";
            this.cButton_Close.TextStyle = CCL.eTextStyle.Normal;
            this.cButton_Close.UseVisualStyleBackColor = true;
            this.cButton_Close.Click += new System.EventHandler(this.cButton_Close_Click);
            // 
            // cPanel1
            // 
            this.cPanel1.Controls.Add(this.cButtonCancel);
            this.cPanel1.Controls.Add(this.cProgressBar1);
            this.cPanel1.Controls.Add(this.cLabel4);
            this.cPanel1.Controls.Add(this.cLabel3);
            this.cPanel1.DrawBorder = true;
            this.cPanel1.Location = new System.Drawing.Point(8, 31);
            this.cPanel1.Name = "cPanel1";
            this.cPanel1.Size = new System.Drawing.Size(488, 638);
            this.cPanel1.TabIndex = 5;
            // 
            // cButtonCancel
            // 
            this.cButtonCancel.DrawBorder = true;
            this.cButtonCancel.Font = new System.Drawing.Font("Armata", 20F, System.Drawing.FontStyle.Bold);
            this.cButtonCancel.Location = new System.Drawing.Point(125, 301);
            this.cButtonCancel.Name = "cButtonCancel";
            this.cButtonCancel.Size = new System.Drawing.Size(238, 70);
            this.cButtonCancel.TabIndex = 5;
            this.cButtonCancel.Text = "CANCEL";
            this.cButtonCancel.TextStyle = CCL.eTextStyle.Title1;
            this.cButtonCancel.UseVisualStyleBackColor = true;
            this.cButtonCancel.Click += new System.EventHandler(this.cButtonCancel_Click);
            // 
            // cProgressBar1
            // 
            this.cProgressBar1.Location = new System.Drawing.Point(46, 494);
            this.cProgressBar1.Name = "cProgressBar1";
            this.cProgressBar1.ProgressBarHeight = 25;
            this.cProgressBar1.Size = new System.Drawing.Size(397, 25);
            this.cProgressBar1.TabIndex = 0;
            // 
            // cLabel4
            // 
            this.cLabel4.BackColor = System.Drawing.Color.Transparent;
            this.cLabel4.Font = new System.Drawing.Font("Armata", 50F);
            this.cLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cLabel4.Location = new System.Drawing.Point(82, 134);
            this.cLabel4.Name = "cLabel4";
            this.cLabel4.OverrideFontSize = 50F;
            this.cLabel4.Size = new System.Drawing.Size(334, 125);
            this.cLabel4.TabIndex = 1;
            this.cLabel4.Text = "0 %";
            this.cLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cLabel4.TextStyle = CCL.eTextStyle.Normal;
            this.cLabel4.UseFontSizeOverride = true;
            // 
            // cLabel3
            // 
            this.cLabel3.AutoSize = true;
            this.cLabel3.BackColor = System.Drawing.Color.Transparent;
            this.cLabel3.Font = new System.Drawing.Font("Armata", 30F);
            this.cLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cLabel3.Location = new System.Drawing.Point(73, 75);
            this.cLabel3.Name = "cLabel3";
            this.cLabel3.OverrideFontSize = 30F;
            this.cLabel3.Size = new System.Drawing.Size(343, 50);
            this.cLabel3.TabIndex = 0;
            this.cLabel3.Text = "LOADING DATA...";
            this.cLabel3.TextStyle = CCL.eTextStyle.Normal;
            this.cLabel3.UseFontSizeOverride = true;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // Form_CheckFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 681);
            this.Controls.Add(this.cPanel1);
            this.Controls.Add(this.cButton_Close);
            this.Controls.Add(this.cLabel2);
            this.Controls.Add(this.cRichTextBox_NotOk);
            this.Controls.Add(this.cLabel1);
            this.Controls.Add(this.cRichTextBox_ok);
            this.Name = "Form_CheckFile";
            this.Text = "File Check";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_CheckFile_FormClosing);
            this.Load += new System.EventHandler(this.Form_CheckFile_Load);
            this.cPanel1.ResumeLayout(false);
            this.cPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCL.Controls.CRichTextBox cRichTextBox_ok;
        private CCL.Controls.CLabel cLabel1;
        private CCL.Controls.CLabel cLabel2;
        private CCL.Controls.CRichTextBox cRichTextBox_NotOk;
        private CCL.Controls.CButton cButton_Close;
        private CCL.Controls.CPanel cPanel1;
        private CCL.Controls.CProgressBar cProgressBar1;
        private CCL.Controls.CLabel cLabel3;
        private CCL.Controls.CLabel cLabel4;
        private CCL.Controls.CButton cButtonCancel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}