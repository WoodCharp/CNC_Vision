namespace CNCV.Pages
{
    partial class Form_ToolChangeWindow
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
            this.cRadioButton_g1 = new CCL.Controls.CRadioButton();
            this.cRadioButton_g0 = new CCL.Controls.CRadioButton();
            this.cLabel6 = new CCL.Controls.CLabel();
            this.cLabel5 = new CCL.Controls.CLabel();
            this.cTextBox_feedRate = new CCL.Controls.CTextBox();
            this.cTextBox_distance = new CCL.Controls.CTextBox();
            this.cButton_XmYp = new CCL.Controls.CButton();
            this.cButton_Zm = new CCL.Controls.CButton();
            this.cButton_Ym = new CCL.Controls.CButton();
            this.cButton_XpYm = new CCL.Controls.CButton();
            this.cButton_Zp = new CCL.Controls.CButton();
            this.cButton_XmYm = new CCL.Controls.CButton();
            this.cButton_XpYp = new CCL.Controls.CButton();
            this.cButton_Xp = new CCL.Controls.CButton();
            this.cButton_Yp = new CCL.Controls.CButton();
            this.cButton_Xm = new CCL.Controls.CButton();
            this.cButton_touchThePlate = new CCL.Controls.CButton();
            this.cLabelName = new CCL.Controls.CLabel();
            this.cLabelID = new CCL.Controls.CLabel();
            this.cLabelCD = new CCL.Controls.CLabel();
            this.cLabelSD = new CCL.Controls.CLabel();
            this.cButtonToolChanged = new CCL.Controls.CButton();
            this.SuspendLayout();
            // 
            // cRadioButton_g1
            // 
            this.cRadioButton_g1.BackColor = System.Drawing.Color.Transparent;
            this.cRadioButton_g1.CheckMarkSize = 10;
            this.cRadioButton_g1.Font = new System.Drawing.Font("Armata", 10F);
            this.cRadioButton_g1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cRadioButton_g1.Location = new System.Drawing.Point(223, 468);
            this.cRadioButton_g1.Name = "cRadioButton_g1";
            this.cRadioButton_g1.RadioButtonHeight = 18;
            this.cRadioButton_g1.Size = new System.Drawing.Size(42, 18);
            this.cRadioButton_g1.TabIndex = 57;
            this.cRadioButton_g1.Text = "G1";
            this.cRadioButton_g1.TextStyle = CCL.eTextStyle.Normal;
            this.cRadioButton_g1.UseVisualStyleBackColor = false;
            // 
            // cRadioButton_g0
            // 
            this.cRadioButton_g0.BackColor = System.Drawing.Color.Transparent;
            this.cRadioButton_g0.Checked = true;
            this.cRadioButton_g0.CheckMarkSize = 10;
            this.cRadioButton_g0.Font = new System.Drawing.Font("Armata", 10F);
            this.cRadioButton_g0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cRadioButton_g0.Location = new System.Drawing.Point(223, 444);
            this.cRadioButton_g0.Name = "cRadioButton_g0";
            this.cRadioButton_g0.RadioButtonHeight = 18;
            this.cRadioButton_g0.Size = new System.Drawing.Size(46, 18);
            this.cRadioButton_g0.TabIndex = 56;
            this.cRadioButton_g0.TabStop = true;
            this.cRadioButton_g0.Text = "G0";
            this.cRadioButton_g0.TextStyle = CCL.eTextStyle.Normal;
            this.cRadioButton_g0.UseVisualStyleBackColor = false;
            // 
            // cLabel6
            // 
            this.cLabel6.AutoSize = true;
            this.cLabel6.BackColor = System.Drawing.Color.Transparent;
            this.cLabel6.Font = new System.Drawing.Font("Armata", 10F);
            this.cLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cLabel6.Location = new System.Drawing.Point(17, 441);
            this.cLabel6.Name = "cLabel6";
            this.cLabel6.OverrideFontSize = 12F;
            this.cLabel6.Size = new System.Drawing.Size(72, 18);
            this.cLabel6.TabIndex = 55;
            this.cLabel6.Text = "Distance";
            this.cLabel6.TextStyle = CCL.eTextStyle.Normal;
            this.cLabel6.UseFontSizeOverride = false;
            // 
            // cLabel5
            // 
            this.cLabel5.AutoSize = true;
            this.cLabel5.BackColor = System.Drawing.Color.Transparent;
            this.cLabel5.Font = new System.Drawing.Font("Armata", 10F);
            this.cLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cLabel5.Location = new System.Drawing.Point(17, 465);
            this.cLabel5.Name = "cLabel5";
            this.cLabel5.OverrideFontSize = 12F;
            this.cLabel5.Size = new System.Drawing.Size(76, 18);
            this.cLabel5.TabIndex = 54;
            this.cLabel5.Text = "Feed rate";
            this.cLabel5.TextStyle = CCL.eTextStyle.Normal;
            this.cLabel5.UseFontSizeOverride = false;
            // 
            // cTextBox_feedRate
            // 
            this.cTextBox_feedRate.Depth = 0;
            this.cTextBox_feedRate.Font = new System.Drawing.Font("Armata", 10F);
            this.cTextBox_feedRate.Hint = "";
            this.cTextBox_feedRate.LineHeight = 1;
            this.cTextBox_feedRate.Location = new System.Drawing.Point(95, 465);
            this.cTextBox_feedRate.MaxLength = 32767;
            this.cTextBox_feedRate.MouseState = CCL.MouseState.HOVER;
            this.cTextBox_feedRate.Name = "cTextBox_feedRate";
            this.cTextBox_feedRate.PasswordChar = '\0';
            this.cTextBox_feedRate.SelectedText = "";
            this.cTextBox_feedRate.SelectionLength = 0;
            this.cTextBox_feedRate.SelectionStart = 0;
            this.cTextBox_feedRate.Size = new System.Drawing.Size(122, 18);
            this.cTextBox_feedRate.TabIndex = 53;
            this.cTextBox_feedRate.TabStop = false;
            this.cTextBox_feedRate.Text = "500";
            this.cTextBox_feedRate.TextStyle = CCL.eTextStyle.Normal;
            this.cTextBox_feedRate.UseSystemPasswordChar = false;
            // 
            // cTextBox_distance
            // 
            this.cTextBox_distance.Depth = 0;
            this.cTextBox_distance.Font = new System.Drawing.Font("Armata", 10F);
            this.cTextBox_distance.Hint = "";
            this.cTextBox_distance.LineHeight = 1;
            this.cTextBox_distance.Location = new System.Drawing.Point(95, 441);
            this.cTextBox_distance.MaxLength = 32767;
            this.cTextBox_distance.MouseState = CCL.MouseState.HOVER;
            this.cTextBox_distance.Name = "cTextBox_distance";
            this.cTextBox_distance.PasswordChar = '\0';
            this.cTextBox_distance.SelectedText = "";
            this.cTextBox_distance.SelectionLength = 0;
            this.cTextBox_distance.SelectionStart = 0;
            this.cTextBox_distance.Size = new System.Drawing.Size(122, 18);
            this.cTextBox_distance.TabIndex = 52;
            this.cTextBox_distance.TabStop = false;
            this.cTextBox_distance.Text = "10";
            this.cTextBox_distance.TextStyle = CCL.eTextStyle.Normal;
            this.cTextBox_distance.UseSystemPasswordChar = false;
            // 
            // cButton_XmYp
            // 
            this.cButton_XmYp.BackgroundImage = global::CNCV.Properties.Resources.ArrowUpLeft;
            this.cButton_XmYp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cButton_XmYp.DrawBorder = false;
            this.cButton_XmYp.Font = new System.Drawing.Font("Armata", 12F, System.Drawing.FontStyle.Bold);
            this.cButton_XmYp.Location = new System.Drawing.Point(20, 247);
            this.cButton_XmYp.Name = "cButton_XmYp";
            this.cButton_XmYp.Size = new System.Drawing.Size(55, 55);
            this.cButton_XmYp.TabIndex = 46;
            this.cButton_XmYp.TextStyle = CCL.eTextStyle.Title5;
            this.cButton_XmYp.UseVisualStyleBackColor = true;
            this.cButton_XmYp.Click += new System.EventHandler(this.cButton_XmYp_Click);
            // 
            // cButton_Zm
            // 
            this.cButton_Zm.BackgroundImage = global::CNCV.Properties.Resources.ArrowDown;
            this.cButton_Zm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cButton_Zm.DrawBorder = false;
            this.cButton_Zm.Font = new System.Drawing.Font("Armata", 12F, System.Drawing.FontStyle.Bold);
            this.cButton_Zm.Location = new System.Drawing.Point(224, 369);
            this.cButton_Zm.Name = "cButton_Zm";
            this.cButton_Zm.Size = new System.Drawing.Size(55, 55);
            this.cButton_Zm.TabIndex = 51;
            this.cButton_Zm.TextStyle = CCL.eTextStyle.Title5;
            this.cButton_Zm.UseVisualStyleBackColor = true;
            this.cButton_Zm.Click += new System.EventHandler(this.cButton_Zm_Click);
            // 
            // cButton_Ym
            // 
            this.cButton_Ym.BackgroundImage = global::CNCV.Properties.Resources.ArrowDown;
            this.cButton_Ym.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cButton_Ym.DrawBorder = false;
            this.cButton_Ym.Font = new System.Drawing.Font("Armata", 12F, System.Drawing.FontStyle.Bold);
            this.cButton_Ym.Location = new System.Drawing.Point(81, 370);
            this.cButton_Ym.Name = "cButton_Ym";
            this.cButton_Ym.Size = new System.Drawing.Size(55, 55);
            this.cButton_Ym.TabIndex = 40;
            this.cButton_Ym.TextStyle = CCL.eTextStyle.Title5;
            this.cButton_Ym.UseVisualStyleBackColor = true;
            this.cButton_Ym.Click += new System.EventHandler(this.cButton_Ym_Click);
            // 
            // cButton_XpYm
            // 
            this.cButton_XpYm.BackgroundImage = global::CNCV.Properties.Resources.ArrowDownRight;
            this.cButton_XpYm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cButton_XpYm.DrawBorder = false;
            this.cButton_XpYm.Font = new System.Drawing.Font("Armata", 12F, System.Drawing.FontStyle.Bold);
            this.cButton_XpYm.Location = new System.Drawing.Point(142, 370);
            this.cButton_XpYm.Name = "cButton_XpYm";
            this.cButton_XpYm.Size = new System.Drawing.Size(55, 55);
            this.cButton_XpYm.TabIndex = 41;
            this.cButton_XpYm.TextStyle = CCL.eTextStyle.Title5;
            this.cButton_XpYm.UseVisualStyleBackColor = true;
            this.cButton_XpYm.Click += new System.EventHandler(this.cButton_XpYm_Click);
            // 
            // cButton_Zp
            // 
            this.cButton_Zp.BackgroundImage = global::CNCV.Properties.Resources.ArrowUp;
            this.cButton_Zp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cButton_Zp.DrawBorder = false;
            this.cButton_Zp.Font = new System.Drawing.Font("Armata", 12F, System.Drawing.FontStyle.Bold);
            this.cButton_Zp.Location = new System.Drawing.Point(224, 247);
            this.cButton_Zp.Name = "cButton_Zp";
            this.cButton_Zp.Size = new System.Drawing.Size(55, 55);
            this.cButton_Zp.TabIndex = 49;
            this.cButton_Zp.TextStyle = CCL.eTextStyle.Title5;
            this.cButton_Zp.UseVisualStyleBackColor = true;
            this.cButton_Zp.Click += new System.EventHandler(this.cButton_Zp_Click);
            // 
            // cButton_XmYm
            // 
            this.cButton_XmYm.BackgroundImage = global::CNCV.Properties.Resources.ArrowDownLeft;
            this.cButton_XmYm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cButton_XmYm.DrawBorder = false;
            this.cButton_XmYm.Font = new System.Drawing.Font("Armata", 12F, System.Drawing.FontStyle.Bold);
            this.cButton_XmYm.Location = new System.Drawing.Point(20, 370);
            this.cButton_XmYm.Name = "cButton_XmYm";
            this.cButton_XmYm.Size = new System.Drawing.Size(55, 55);
            this.cButton_XmYm.TabIndex = 42;
            this.cButton_XmYm.TextStyle = CCL.eTextStyle.Title5;
            this.cButton_XmYm.UseVisualStyleBackColor = true;
            this.cButton_XmYm.Click += new System.EventHandler(this.cButton_XmYm_Click);
            // 
            // cButton_XpYp
            // 
            this.cButton_XpYp.BackgroundImage = global::CNCV.Properties.Resources.ArrowUpRight;
            this.cButton_XpYp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cButton_XpYp.DrawBorder = false;
            this.cButton_XpYp.Font = new System.Drawing.Font("Armata", 12F, System.Drawing.FontStyle.Bold);
            this.cButton_XpYp.Location = new System.Drawing.Point(142, 247);
            this.cButton_XpYp.Name = "cButton_XpYp";
            this.cButton_XpYp.Size = new System.Drawing.Size(55, 55);
            this.cButton_XpYp.TabIndex = 48;
            this.cButton_XpYp.TextStyle = CCL.eTextStyle.Title5;
            this.cButton_XpYp.UseVisualStyleBackColor = true;
            this.cButton_XpYp.Click += new System.EventHandler(this.cButton_XpYp_Click);
            // 
            // cButton_Xp
            // 
            this.cButton_Xp.BackgroundImage = global::CNCV.Properties.Resources.ArrowRight;
            this.cButton_Xp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cButton_Xp.DrawBorder = false;
            this.cButton_Xp.Font = new System.Drawing.Font("Armata", 12F, System.Drawing.FontStyle.Bold);
            this.cButton_Xp.Location = new System.Drawing.Point(142, 308);
            this.cButton_Xp.Name = "cButton_Xp";
            this.cButton_Xp.Size = new System.Drawing.Size(55, 55);
            this.cButton_Xp.TabIndex = 43;
            this.cButton_Xp.TextStyle = CCL.eTextStyle.Title5;
            this.cButton_Xp.UseVisualStyleBackColor = true;
            this.cButton_Xp.Click += new System.EventHandler(this.cButton_Xp_Click);
            // 
            // cButton_Yp
            // 
            this.cButton_Yp.BackgroundImage = global::CNCV.Properties.Resources.ArrowUp;
            this.cButton_Yp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cButton_Yp.DrawBorder = false;
            this.cButton_Yp.Font = new System.Drawing.Font("Armata", 12F, System.Drawing.FontStyle.Bold);
            this.cButton_Yp.Location = new System.Drawing.Point(81, 247);
            this.cButton_Yp.Name = "cButton_Yp";
            this.cButton_Yp.Size = new System.Drawing.Size(55, 55);
            this.cButton_Yp.TabIndex = 47;
            this.cButton_Yp.TextStyle = CCL.eTextStyle.Title5;
            this.cButton_Yp.UseVisualStyleBackColor = true;
            this.cButton_Yp.Click += new System.EventHandler(this.cButton_Yp_Click);
            // 
            // cButton_Xm
            // 
            this.cButton_Xm.BackgroundImage = global::CNCV.Properties.Resources.ArrowLeft;
            this.cButton_Xm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cButton_Xm.DrawBorder = false;
            this.cButton_Xm.Font = new System.Drawing.Font("Armata", 12F, System.Drawing.FontStyle.Bold);
            this.cButton_Xm.Location = new System.Drawing.Point(20, 308);
            this.cButton_Xm.Name = "cButton_Xm";
            this.cButton_Xm.Size = new System.Drawing.Size(55, 55);
            this.cButton_Xm.TabIndex = 45;
            this.cButton_Xm.TextStyle = CCL.eTextStyle.Title5;
            this.cButton_Xm.UseVisualStyleBackColor = true;
            this.cButton_Xm.Click += new System.EventHandler(this.cButton_Xm_Click);
            // 
            // cButton_touchThePlate
            // 
            this.cButton_touchThePlate.DrawBorder = true;
            this.cButton_touchThePlate.Font = new System.Drawing.Font("Armata", 12F, System.Drawing.FontStyle.Bold);
            this.cButton_touchThePlate.Location = new System.Drawing.Point(78, 506);
            this.cButton_touchThePlate.Name = "cButton_touchThePlate";
            this.cButton_touchThePlate.Size = new System.Drawing.Size(140, 47);
            this.cButton_touchThePlate.TabIndex = 58;
            this.cButton_touchThePlate.Text = "Touch the plate";
            this.cButton_touchThePlate.TextStyle = CCL.eTextStyle.Title5;
            this.cButton_touchThePlate.UseVisualStyleBackColor = true;
            // 
            // cLabelName
            // 
            this.cLabelName.BackColor = System.Drawing.Color.Transparent;
            this.cLabelName.Font = new System.Drawing.Font("Armata", 25F);
            this.cLabelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cLabelName.Location = new System.Drawing.Point(12, 31);
            this.cLabelName.Name = "cLabelName";
            this.cLabelName.OverrideFontSize = 25F;
            this.cLabelName.Size = new System.Drawing.Size(272, 60);
            this.cLabelName.TabIndex = 59;
            this.cLabelName.Text = "Name";
            this.cLabelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cLabelName.TextStyle = CCL.eTextStyle.Normal;
            this.cLabelName.UseFontSizeOverride = true;
            // 
            // cLabelID
            // 
            this.cLabelID.AutoSize = true;
            this.cLabelID.BackColor = System.Drawing.Color.Transparent;
            this.cLabelID.Font = new System.Drawing.Font("Armata", 25F);
            this.cLabelID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cLabelID.Location = new System.Drawing.Point(12, 91);
            this.cLabelID.Name = "cLabelID";
            this.cLabelID.OverrideFontSize = 25F;
            this.cLabelID.Size = new System.Drawing.Size(91, 42);
            this.cLabelID.TabIndex = 60;
            this.cLabelID.Text = "ID: *";
            this.cLabelID.TextStyle = CCL.eTextStyle.Normal;
            this.cLabelID.UseFontSizeOverride = true;
            // 
            // cLabelCD
            // 
            this.cLabelCD.AutoSize = true;
            this.cLabelCD.BackColor = System.Drawing.Color.Transparent;
            this.cLabelCD.Font = new System.Drawing.Font("Armata", 25F);
            this.cLabelCD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cLabelCD.Location = new System.Drawing.Point(12, 133);
            this.cLabelCD.Name = "cLabelCD";
            this.cLabelCD.OverrideFontSize = 25F;
            this.cLabelCD.Size = new System.Drawing.Size(100, 42);
            this.cLabelCD.TabIndex = 61;
            this.cLabelCD.Text = "CD: *";
            this.cLabelCD.TextStyle = CCL.eTextStyle.Normal;
            this.cLabelCD.UseFontSizeOverride = true;
            // 
            // cLabelSD
            // 
            this.cLabelSD.AutoSize = true;
            this.cLabelSD.BackColor = System.Drawing.Color.Transparent;
            this.cLabelSD.Font = new System.Drawing.Font("Armata", 25F);
            this.cLabelSD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cLabelSD.Location = new System.Drawing.Point(12, 175);
            this.cLabelSD.Name = "cLabelSD";
            this.cLabelSD.OverrideFontSize = 25F;
            this.cLabelSD.Size = new System.Drawing.Size(100, 42);
            this.cLabelSD.TabIndex = 62;
            this.cLabelSD.Text = "SD: *";
            this.cLabelSD.TextStyle = CCL.eTextStyle.Normal;
            this.cLabelSD.UseFontSizeOverride = true;
            // 
            // cButtonToolChanged
            // 
            this.cButtonToolChanged.DrawBorder = true;
            this.cButtonToolChanged.Font = new System.Drawing.Font("Armata", 12F, System.Drawing.FontStyle.Bold);
            this.cButtonToolChanged.Location = new System.Drawing.Point(12, 589);
            this.cButtonToolChanged.Name = "cButtonToolChanged";
            this.cButtonToolChanged.Size = new System.Drawing.Size(272, 47);
            this.cButtonToolChanged.TabIndex = 63;
            this.cButtonToolChanged.Text = "Tool Changed";
            this.cButtonToolChanged.TextStyle = CCL.eTextStyle.Title5;
            this.cButtonToolChanged.UseVisualStyleBackColor = true;
            this.cButtonToolChanged.Click += new System.EventHandler(this.cButtonToolChanged_Click);
            // 
            // Form_ToolChangeWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 648);
            this.Controls.Add(this.cButtonToolChanged);
            this.Controls.Add(this.cLabelSD);
            this.Controls.Add(this.cLabelCD);
            this.Controls.Add(this.cLabelID);
            this.Controls.Add(this.cLabelName);
            this.Controls.Add(this.cButton_touchThePlate);
            this.Controls.Add(this.cRadioButton_g1);
            this.Controls.Add(this.cRadioButton_g0);
            this.Controls.Add(this.cButton_XmYp);
            this.Controls.Add(this.cLabel6);
            this.Controls.Add(this.cButton_Xm);
            this.Controls.Add(this.cLabel5);
            this.Controls.Add(this.cTextBox_feedRate);
            this.Controls.Add(this.cButton_Yp);
            this.Controls.Add(this.cTextBox_distance);
            this.Controls.Add(this.cButton_Xp);
            this.Controls.Add(this.cButton_XpYp);
            this.Controls.Add(this.cButton_Zm);
            this.Controls.Add(this.cButton_XmYm);
            this.Controls.Add(this.cButton_Ym);
            this.Controls.Add(this.cButton_Zp);
            this.Controls.Add(this.cButton_XpYm);
            this.Name = "Form_ToolChangeWindow";
            this.Sizable = false;
            this.Text = "Tool Change";
            this.Load += new System.EventHandler(this.Form_ToolChangeWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCL.Controls.CRadioButton cRadioButton_g1;
        private CCL.Controls.CRadioButton cRadioButton_g0;
        private CCL.Controls.CLabel cLabel6;
        private CCL.Controls.CLabel cLabel5;
        private CCL.Controls.CTextBox cTextBox_feedRate;
        private CCL.Controls.CTextBox cTextBox_distance;
        private CCL.Controls.CButton cButton_XmYp;
        private CCL.Controls.CButton cButton_Zm;
        private CCL.Controls.CButton cButton_Ym;
        private CCL.Controls.CButton cButton_XpYm;
        private CCL.Controls.CButton cButton_Zp;
        private CCL.Controls.CButton cButton_XmYm;
        private CCL.Controls.CButton cButton_XpYp;
        private CCL.Controls.CButton cButton_Xp;
        private CCL.Controls.CButton cButton_Yp;
        private CCL.Controls.CButton cButton_Xm;
        private CCL.Controls.CButton cButton_touchThePlate;
        private CCL.Controls.CLabel cLabelName;
        private CCL.Controls.CLabel cLabelID;
        private CCL.Controls.CLabel cLabelCD;
        private CCL.Controls.CLabel cLabelSD;
        private CCL.Controls.CButton cButtonToolChanged;
    }
}