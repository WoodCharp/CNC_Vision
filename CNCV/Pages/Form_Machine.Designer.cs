﻿namespace CNCV.Pages
{
    partial class Form_Machine
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
            this.cListView_grblSettings = new CCL.Controls.CListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cButton_cancel = new CCL.Controls.CButton();
            this.cButton_ok = new CCL.Controls.CButton();
            this.cTextBox_name = new CCL.Controls.CTextBox();
            this.cDropDown_type = new CCL.Controls.CDropDown();
            this.cGroupBox3 = new CCL.Controls.CGroupBox();
            this.cButton_refreshSerialPorts = new CCL.Controls.CButton();
            this.cLabel_opt = new CCL.Controls.CLabel();
            this.cLabel_version = new CCL.Controls.CLabel();
            this.cLabel_machineStatus = new CCL.Controls.CLabel();
            this.cButton_getSettings = new CCL.Controls.CButton();
            this.cButton_reset = new CCL.Controls.CButton();
            this.cButton_unlock = new CCL.Controls.CButton();
            this.cButton_disconnect = new CCL.Controls.CButton();
            this.cTextBox_baudRate = new CCL.Controls.CTextBox();
            this.cLabel2 = new CCL.Controls.CLabel();
            this.cLabel1 = new CCL.Controls.CLabel();
            this.cDropDown_serialPorts = new CCL.Controls.CDropDown();
            this.cButton_connect = new CCL.Controls.CButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cTextBox_toolChangeTime = new CCL.Controls.CTextBox();
            this.cLabel3 = new CCL.Controls.CLabel();
            this.cTextBox_touchPlateHeight = new CCL.Controls.CTextBox();
            this.cLabel4 = new CCL.Controls.CLabel();
            this.cButton_sendSettings = new CCL.Controls.CButton();
            this.cGroupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cListView_grblSettings
            // 
            this.cListView_grblSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cListView_grblSettings.ColumnHeaderTextStyle = CCL.eTextStyle.Normal;
            this.cListView_grblSettings.ColumnHeight = 24;
            this.cListView_grblSettings.Columns.Add(this.columnHeader1);
            this.cListView_grblSettings.Columns.Add(this.columnHeader2);
            this.cListView_grblSettings.Columns.Add(this.columnHeader3);
            this.cListView_grblSettings.ContentTextStyle = CCL.eTextStyle.Normal;
            this.cListView_grblSettings.DrawBorder = false;
            this.cListView_grblSettings.EnableItemEdit = true;
            this.cListView_grblSettings.HorizontalLines = true;
            this.cListView_grblSettings.ItemHeight = 24;
            this.cListView_grblSettings.ItemHoverEffect = true;
            this.cListView_grblSettings.Location = new System.Drawing.Point(263, 30);
            this.cListView_grblSettings.MinColumnWidth = 20;
            this.cListView_grblSettings.Name = "cListView_grblSettings";
            this.cListView_grblSettings.NonEditableColumns.Add("0");
            this.cListView_grblSettings.NonEditableColumns.Add("2");
            this.cListView_grblSettings.Size = new System.Drawing.Size(298, 430);
            this.cListView_grblSettings.TabIndex = 0;
            this.cListView_grblSettings.Text = "cListView1";
            this.cListView_grblSettings.TitleText = "GRBL Settings";
            this.cListView_grblSettings.TitleTextStyle = CCL.eTextStyle.Title3;
            this.cListView_grblSettings.VerticalLines = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 40;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Value";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Setting";
            this.columnHeader3.Width = 120;
            // 
            // cButton_cancel
            // 
            this.cButton_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cButton_cancel.DrawBorder = true;
            this.cButton_cancel.Font = new System.Drawing.Font("Armata", 10F);
            this.cButton_cancel.Location = new System.Drawing.Point(157, 493);
            this.cButton_cancel.Name = "cButton_cancel";
            this.cButton_cancel.Size = new System.Drawing.Size(100, 35);
            this.cButton_cancel.TabIndex = 9;
            this.cButton_cancel.Text = "Cancel";
            this.cButton_cancel.TextStyle = CCL.eTextStyle.Normal;
            this.cButton_cancel.UseVisualStyleBackColor = true;
            this.cButton_cancel.Click += new System.EventHandler(this.cButton_cancel_Click);
            // 
            // cButton_ok
            // 
            this.cButton_ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cButton_ok.DrawBorder = true;
            this.cButton_ok.Font = new System.Drawing.Font("Armata", 10F);
            this.cButton_ok.Location = new System.Drawing.Point(12, 493);
            this.cButton_ok.Name = "cButton_ok";
            this.cButton_ok.Size = new System.Drawing.Size(100, 35);
            this.cButton_ok.TabIndex = 8;
            this.cButton_ok.Text = "OK";
            this.cButton_ok.TextStyle = CCL.eTextStyle.Normal;
            this.cButton_ok.UseVisualStyleBackColor = true;
            this.cButton_ok.Click += new System.EventHandler(this.cButton_ok_Click);
            // 
            // cTextBox_name
            // 
            this.cTextBox_name.Depth = 0;
            this.cTextBox_name.Font = new System.Drawing.Font("Armata", 10F);
            this.cTextBox_name.Hint = "";
            this.cTextBox_name.LineHeight = 1;
            this.cTextBox_name.Location = new System.Drawing.Point(12, 30);
            this.cTextBox_name.MaxLength = 32767;
            this.cTextBox_name.MouseState = CCL.MouseState.HOVER;
            this.cTextBox_name.Name = "cTextBox_name";
            this.cTextBox_name.PasswordChar = '\0';
            this.cTextBox_name.SelectedText = "";
            this.cTextBox_name.SelectionLength = 0;
            this.cTextBox_name.SelectionStart = 0;
            this.cTextBox_name.Size = new System.Drawing.Size(245, 18);
            this.cTextBox_name.TabIndex = 0;
            this.cTextBox_name.TabStop = false;
            this.cTextBox_name.TextStyle = CCL.eTextStyle.Normal;
            this.cTextBox_name.UseSystemPasswordChar = false;
            // 
            // cDropDown_type
            // 
            this.cDropDown_type.Font = new System.Drawing.Font("Armata", 10F);
            this.cDropDown_type.Items.Add("Router");
            this.cDropDown_type.Items.Add("Laser");
            this.cDropDown_type.Location = new System.Drawing.Point(12, 54);
            this.cDropDown_type.Name = "cDropDown_type";
            this.cDropDown_type.SelectedIndex = -1;
            this.cDropDown_type.Size = new System.Drawing.Size(245, 25);
            this.cDropDown_type.TabIndex = 0;
            this.cDropDown_type.Text = "cDropDown1";
            this.cDropDown_type.TextStyle = CCL.eTextStyle.Normal;
            // 
            // cGroupBox3
            // 
            this.cGroupBox3.Controls.Add(this.cButton_sendSettings);
            this.cGroupBox3.Controls.Add(this.cButton_refreshSerialPorts);
            this.cGroupBox3.Controls.Add(this.cLabel_opt);
            this.cGroupBox3.Controls.Add(this.cLabel_version);
            this.cGroupBox3.Controls.Add(this.cLabel_machineStatus);
            this.cGroupBox3.Controls.Add(this.cButton_getSettings);
            this.cGroupBox3.Controls.Add(this.cButton_reset);
            this.cGroupBox3.Controls.Add(this.cButton_unlock);
            this.cGroupBox3.Controls.Add(this.cButton_disconnect);
            this.cGroupBox3.Controls.Add(this.cTextBox_baudRate);
            this.cGroupBox3.Controls.Add(this.cLabel2);
            this.cGroupBox3.Controls.Add(this.cLabel1);
            this.cGroupBox3.Controls.Add(this.cDropDown_serialPorts);
            this.cGroupBox3.Controls.Add(this.cButton_connect);
            this.cGroupBox3.Font = new System.Drawing.Font("Armata", 12F);
            this.cGroupBox3.Location = new System.Drawing.Point(12, 85);
            this.cGroupBox3.Name = "cGroupBox3";
            this.cGroupBox3.Radius = 25;
            this.cGroupBox3.Size = new System.Drawing.Size(245, 399);
            this.cGroupBox3.TabIndex = 12;
            this.cGroupBox3.TabStop = false;
            this.cGroupBox3.Text = "Connection settings";
            this.cGroupBox3.TextAlignment = System.Drawing.StringAlignment.Center;
            this.cGroupBox3.TextStyle = CCL.eTextStyle.Medium;
            // 
            // cButton_refreshSerialPorts
            // 
            this.cButton_refreshSerialPorts.BackgroundImage = global::CNCV.Properties.Resources.Refresh001;
            this.cButton_refreshSerialPorts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cButton_refreshSerialPorts.DrawBorder = false;
            this.cButton_refreshSerialPorts.Font = new System.Drawing.Font("Armata", 10F);
            this.cButton_refreshSerialPorts.Location = new System.Drawing.Point(212, 26);
            this.cButton_refreshSerialPorts.Name = "cButton_refreshSerialPorts";
            this.cButton_refreshSerialPorts.Size = new System.Drawing.Size(24, 24);
            this.cButton_refreshSerialPorts.TabIndex = 13;
            this.cButton_refreshSerialPorts.TextStyle = CCL.eTextStyle.Normal;
            this.cButton_refreshSerialPorts.UseVisualStyleBackColor = true;
            this.cButton_refreshSerialPorts.Click += new System.EventHandler(this.cButton_refreshSerialPorts_Click);
            // 
            // cLabel_opt
            // 
            this.cLabel_opt.BackColor = System.Drawing.Color.Transparent;
            this.cLabel_opt.Font = new System.Drawing.Font("Armata", 10F);
            this.cLabel_opt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cLabel_opt.Location = new System.Drawing.Point(9, 347);
            this.cLabel_opt.Name = "cLabel_opt";
            this.cLabel_opt.Size = new System.Drawing.Size(230, 19);
            this.cLabel_opt.TabIndex = 23;
            this.cLabel_opt.Text = "OPT ***";
            this.cLabel_opt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cLabel_opt.TextStyle = CCL.eTextStyle.Normal;
            // 
            // cLabel_version
            // 
            this.cLabel_version.BackColor = System.Drawing.Color.Transparent;
            this.cLabel_version.Font = new System.Drawing.Font("Armata", 10F);
            this.cLabel_version.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cLabel_version.Location = new System.Drawing.Point(9, 314);
            this.cLabel_version.Name = "cLabel_version";
            this.cLabel_version.Size = new System.Drawing.Size(230, 19);
            this.cLabel_version.TabIndex = 22;
            this.cLabel_version.Text = "VERSION ***";
            this.cLabel_version.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cLabel_version.TextStyle = CCL.eTextStyle.Normal;
            // 
            // cLabel_machineStatus
            // 
            this.cLabel_machineStatus.BackColor = System.Drawing.Color.Transparent;
            this.cLabel_machineStatus.Font = new System.Drawing.Font("Armata", 10F);
            this.cLabel_machineStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cLabel_machineStatus.Location = new System.Drawing.Point(9, 232);
            this.cLabel_machineStatus.Name = "cLabel_machineStatus";
            this.cLabel_machineStatus.Size = new System.Drawing.Size(230, 41);
            this.cLabel_machineStatus.TabIndex = 21;
            this.cLabel_machineStatus.Text = "No Connection";
            this.cLabel_machineStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cLabel_machineStatus.TextStyle = CCL.eTextStyle.Normal;
            // 
            // cButton_getSettings
            // 
            this.cButton_getSettings.DrawBorder = true;
            this.cButton_getSettings.Enabled = false;
            this.cButton_getSettings.Font = new System.Drawing.Font("Armata", 10F);
            this.cButton_getSettings.Location = new System.Drawing.Point(9, 141);
            this.cButton_getSettings.Name = "cButton_getSettings";
            this.cButton_getSettings.Size = new System.Drawing.Size(230, 24);
            this.cButton_getSettings.TabIndex = 20;
            this.cButton_getSettings.Text = "Scan GRBL Settings";
            this.cButton_getSettings.TextStyle = CCL.eTextStyle.Normal;
            this.cButton_getSettings.UseVisualStyleBackColor = true;
            this.cButton_getSettings.Click += new System.EventHandler(this.cButton_getSettings_Click);
            // 
            // cButton_reset
            // 
            this.cButton_reset.DrawBorder = true;
            this.cButton_reset.Enabled = false;
            this.cButton_reset.Font = new System.Drawing.Font("Armata", 10F);
            this.cButton_reset.Location = new System.Drawing.Point(139, 111);
            this.cButton_reset.Name = "cButton_reset";
            this.cButton_reset.Size = new System.Drawing.Size(100, 24);
            this.cButton_reset.TabIndex = 19;
            this.cButton_reset.Text = "Reset";
            this.cButton_reset.TextStyle = CCL.eTextStyle.Normal;
            this.cButton_reset.UseVisualStyleBackColor = true;
            this.cButton_reset.Click += new System.EventHandler(this.cButton_reset_Click);
            // 
            // cButton_unlock
            // 
            this.cButton_unlock.DrawBorder = true;
            this.cButton_unlock.Enabled = false;
            this.cButton_unlock.Font = new System.Drawing.Font("Armata", 10F);
            this.cButton_unlock.Location = new System.Drawing.Point(9, 111);
            this.cButton_unlock.Name = "cButton_unlock";
            this.cButton_unlock.Size = new System.Drawing.Size(100, 24);
            this.cButton_unlock.TabIndex = 18;
            this.cButton_unlock.Text = "Unlock";
            this.cButton_unlock.TextStyle = CCL.eTextStyle.Normal;
            this.cButton_unlock.UseVisualStyleBackColor = true;
            this.cButton_unlock.Click += new System.EventHandler(this.cButton_unlock_Click);
            // 
            // cButton_disconnect
            // 
            this.cButton_disconnect.DrawBorder = true;
            this.cButton_disconnect.Enabled = false;
            this.cButton_disconnect.Font = new System.Drawing.Font("Armata", 10F);
            this.cButton_disconnect.Location = new System.Drawing.Point(139, 81);
            this.cButton_disconnect.Name = "cButton_disconnect";
            this.cButton_disconnect.Size = new System.Drawing.Size(100, 24);
            this.cButton_disconnect.TabIndex = 17;
            this.cButton_disconnect.Text = "Disconnect";
            this.cButton_disconnect.TextStyle = CCL.eTextStyle.Normal;
            this.cButton_disconnect.UseVisualStyleBackColor = true;
            this.cButton_disconnect.Click += new System.EventHandler(this.cButton_disconnect_Click);
            // 
            // cTextBox_baudRate
            // 
            this.cTextBox_baudRate.Depth = 0;
            this.cTextBox_baudRate.Font = new System.Drawing.Font("Armata", 10F);
            this.cTextBox_baudRate.Hint = "";
            this.cTextBox_baudRate.LineHeight = 1;
            this.cTextBox_baudRate.Location = new System.Drawing.Point(95, 57);
            this.cTextBox_baudRate.MaxLength = 32767;
            this.cTextBox_baudRate.MouseState = CCL.MouseState.HOVER;
            this.cTextBox_baudRate.Name = "cTextBox_baudRate";
            this.cTextBox_baudRate.PasswordChar = '\0';
            this.cTextBox_baudRate.SelectedText = "";
            this.cTextBox_baudRate.SelectionLength = 0;
            this.cTextBox_baudRate.SelectionStart = 0;
            this.cTextBox_baudRate.Size = new System.Drawing.Size(144, 18);
            this.cTextBox_baudRate.TabIndex = 16;
            this.cTextBox_baudRate.TabStop = false;
            this.cTextBox_baudRate.Text = "115200";
            this.cTextBox_baudRate.TextStyle = CCL.eTextStyle.Normal;
            this.cTextBox_baudRate.UseSystemPasswordChar = false;
            // 
            // cLabel2
            // 
            this.cLabel2.AutoSize = true;
            this.cLabel2.BackColor = System.Drawing.Color.Transparent;
            this.cLabel2.Font = new System.Drawing.Font("Armata", 10F);
            this.cLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cLabel2.Location = new System.Drawing.Point(6, 57);
            this.cLabel2.Name = "cLabel2";
            this.cLabel2.Size = new System.Drawing.Size(77, 18);
            this.cLabel2.TabIndex = 15;
            this.cLabel2.Text = "Baud rate";
            this.cLabel2.TextStyle = CCL.eTextStyle.Normal;
            // 
            // cLabel1
            // 
            this.cLabel1.AutoSize = true;
            this.cLabel1.BackColor = System.Drawing.Color.Transparent;
            this.cLabel1.Font = new System.Drawing.Font("Armata", 10F);
            this.cLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cLabel1.Location = new System.Drawing.Point(6, 33);
            this.cLabel1.Name = "cLabel1";
            this.cLabel1.Size = new System.Drawing.Size(83, 18);
            this.cLabel1.TabIndex = 14;
            this.cLabel1.Text = "Serial port";
            this.cLabel1.TextStyle = CCL.eTextStyle.Normal;
            // 
            // cDropDown_serialPorts
            // 
            this.cDropDown_serialPorts.Font = new System.Drawing.Font("Armata", 10F);
            this.cDropDown_serialPorts.Location = new System.Drawing.Point(95, 26);
            this.cDropDown_serialPorts.Name = "cDropDown_serialPorts";
            this.cDropDown_serialPorts.SelectedIndex = -1;
            this.cDropDown_serialPorts.Size = new System.Drawing.Size(114, 25);
            this.cDropDown_serialPorts.TabIndex = 13;
            this.cDropDown_serialPorts.Text = "cDropDown2";
            this.cDropDown_serialPorts.TextStyle = CCL.eTextStyle.Normal;
            // 
            // cButton_connect
            // 
            this.cButton_connect.DrawBorder = true;
            this.cButton_connect.Font = new System.Drawing.Font("Armata", 10F);
            this.cButton_connect.Location = new System.Drawing.Point(9, 81);
            this.cButton_connect.Name = "cButton_connect";
            this.cButton_connect.Size = new System.Drawing.Size(100, 24);
            this.cButton_connect.TabIndex = 13;
            this.cButton_connect.Text = "Connect";
            this.cButton_connect.TextStyle = CCL.eTextStyle.Normal;
            this.cButton_connect.UseVisualStyleBackColor = true;
            this.cButton_connect.Click += new System.EventHandler(this.cButton_connect_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cTextBox_toolChangeTime
            // 
            this.cTextBox_toolChangeTime.Depth = 0;
            this.cTextBox_toolChangeTime.Font = new System.Drawing.Font("Armata", 10F);
            this.cTextBox_toolChangeTime.Hint = "";
            this.cTextBox_toolChangeTime.LineHeight = 1;
            this.cTextBox_toolChangeTime.Location = new System.Drawing.Point(410, 504);
            this.cTextBox_toolChangeTime.MaxLength = 32767;
            this.cTextBox_toolChangeTime.MouseState = CCL.MouseState.HOVER;
            this.cTextBox_toolChangeTime.Name = "cTextBox_toolChangeTime";
            this.cTextBox_toolChangeTime.PasswordChar = '\0';
            this.cTextBox_toolChangeTime.SelectedText = "";
            this.cTextBox_toolChangeTime.SelectionLength = 0;
            this.cTextBox_toolChangeTime.SelectionStart = 0;
            this.cTextBox_toolChangeTime.Size = new System.Drawing.Size(45, 18);
            this.cTextBox_toolChangeTime.TabIndex = 18;
            this.cTextBox_toolChangeTime.TabStop = false;
            this.cTextBox_toolChangeTime.Text = "30";
            this.cTextBox_toolChangeTime.TextStyle = CCL.eTextStyle.Normal;
            this.cTextBox_toolChangeTime.UseSystemPasswordChar = false;
            this.cTextBox_toolChangeTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cTextBox_toolChangeTime_KeyPress);
            // 
            // cLabel3
            // 
            this.cLabel3.AutoSize = true;
            this.cLabel3.BackColor = System.Drawing.Color.Transparent;
            this.cLabel3.Font = new System.Drawing.Font("Armata", 10F);
            this.cLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cLabel3.Location = new System.Drawing.Point(263, 492);
            this.cLabel3.Name = "cLabel3";
            this.cLabel3.Size = new System.Drawing.Size(131, 36);
            this.cLabel3.TabIndex = 17;
            this.cLabel3.Text = "Tool change time\r\nin seconds";
            this.cLabel3.TextStyle = CCL.eTextStyle.Normal;
            // 
            // cTextBox_touchPlateHeight
            // 
            this.cTextBox_touchPlateHeight.Depth = 0;
            this.cTextBox_touchPlateHeight.Font = new System.Drawing.Font("Armata", 10F);
            this.cTextBox_touchPlateHeight.Hint = "";
            this.cTextBox_touchPlateHeight.LineHeight = 1;
            this.cTextBox_touchPlateHeight.Location = new System.Drawing.Point(410, 466);
            this.cTextBox_touchPlateHeight.MaxLength = 32767;
            this.cTextBox_touchPlateHeight.MouseState = CCL.MouseState.HOVER;
            this.cTextBox_touchPlateHeight.Name = "cTextBox_touchPlateHeight";
            this.cTextBox_touchPlateHeight.PasswordChar = '\0';
            this.cTextBox_touchPlateHeight.SelectedText = "";
            this.cTextBox_touchPlateHeight.SelectionLength = 0;
            this.cTextBox_touchPlateHeight.SelectionStart = 0;
            this.cTextBox_touchPlateHeight.Size = new System.Drawing.Size(45, 18);
            this.cTextBox_touchPlateHeight.TabIndex = 20;
            this.cTextBox_touchPlateHeight.TabStop = false;
            this.cTextBox_touchPlateHeight.Text = "10";
            this.cTextBox_touchPlateHeight.TextStyle = CCL.eTextStyle.Normal;
            this.cTextBox_touchPlateHeight.UseSystemPasswordChar = false;
            this.cTextBox_touchPlateHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cTextBox_touchPlateHeight_KeyPress);
            // 
            // cLabel4
            // 
            this.cLabel4.AutoSize = true;
            this.cLabel4.BackColor = System.Drawing.Color.Transparent;
            this.cLabel4.Font = new System.Drawing.Font("Armata", 10F);
            this.cLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cLabel4.Location = new System.Drawing.Point(263, 466);
            this.cLabel4.Name = "cLabel4";
            this.cLabel4.Size = new System.Drawing.Size(141, 18);
            this.cLabel4.TabIndex = 19;
            this.cLabel4.Text = "Touch plate height";
            this.cLabel4.TextStyle = CCL.eTextStyle.Normal;
            // 
            // cButton_sendSettings
            // 
            this.cButton_sendSettings.DrawBorder = true;
            this.cButton_sendSettings.Enabled = false;
            this.cButton_sendSettings.Font = new System.Drawing.Font("Armata", 10F);
            this.cButton_sendSettings.Location = new System.Drawing.Point(9, 171);
            this.cButton_sendSettings.Name = "cButton_sendSettings";
            this.cButton_sendSettings.Size = new System.Drawing.Size(230, 24);
            this.cButton_sendSettings.TabIndex = 24;
            this.cButton_sendSettings.Text = "Send GRBL Settings";
            this.cButton_sendSettings.TextStyle = CCL.eTextStyle.Normal;
            this.cButton_sendSettings.UseVisualStyleBackColor = true;
            this.cButton_sendSettings.Click += new System.EventHandler(this.cButton_sendSettings_Click);
            // 
            // Form_Machine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 540);
            this.ControlBox = false;
            this.Controls.Add(this.cTextBox_touchPlateHeight);
            this.Controls.Add(this.cLabel4);
            this.Controls.Add(this.cTextBox_toolChangeTime);
            this.Controls.Add(this.cLabel3);
            this.Controls.Add(this.cTextBox_name);
            this.Controls.Add(this.cDropDown_type);
            this.Controls.Add(this.cGroupBox3);
            this.Controls.Add(this.cButton_cancel);
            this.Controls.Add(this.cButton_ok);
            this.Controls.Add(this.cListView_grblSettings);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Machine";
            this.Sizable = false;
            this.Text = "Machine";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Machine_FormClosing);
            this.Load += new System.EventHandler(this.Form_Machine_Load);
            this.cGroupBox3.ResumeLayout(false);
            this.cGroupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCL.Controls.CListView cListView_grblSettings;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private CCL.Controls.CButton cButton_cancel;
        private CCL.Controls.CButton cButton_ok;
        private CCL.Controls.CTextBox cTextBox_name;
        private CCL.Controls.CDropDown cDropDown_type;
        private CCL.Controls.CGroupBox cGroupBox3;
        private CCL.Controls.CButton cButton_connect;
        private CCL.Controls.CLabel cLabel1;
        private CCL.Controls.CDropDown cDropDown_serialPorts;
        private CCL.Controls.CTextBox cTextBox_baudRate;
        private CCL.Controls.CLabel cLabel2;
        private CCL.Controls.CButton cButton_disconnect;
        private CCL.Controls.CButton cButton_reset;
        private CCL.Controls.CButton cButton_unlock;
        private CCL.Controls.CButton cButton_getSettings;
        private CCL.Controls.CLabel cLabel_machineStatus;
        private CCL.Controls.CLabel cLabel_opt;
        private CCL.Controls.CLabel cLabel_version;
        private CCL.Controls.CButton cButton_refreshSerialPorts;
        private System.Windows.Forms.Timer timer1;
        private CCL.Controls.CTextBox cTextBox_toolChangeTime;
        private CCL.Controls.CLabel cLabel3;
        private CCL.Controls.CTextBox cTextBox_touchPlateHeight;
        private CCL.Controls.CLabel cLabel4;
        private CCL.Controls.CButton cButton_sendSettings;
    }
}