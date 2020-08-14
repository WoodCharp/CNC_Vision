namespace CNCV.Pages
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
            this.cButton_sendSettings = new CCL.Controls.CButton();
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
            this.cTabControl1 = new CCL.Controls.CTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cLabel8 = new CCL.Controls.CLabel();
            this.cTextBoxMoveUp = new CCL.Controls.CTextBox();
            this.cLabel4 = new CCL.Controls.CLabel();
            this.cTextBox_touchPlateHeight = new CCL.Controls.CTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cLabel7 = new CCL.Controls.CLabel();
            this.cTextBoxJoggingInterval = new CCL.Controls.CTextBox();
            this.cLabel6 = new CCL.Controls.CLabel();
            this.cTextBoxJoggingFeedRate = new CCL.Controls.CTextBox();
            this.cLabel5 = new CCL.Controls.CLabel();
            this.cTextBoxJoggingDistance = new CCL.Controls.CTextBox();
            this.cTabSelector1 = new CCL.Controls.CTabSelector();
            this.cRichTextBoxProbeSteps = new CCL.Controls.CRichTextBox();
            this.cLabel9 = new CCL.Controls.CLabel();
            this.cGroupBox3.SuspendLayout();
            this.cTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cListView_grblSettings
            // 
            this.cListView_grblSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cListView_grblSettings.ColumnHeaderTextStyle = CCL.eTextStyle.Normal;
            this.cListView_grblSettings.ColumnHeight = 24;
            this.cListView_grblSettings.Columns.Add(this.columnHeader1);
            this.cListView_grblSettings.Columns.Add(this.columnHeader2);
            this.cListView_grblSettings.Columns.Add(this.columnHeader3);
            this.cListView_grblSettings.ContentTextStyle = CCL.eTextStyle.Normal;
            this.cListView_grblSettings.DrawBorder = false;
            this.cListView_grblSettings.EnableItemEdit = true;
            this.cListView_grblSettings.FullRowHoverEffect = false;
            this.cListView_grblSettings.HorizontalLines = true;
            this.cListView_grblSettings.ItemHeight = 24;
            this.cListView_grblSettings.ItemHoverEffect = true;
            this.cListView_grblSettings.Location = new System.Drawing.Point(0, 0);
            this.cListView_grblSettings.MinColumnWidth = 20;
            this.cListView_grblSettings.Name = "cListView_grblSettings";
            this.cListView_grblSettings.NoItemsToShowText = "No Items To Show.";
            this.cListView_grblSettings.NonEditableColumns.Add("0");
            this.cListView_grblSettings.NonEditableColumns.Add("2");
            this.cListView_grblSettings.NothingToShowText = "Nothing To Show.";
            this.cListView_grblSettings.Size = new System.Drawing.Size(307, 442);
            this.cListView_grblSettings.TabIndex = 0;
            this.cListView_grblSettings.Text = "GRBL SETTINGS";
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
            this.columnHeader3.Width = 180;
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
            this.cLabel_opt.OverrideFontSize = 12F;
            this.cLabel_opt.Size = new System.Drawing.Size(230, 19);
            this.cLabel_opt.TabIndex = 23;
            this.cLabel_opt.Text = "OPT ***";
            this.cLabel_opt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cLabel_opt.TextStyle = CCL.eTextStyle.Normal;
            this.cLabel_opt.UseFontSizeOverride = false;
            // 
            // cLabel_version
            // 
            this.cLabel_version.BackColor = System.Drawing.Color.Transparent;
            this.cLabel_version.Font = new System.Drawing.Font("Armata", 10F);
            this.cLabel_version.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cLabel_version.Location = new System.Drawing.Point(9, 314);
            this.cLabel_version.Name = "cLabel_version";
            this.cLabel_version.OverrideFontSize = 12F;
            this.cLabel_version.Size = new System.Drawing.Size(230, 19);
            this.cLabel_version.TabIndex = 22;
            this.cLabel_version.Text = "VERSION ***";
            this.cLabel_version.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cLabel_version.TextStyle = CCL.eTextStyle.Normal;
            this.cLabel_version.UseFontSizeOverride = false;
            // 
            // cLabel_machineStatus
            // 
            this.cLabel_machineStatus.BackColor = System.Drawing.Color.Transparent;
            this.cLabel_machineStatus.Font = new System.Drawing.Font("Armata", 10F);
            this.cLabel_machineStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cLabel_machineStatus.Location = new System.Drawing.Point(9, 232);
            this.cLabel_machineStatus.Name = "cLabel_machineStatus";
            this.cLabel_machineStatus.OverrideFontSize = 12F;
            this.cLabel_machineStatus.Size = new System.Drawing.Size(230, 41);
            this.cLabel_machineStatus.TabIndex = 21;
            this.cLabel_machineStatus.Text = "No Connection";
            this.cLabel_machineStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cLabel_machineStatus.TextStyle = CCL.eTextStyle.Normal;
            this.cLabel_machineStatus.UseFontSizeOverride = false;
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
            this.cLabel2.OverrideFontSize = 12F;
            this.cLabel2.Size = new System.Drawing.Size(77, 18);
            this.cLabel2.TabIndex = 15;
            this.cLabel2.Text = "Baud rate";
            this.cLabel2.TextStyle = CCL.eTextStyle.Normal;
            this.cLabel2.UseFontSizeOverride = false;
            // 
            // cLabel1
            // 
            this.cLabel1.AutoSize = true;
            this.cLabel1.BackColor = System.Drawing.Color.Transparent;
            this.cLabel1.Font = new System.Drawing.Font("Armata", 10F);
            this.cLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cLabel1.Location = new System.Drawing.Point(6, 33);
            this.cLabel1.Name = "cLabel1";
            this.cLabel1.OverrideFontSize = 12F;
            this.cLabel1.Size = new System.Drawing.Size(83, 18);
            this.cLabel1.TabIndex = 14;
            this.cLabel1.Text = "Serial port";
            this.cLabel1.TextStyle = CCL.eTextStyle.Normal;
            this.cLabel1.UseFontSizeOverride = false;
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
            this.cTextBox_toolChangeTime.Location = new System.Drawing.Point(173, 102);
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
            this.cLabel3.Location = new System.Drawing.Point(6, 90);
            this.cLabel3.Name = "cLabel3";
            this.cLabel3.OverrideFontSize = 12F;
            this.cLabel3.Size = new System.Drawing.Size(131, 36);
            this.cLabel3.TabIndex = 17;
            this.cLabel3.Text = "Tool change time\r\nin seconds";
            this.cLabel3.TextStyle = CCL.eTextStyle.Normal;
            this.cLabel3.UseFontSizeOverride = false;
            // 
            // cTabControl1
            // 
            this.cTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cTabControl1.Controls.Add(this.tabPage1);
            this.cTabControl1.Controls.Add(this.tabPage3);
            this.cTabControl1.Controls.Add(this.tabPage2);
            this.cTabControl1.Location = new System.Drawing.Point(263, 60);
            this.cTabControl1.Name = "cTabControl1";
            this.cTabControl1.SelectedIndex = 0;
            this.cTabControl1.Size = new System.Drawing.Size(315, 468);
            this.cTabControl1.TabIndex = 21;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cListView_grblSettings);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(307, 442);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "GRBL";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Silver;
            this.tabPage3.Controls.Add(this.cLabel9);
            this.tabPage3.Controls.Add(this.cRichTextBoxProbeSteps);
            this.tabPage3.Controls.Add(this.cLabel8);
            this.tabPage3.Controls.Add(this.cTextBoxMoveUp);
            this.tabPage3.Controls.Add(this.cLabel4);
            this.tabPage3.Controls.Add(this.cTextBox_touchPlateHeight);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(307, 442);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Probe";
            // 
            // cLabel8
            // 
            this.cLabel8.AutoSize = true;
            this.cLabel8.BackColor = System.Drawing.Color.Transparent;
            this.cLabel8.Font = new System.Drawing.Font("Armata", 10F);
            this.cLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cLabel8.Location = new System.Drawing.Point(6, 27);
            this.cLabel8.Name = "cLabel8";
            this.cLabel8.OverrideFontSize = 12F;
            this.cLabel8.Size = new System.Drawing.Size(93, 36);
            this.cLabel8.TabIndex = 55;
            this.cLabel8.Text = "Final Move\r\nUp distance";
            this.cLabel8.TextStyle = CCL.eTextStyle.Normal;
            this.cLabel8.UseFontSizeOverride = false;
            // 
            // cTextBoxMoveUp
            // 
            this.cTextBoxMoveUp.Depth = 0;
            this.cTextBoxMoveUp.Font = new System.Drawing.Font("Armata", 10F);
            this.cTextBoxMoveUp.Hint = "";
            this.cTextBoxMoveUp.LineHeight = 1;
            this.cTextBoxMoveUp.Location = new System.Drawing.Point(173, 27);
            this.cTextBoxMoveUp.MaxLength = 32767;
            this.cTextBoxMoveUp.MouseState = CCL.MouseState.HOVER;
            this.cTextBoxMoveUp.Name = "cTextBoxMoveUp";
            this.cTextBoxMoveUp.PasswordChar = '\0';
            this.cTextBoxMoveUp.SelectedText = "";
            this.cTextBoxMoveUp.SelectionLength = 0;
            this.cTextBoxMoveUp.SelectionStart = 0;
            this.cTextBoxMoveUp.Size = new System.Drawing.Size(45, 18);
            this.cTextBoxMoveUp.TabIndex = 56;
            this.cTextBoxMoveUp.TabStop = false;
            this.cTextBoxMoveUp.Text = "10";
            this.cTextBoxMoveUp.TextStyle = CCL.eTextStyle.Normal;
            this.cTextBoxMoveUp.UseSystemPasswordChar = false;
            // 
            // cLabel4
            // 
            this.cLabel4.AutoSize = true;
            this.cLabel4.BackColor = System.Drawing.Color.Transparent;
            this.cLabel4.Font = new System.Drawing.Font("Armata", 10F);
            this.cLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cLabel4.Location = new System.Drawing.Point(6, 3);
            this.cLabel4.Name = "cLabel4";
            this.cLabel4.OverrideFontSize = 12F;
            this.cLabel4.Size = new System.Drawing.Size(141, 18);
            this.cLabel4.TabIndex = 53;
            this.cLabel4.Text = "Touch plate height";
            this.cLabel4.TextStyle = CCL.eTextStyle.Normal;
            this.cLabel4.UseFontSizeOverride = false;
            // 
            // cTextBox_touchPlateHeight
            // 
            this.cTextBox_touchPlateHeight.Depth = 0;
            this.cTextBox_touchPlateHeight.Font = new System.Drawing.Font("Armata", 10F);
            this.cTextBox_touchPlateHeight.Hint = "";
            this.cTextBox_touchPlateHeight.LineHeight = 1;
            this.cTextBox_touchPlateHeight.Location = new System.Drawing.Point(173, 3);
            this.cTextBox_touchPlateHeight.MaxLength = 32767;
            this.cTextBox_touchPlateHeight.MouseState = CCL.MouseState.HOVER;
            this.cTextBox_touchPlateHeight.Name = "cTextBox_touchPlateHeight";
            this.cTextBox_touchPlateHeight.PasswordChar = '\0';
            this.cTextBox_touchPlateHeight.SelectedText = "";
            this.cTextBox_touchPlateHeight.SelectionLength = 0;
            this.cTextBox_touchPlateHeight.SelectionStart = 0;
            this.cTextBox_touchPlateHeight.Size = new System.Drawing.Size(45, 18);
            this.cTextBox_touchPlateHeight.TabIndex = 54;
            this.cTextBox_touchPlateHeight.TabStop = false;
            this.cTextBox_touchPlateHeight.Text = "10";
            this.cTextBox_touchPlateHeight.TextStyle = CCL.eTextStyle.Normal;
            this.cTextBox_touchPlateHeight.UseSystemPasswordChar = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DarkGray;
            this.tabPage2.Controls.Add(this.cLabel7);
            this.tabPage2.Controls.Add(this.cTextBoxJoggingInterval);
            this.tabPage2.Controls.Add(this.cLabel6);
            this.tabPage2.Controls.Add(this.cTextBoxJoggingFeedRate);
            this.tabPage2.Controls.Add(this.cLabel5);
            this.tabPage2.Controls.Add(this.cTextBoxJoggingDistance);
            this.tabPage2.Controls.Add(this.cLabel3);
            this.tabPage2.Controls.Add(this.cTextBox_toolChangeTime);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(307, 442);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Other";
            // 
            // cLabel7
            // 
            this.cLabel7.AutoSize = true;
            this.cLabel7.BackColor = System.Drawing.Color.Transparent;
            this.cLabel7.Font = new System.Drawing.Font("Armata", 10F);
            this.cLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cLabel7.Location = new System.Drawing.Point(6, 51);
            this.cLabel7.Name = "cLabel7";
            this.cLabel7.OverrideFontSize = 12F;
            this.cLabel7.Size = new System.Drawing.Size(161, 18);
            this.cLabel7.TabIndex = 25;
            this.cLabel7.Text = "Jogging interval (ms)";
            this.cLabel7.TextStyle = CCL.eTextStyle.Normal;
            this.cLabel7.UseFontSizeOverride = false;
            // 
            // cTextBoxJoggingInterval
            // 
            this.cTextBoxJoggingInterval.Depth = 0;
            this.cTextBoxJoggingInterval.Font = new System.Drawing.Font("Armata", 10F);
            this.cTextBoxJoggingInterval.Hint = "";
            this.cTextBoxJoggingInterval.LineHeight = 1;
            this.cTextBoxJoggingInterval.Location = new System.Drawing.Point(173, 51);
            this.cTextBoxJoggingInterval.MaxLength = 32767;
            this.cTextBoxJoggingInterval.MouseState = CCL.MouseState.HOVER;
            this.cTextBoxJoggingInterval.Name = "cTextBoxJoggingInterval";
            this.cTextBoxJoggingInterval.PasswordChar = '\0';
            this.cTextBoxJoggingInterval.SelectedText = "";
            this.cTextBoxJoggingInterval.SelectionLength = 0;
            this.cTextBoxJoggingInterval.SelectionStart = 0;
            this.cTextBoxJoggingInterval.Size = new System.Drawing.Size(45, 18);
            this.cTextBoxJoggingInterval.TabIndex = 26;
            this.cTextBoxJoggingInterval.TabStop = false;
            this.cTextBoxJoggingInterval.Text = "500";
            this.cTextBoxJoggingInterval.TextStyle = CCL.eTextStyle.Normal;
            this.cTextBoxJoggingInterval.UseSystemPasswordChar = false;
            // 
            // cLabel6
            // 
            this.cLabel6.AutoSize = true;
            this.cLabel6.BackColor = System.Drawing.Color.Transparent;
            this.cLabel6.Font = new System.Drawing.Font("Armata", 10F);
            this.cLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cLabel6.Location = new System.Drawing.Point(6, 27);
            this.cLabel6.Name = "cLabel6";
            this.cLabel6.OverrideFontSize = 12F;
            this.cLabel6.Size = new System.Drawing.Size(133, 18);
            this.cLabel6.TabIndex = 23;
            this.cLabel6.Text = "Jogging feed rate";
            this.cLabel6.TextStyle = CCL.eTextStyle.Normal;
            this.cLabel6.UseFontSizeOverride = false;
            // 
            // cTextBoxJoggingFeedRate
            // 
            this.cTextBoxJoggingFeedRate.Depth = 0;
            this.cTextBoxJoggingFeedRate.Font = new System.Drawing.Font("Armata", 10F);
            this.cTextBoxJoggingFeedRate.Hint = "";
            this.cTextBoxJoggingFeedRate.LineHeight = 1;
            this.cTextBoxJoggingFeedRate.Location = new System.Drawing.Point(173, 27);
            this.cTextBoxJoggingFeedRate.MaxLength = 32767;
            this.cTextBoxJoggingFeedRate.MouseState = CCL.MouseState.HOVER;
            this.cTextBoxJoggingFeedRate.Name = "cTextBoxJoggingFeedRate";
            this.cTextBoxJoggingFeedRate.PasswordChar = '\0';
            this.cTextBoxJoggingFeedRate.SelectedText = "";
            this.cTextBoxJoggingFeedRate.SelectionLength = 0;
            this.cTextBoxJoggingFeedRate.SelectionStart = 0;
            this.cTextBoxJoggingFeedRate.Size = new System.Drawing.Size(45, 18);
            this.cTextBoxJoggingFeedRate.TabIndex = 24;
            this.cTextBoxJoggingFeedRate.TabStop = false;
            this.cTextBoxJoggingFeedRate.Text = "500";
            this.cTextBoxJoggingFeedRate.TextStyle = CCL.eTextStyle.Normal;
            this.cTextBoxJoggingFeedRate.UseSystemPasswordChar = false;
            // 
            // cLabel5
            // 
            this.cLabel5.AutoSize = true;
            this.cLabel5.BackColor = System.Drawing.Color.Transparent;
            this.cLabel5.Font = new System.Drawing.Font("Armata", 10F);
            this.cLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cLabel5.Location = new System.Drawing.Point(6, 3);
            this.cLabel5.Name = "cLabel5";
            this.cLabel5.OverrideFontSize = 12F;
            this.cLabel5.Size = new System.Drawing.Size(130, 18);
            this.cLabel5.TabIndex = 21;
            this.cLabel5.Text = "Jogging distance";
            this.cLabel5.TextStyle = CCL.eTextStyle.Normal;
            this.cLabel5.UseFontSizeOverride = false;
            // 
            // cTextBoxJoggingDistance
            // 
            this.cTextBoxJoggingDistance.Depth = 0;
            this.cTextBoxJoggingDistance.Font = new System.Drawing.Font("Armata", 10F);
            this.cTextBoxJoggingDistance.Hint = "";
            this.cTextBoxJoggingDistance.LineHeight = 1;
            this.cTextBoxJoggingDistance.Location = new System.Drawing.Point(173, 3);
            this.cTextBoxJoggingDistance.MaxLength = 32767;
            this.cTextBoxJoggingDistance.MouseState = CCL.MouseState.HOVER;
            this.cTextBoxJoggingDistance.Name = "cTextBoxJoggingDistance";
            this.cTextBoxJoggingDistance.PasswordChar = '\0';
            this.cTextBoxJoggingDistance.SelectedText = "";
            this.cTextBoxJoggingDistance.SelectionLength = 0;
            this.cTextBoxJoggingDistance.SelectionStart = 0;
            this.cTextBoxJoggingDistance.Size = new System.Drawing.Size(45, 18);
            this.cTextBoxJoggingDistance.TabIndex = 22;
            this.cTextBoxJoggingDistance.TabStop = false;
            this.cTextBoxJoggingDistance.Text = "1,5";
            this.cTextBoxJoggingDistance.TextStyle = CCL.eTextStyle.Normal;
            this.cTextBoxJoggingDistance.UseSystemPasswordChar = false;
            // 
            // cTabSelector1
            // 
            this.cTabSelector1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cTabSelector1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.cTabSelector1.BaseTabControl = this.cTabControl1;
            this.cTabSelector1.DrawLineAllTheWay = true;
            this.cTabSelector1.Font = new System.Drawing.Font("Armata", 8F);
            this.cTabSelector1.IndicatorHeight = 4;
            this.cTabSelector1.LineHeight = 1;
            this.cTabSelector1.Location = new System.Drawing.Point(263, 30);
            this.cTabSelector1.Name = "cTabSelector1";
            this.cTabSelector1.SelectorHeight = 24;
            this.cTabSelector1.SelectorPadding = 10;
            this.cTabSelector1.Size = new System.Drawing.Size(315, 24);
            this.cTabSelector1.TabIndex = 22;
            this.cTabSelector1.TabsAlignment = CCL.Controls.CTabSelector.eTabsAlignment.Left;
            this.cTabSelector1.Text = "cTabSelector1";
            this.cTabSelector1.TextStyle = CCL.eTextStyle.Small;
            // 
            // cRichTextBoxProbeSteps
            // 
            this.cRichTextBoxProbeSteps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.cRichTextBoxProbeSteps.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cRichTextBoxProbeSteps.Font = new System.Drawing.Font("Armata", 10F);
            this.cRichTextBoxProbeSteps.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cRichTextBoxProbeSteps.Location = new System.Drawing.Point(3, 127);
            this.cRichTextBoxProbeSteps.Name = "cRichTextBoxProbeSteps";
            this.cRichTextBoxProbeSteps.Size = new System.Drawing.Size(301, 149);
            this.cRichTextBoxProbeSteps.TabIndex = 57;
            this.cRichTextBoxProbeSteps.Text = "";
            this.cRichTextBoxProbeSteps.TextStyle = CCL.eTextStyle.Normal;
            // 
            // cLabel9
            // 
            this.cLabel9.AutoSize = true;
            this.cLabel9.BackColor = System.Drawing.Color.Transparent;
            this.cLabel9.Font = new System.Drawing.Font("Armata", 10F);
            this.cLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cLabel9.Location = new System.Drawing.Point(6, 106);
            this.cLabel9.Name = "cLabel9";
            this.cLabel9.OverrideFontSize = 12F;
            this.cLabel9.Size = new System.Drawing.Size(93, 18);
            this.cLabel9.TabIndex = 58;
            this.cLabel9.Text = "Probe steps";
            this.cLabel9.TextStyle = CCL.eTextStyle.Normal;
            this.cLabel9.UseFontSizeOverride = false;
            // 
            // Form_Machine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 540);
            this.ControlBox = false;
            this.Controls.Add(this.cTabSelector1);
            this.Controls.Add(this.cTabControl1);
            this.Controls.Add(this.cTextBox_name);
            this.Controls.Add(this.cDropDown_type);
            this.Controls.Add(this.cGroupBox3);
            this.Controls.Add(this.cButton_cancel);
            this.Controls.Add(this.cButton_ok);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Machine";
            this.Sizable = false;
            this.Text = "Machine";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Machine_FormClosing);
            this.Load += new System.EventHandler(this.Form_Machine_Load);
            this.cGroupBox3.ResumeLayout(false);
            this.cGroupBox3.PerformLayout();
            this.cTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

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
        private CCL.Controls.CButton cButton_sendSettings;
        private CCL.Controls.CTabControl cTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private CCL.Controls.CLabel cLabel7;
        private CCL.Controls.CTextBox cTextBoxJoggingInterval;
        private CCL.Controls.CLabel cLabel6;
        private CCL.Controls.CTextBox cTextBoxJoggingFeedRate;
        private CCL.Controls.CLabel cLabel5;
        private CCL.Controls.CTextBox cTextBoxJoggingDistance;
        private CCL.Controls.CTabSelector cTabSelector1;
        private System.Windows.Forms.TabPage tabPage3;
        private CCL.Controls.CLabel cLabel8;
        private CCL.Controls.CTextBox cTextBoxMoveUp;
        private CCL.Controls.CLabel cLabel4;
        private CCL.Controls.CTextBox cTextBox_touchPlateHeight;
        private CCL.Controls.CLabel cLabel9;
        private CCL.Controls.CRichTextBox cRichTextBoxProbeSteps;
    }
}