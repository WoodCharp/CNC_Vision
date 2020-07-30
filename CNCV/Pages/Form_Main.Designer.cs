namespace CNCV.Pages
{
    partial class Form_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.cTabControl1 = new CCL.Controls.CTabControl();
            this.tabPage_Controls = new System.Windows.Forms.TabPage();
            this.cButton_clear = new CCL.Controls.CButton();
            this.cLabel_wcoZ = new CCL.Controls.CLabel();
            this.cLabel_wcoY = new CCL.Controls.CLabel();
            this.cLabel_wcoX = new CCL.Controls.CLabel();
            this.cLabel8 = new CCL.Controls.CLabel();
            this.cCheckBox_showQuery = new CCL.Controls.CCheckBox();
            this.cButton_sendCommand = new CCL.Controls.CButton();
            this.cTextBox_command = new CCL.Controls.CTextBox();
            this.cRichTextBox1 = new CCL.Controls.CRichTextBox();
            this.cLabel_machineState = new CCL.Controls.CLabel();
            this.cTabControl2 = new CCL.Controls.CTabControl();
            this.tabPage_move = new System.Windows.Forms.TabPage();
            this.cPanel_manualMove = new CCL.Controls.CPanel();
            this.cCheckBox_lockX = new CCL.Controls.CCheckBox();
            this.cCheckBox_lockY = new CCL.Controls.CCheckBox();
            this.joggingKnob1 = new GRBL.Controls.JoggingKnob();
            this.cLabel7 = new CCL.Controls.CLabel();
            this.cDropDown_workSpace = new CCL.Controls.CDropDown();
            this.cRadioButton_g1 = new CCL.Controls.CRadioButton();
            this.cRadioButton_g0 = new CCL.Controls.CRadioButton();
            this.cLabel6 = new CCL.Controls.CLabel();
            this.cLabel5 = new CCL.Controls.CLabel();
            this.cTextBox_feedRate = new CCL.Controls.CTextBox();
            this.cTextBox_distance = new CCL.Controls.CTextBox();
            this.cButton_XmYp = new CCL.Controls.CButton();
            this.cButton_Zm = new CCL.Controls.CButton();
            this.cButton_Ym = new CCL.Controls.CButton();
            this.cButton_ZZero = new CCL.Controls.CButton();
            this.cButton_XpYm = new CCL.Controls.CButton();
            this.cButton_Zp = new CCL.Controls.CButton();
            this.cButton_XmYm = new CCL.Controls.CButton();
            this.cButton_XpYp = new CCL.Controls.CButton();
            this.cButton_Xp = new CCL.Controls.CButton();
            this.cButton_Yp = new CCL.Controls.CButton();
            this.cButton_XYZero = new CCL.Controls.CButton();
            this.cButton_Xm = new CCL.Controls.CButton();
            this.tabPage_spindle = new System.Windows.Forms.TabPage();
            this.cTabControl_spindleLaser = new CCL.Controls.CTabControl();
            this.tabPage_spindleControls = new System.Windows.Forms.TabPage();
            this.cLabel14 = new CCL.Controls.CLabel();
            this.cLabel10 = new CCL.Controls.CLabel();
            this.cLabel9 = new CCL.Controls.CLabel();
            this.cButton_touchThePlate = new CCL.Controls.CButton();
            this.cSwitch_enableSpindle = new CCL.Controls.CSwitch();
            this.tabPage_laserControls = new System.Windows.Forms.TabPage();
            this.cSwitch_enableStrongLaser = new CCL.Controls.CSwitch();
            this.cButton_showLaserArea = new CCL.Controls.CButton();
            this.cSwitch_enableWeakLaser = new CCL.Controls.CSwitch();
            this.tabPage_override = new System.Windows.Forms.TabPage();
            this.cGroupBox_overrideRapid = new CCL.Controls.CGroupBox();
            this.cLabel_overrideRapid = new CCL.Controls.CLabel();
            this.cRadioButton_overrideRapidQuarter = new CCL.Controls.CRadioButton();
            this.cRadioButton_overrideRapidHalf = new CCL.Controls.CRadioButton();
            this.cRadioButton_overrideRapidFull = new CCL.Controls.CRadioButton();
            this.cGroupBox_overrideSpindle = new CCL.Controls.CGroupBox();
            this.cLabel_overrideSpindle = new CCL.Controls.CLabel();
            this.cButton_overrideSpindleReduce = new CCL.Controls.CButton();
            this.cButton_overrideSpindleIncrease = new CCL.Controls.CButton();
            this.cRadioButton_overrideSpindleAddTen = new CCL.Controls.CRadioButton();
            this.cRadioButton_overrideSpindleAddOne = new CCL.Controls.CRadioButton();
            this.cGroupBox_overrideFeed = new CCL.Controls.CGroupBox();
            this.cLabel_overrideFeed = new CCL.Controls.CLabel();
            this.cButton_overrideFeedReduce = new CCL.Controls.CButton();
            this.cButton_overrideFeedIncrease = new CCL.Controls.CButton();
            this.cRadioButton_overrideFeedAddTen = new CCL.Controls.CRadioButton();
            this.cRadioButton_overrideFeedAddOne = new CCL.Controls.CRadioButton();
            this.tabPage_file = new System.Windows.Forms.TabPage();
            this.cLabel_approximate = new CCL.Controls.CLabel();
            this.cListView_fileTools = new CCL.Controls.CListView();
            this.columnHeader20 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader21 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader22 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader23 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader24 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cLabel_usedTime = new CCL.Controls.CLabel();
            this.cButton_openFile = new CCL.Controls.CButton();
            this.cLabel_endTime = new CCL.Controls.CLabel();
            this.cLabel16 = new CCL.Controls.CLabel();
            this.cLabel_startTime = new CCL.Controls.CLabel();
            this.cButton_sendFile = new CCL.Controls.CButton();
            this.cButton_stopFile = new CCL.Controls.CButton();
            this.cProgressBar1 = new CCL.Controls.CProgressBar();
            this.cLabel_percentage = new CCL.Controls.CLabel();
            this.cTabSelector1 = new CCL.Controls.CTabSelector();
            this.cButton_hold = new CCL.Controls.CButton();
            this.cButton_startResume = new CCL.Controls.CButton();
            this.cLabel15 = new CCL.Controls.CLabel();
            this.cLabel_fs = new CCL.Controls.CLabel();
            this.cButton_home = new CCL.Controls.CButton();
            this.cButton_unlock = new CCL.Controls.CButton();
            this.cButton_reset = new CCL.Controls.CButton();
            this.cLinkLabel_zeroAll = new CCL.Controls.CLinkLabel();
            this.cLinkLabel_zeroZ = new CCL.Controls.CLinkLabel();
            this.cLinkLabel_zeroY = new CCL.Controls.CLinkLabel();
            this.cLinkLabel_zeroX = new CCL.Controls.CLinkLabel();
            this.cLabel13 = new CCL.Controls.CLabel();
            this.cLabel12 = new CCL.Controls.CLabel();
            this.cLabel11 = new CCL.Controls.CLabel();
            this.cLabel_mposZ = new CCL.Controls.CLabel();
            this.cLabel_mposY = new CCL.Controls.CLabel();
            this.cLabel_mposX = new CCL.Controls.CLabel();
            this.cLabel_wposZ = new CCL.Controls.CLabel();
            this.cLabel_wposY = new CCL.Controls.CLabel();
            this.cLabel_wposX = new CCL.Controls.CLabel();
            this.cLabel4 = new CCL.Controls.CLabel();
            this.cLabel3 = new CCL.Controls.CLabel();
            this.cSwitch_openPort = new CCL.Controls.CSwitch();
            this.cDropDown_machineProfiles = new CCL.Controls.CDropDown();
            this.tabPage_Machines = new System.Windows.Forms.TabPage();
            this.cButton_cancelMachineSave = new CCL.Controls.CButton();
            this.cButton_saveMachines = new CCL.Controls.CButton();
            this.cListView_machines = new CCL.Controls.CListView();
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cContextMenuStrip_editMachine = new CCL.Controls.CContextMenuStrip();
            this.addMachineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.duplicateMachineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.exportMachineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importMachineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteMachineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadMachinesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.editMachineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage_Tools = new System.Windows.Forms.TabPage();
            this.cButton_cancelToolSave = new CCL.Controls.CButton();
            this.cButton_saveTools = new CCL.Controls.CButton();
            this.cLabel1 = new CCL.Controls.CLabel();
            this.cCheckBox_editToolValues = new CCL.Controls.CCheckBox();
            this.cListView_tools = new CCL.Controls.CListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cContextMenuStrip_editToolValues = new CCL.Controls.CContextMenuStrip();
            this.addNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.duplicateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage_Settings = new System.Windows.Forms.TabPage();
            this.cGroupBox2 = new CCL.Controls.CGroupBox();
            this.cRadioButtonSettingsTheme6 = new CCL.Controls.CRadioButton();
            this.cRadioButtonSettingsTheme5 = new CCL.Controls.CRadioButton();
            this.cRadioButtonSettingsTheme4 = new CCL.Controls.CRadioButton();
            this.cRadioButtonSettingsTheme3 = new CCL.Controls.CRadioButton();
            this.cRadioButtonSettingsTheme2 = new CCL.Controls.CRadioButton();
            this.cRadioButtonSettingsTheme1 = new CCL.Controls.CRadioButton();
            this.cButton_cancelAppSettings = new CCL.Controls.CButton();
            this.cButton_saveAppSettings = new CCL.Controls.CButton();
            this.cGroupBox1 = new CCL.Controls.CGroupBox();
            this.cLabel2 = new CCL.Controls.CLabel();
            this.cLabel_dataFolderPath = new CCL.Controls.CLabel();
            this.cButton_selectFolder = new CCL.Controls.CButton();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPanelSelector1 = new CCL.Controls.TabPanelSelector();
            this.ch_Tool_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_Tool_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_Tool_Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_Tool_CD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_Tool_SD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_Tool_FL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_Tool_F = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_Tool_A = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_Tool_R = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_Tool_W = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.schemeComponent1 = new CCL.SchemeComponent(this.components);
            this.schemeComponent2 = new CCL.SchemeComponent(this.components);
            this.cTabControl1.SuspendLayout();
            this.tabPage_Controls.SuspendLayout();
            this.cTabControl2.SuspendLayout();
            this.tabPage_move.SuspendLayout();
            this.cPanel_manualMove.SuspendLayout();
            this.tabPage_spindle.SuspendLayout();
            this.cTabControl_spindleLaser.SuspendLayout();
            this.tabPage_spindleControls.SuspendLayout();
            this.tabPage_laserControls.SuspendLayout();
            this.tabPage_override.SuspendLayout();
            this.cGroupBox_overrideRapid.SuspendLayout();
            this.cGroupBox_overrideSpindle.SuspendLayout();
            this.cGroupBox_overrideFeed.SuspendLayout();
            this.tabPage_file.SuspendLayout();
            this.tabPage_Machines.SuspendLayout();
            this.cContextMenuStrip_editMachine.SuspendLayout();
            this.tabPage_Tools.SuspendLayout();
            this.cContextMenuStrip_editToolValues.SuspendLayout();
            this.tabPage_Settings.SuspendLayout();
            this.cGroupBox2.SuspendLayout();
            this.cGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cTabControl1
            // 
            this.cTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cTabControl1.Controls.Add(this.tabPage_Controls);
            this.cTabControl1.Controls.Add(this.tabPage_Machines);
            this.cTabControl1.Controls.Add(this.tabPage_Tools);
            this.cTabControl1.Controls.Add(this.tabPage_Settings);
            this.cTabControl1.Location = new System.Drawing.Point(45, 25);
            this.cTabControl1.Name = "cTabControl1";
            this.cTabControl1.SelectedIndex = 0;
            this.cTabControl1.Size = new System.Drawing.Size(813, 663);
            this.cTabControl1.TabIndex = 0;
            // 
            // tabPage_Controls
            // 
            this.tabPage_Controls.BackColor = System.Drawing.Color.Silver;
            this.tabPage_Controls.Controls.Add(this.cButton_clear);
            this.tabPage_Controls.Controls.Add(this.cLabel_wcoZ);
            this.tabPage_Controls.Controls.Add(this.cLabel_wcoY);
            this.tabPage_Controls.Controls.Add(this.cLabel_wcoX);
            this.tabPage_Controls.Controls.Add(this.cLabel8);
            this.tabPage_Controls.Controls.Add(this.cCheckBox_showQuery);
            this.tabPage_Controls.Controls.Add(this.cButton_sendCommand);
            this.tabPage_Controls.Controls.Add(this.cTextBox_command);
            this.tabPage_Controls.Controls.Add(this.cRichTextBox1);
            this.tabPage_Controls.Controls.Add(this.cLabel_machineState);
            this.tabPage_Controls.Controls.Add(this.cTabControl2);
            this.tabPage_Controls.Controls.Add(this.cTabSelector1);
            this.tabPage_Controls.Controls.Add(this.cButton_hold);
            this.tabPage_Controls.Controls.Add(this.cButton_startResume);
            this.tabPage_Controls.Controls.Add(this.cLabel15);
            this.tabPage_Controls.Controls.Add(this.cLabel_fs);
            this.tabPage_Controls.Controls.Add(this.cButton_home);
            this.tabPage_Controls.Controls.Add(this.cButton_unlock);
            this.tabPage_Controls.Controls.Add(this.cButton_reset);
            this.tabPage_Controls.Controls.Add(this.cLinkLabel_zeroAll);
            this.tabPage_Controls.Controls.Add(this.cLinkLabel_zeroZ);
            this.tabPage_Controls.Controls.Add(this.cLinkLabel_zeroY);
            this.tabPage_Controls.Controls.Add(this.cLinkLabel_zeroX);
            this.tabPage_Controls.Controls.Add(this.cLabel13);
            this.tabPage_Controls.Controls.Add(this.cLabel12);
            this.tabPage_Controls.Controls.Add(this.cLabel11);
            this.tabPage_Controls.Controls.Add(this.cLabel_mposZ);
            this.tabPage_Controls.Controls.Add(this.cLabel_mposY);
            this.tabPage_Controls.Controls.Add(this.cLabel_mposX);
            this.tabPage_Controls.Controls.Add(this.cLabel_wposZ);
            this.tabPage_Controls.Controls.Add(this.cLabel_wposY);
            this.tabPage_Controls.Controls.Add(this.cLabel_wposX);
            this.tabPage_Controls.Controls.Add(this.cLabel4);
            this.tabPage_Controls.Controls.Add(this.cLabel3);
            this.tabPage_Controls.Controls.Add(this.cSwitch_openPort);
            this.tabPage_Controls.Controls.Add(this.cDropDown_machineProfiles);
            this.tabPage_Controls.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Controls.Name = "tabPage_Controls";
            this.tabPage_Controls.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Controls.Size = new System.Drawing.Size(805, 637);
            this.tabPage_Controls.TabIndex = 0;
            this.tabPage_Controls.Text = "Controls";
            // 
            // cButton_clear
            // 
            this.cButton_clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cButton_clear.DrawBorder = true;
            this.cButton_clear.Font = new System.Drawing.Font("Armata", 12F);
            this.cButton_clear.Location = new System.Drawing.Point(318, 587);
            this.cButton_clear.Name = "cButton_clear";
            this.cButton_clear.Size = new System.Drawing.Size(92, 21);
            this.cButton_clear.TabIndex = 42;
            this.cButton_clear.Text = "CLEAR";
            this.cButton_clear.TextStyle = CCL.eTextStyle.Medium;
            this.cButton_clear.UseVisualStyleBackColor = true;
            this.cButton_clear.Click += new System.EventHandler(this.cButton_clear_Click);
            // 
            // cLabel_wcoZ
            // 
            this.cLabel_wcoZ.AutoSize = true;
            this.cLabel_wcoZ.BackColor = System.Drawing.Color.Transparent;
            this.cLabel_wcoZ.Font = new System.Drawing.Font("Armata", 12F);
            this.cLabel_wcoZ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cLabel_wcoZ.Location = new System.Drawing.Point(325, 168);
            this.cLabel_wcoZ.Name = "cLabel_wcoZ";
            this.cLabel_wcoZ.OverrideFontSize = 12F;
            this.cLabel_wcoZ.Size = new System.Drawing.Size(85, 20);
            this.cLabel_wcoZ.TabIndex = 41;
            this.cLabel_wcoZ.Text = "000.000";
            this.cLabel_wcoZ.TextStyle = CCL.eTextStyle.Medium;
            this.cLabel_wcoZ.UseFontSizeOverride = false;
            // 
            // cLabel_wcoY
            // 
            this.cLabel_wcoY.AutoSize = true;
            this.cLabel_wcoY.BackColor = System.Drawing.Color.Transparent;
            this.cLabel_wcoY.Font = new System.Drawing.Font("Armata", 12F);
            this.cLabel_wcoY.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cLabel_wcoY.Location = new System.Drawing.Point(325, 141);
            this.cLabel_wcoY.Name = "cLabel_wcoY";
            this.cLabel_wcoY.OverrideFontSize = 12F;
            this.cLabel_wcoY.Size = new System.Drawing.Size(85, 20);
            this.cLabel_wcoY.TabIndex = 40;
            this.cLabel_wcoY.Text = "000.000";
            this.cLabel_wcoY.TextStyle = CCL.eTextStyle.Medium;
            this.cLabel_wcoY.UseFontSizeOverride = false;
            // 
            // cLabel_wcoX
            // 
            this.cLabel_wcoX.AutoSize = true;
            this.cLabel_wcoX.BackColor = System.Drawing.Color.Transparent;
            this.cLabel_wcoX.Font = new System.Drawing.Font("Armata", 12F);
            this.cLabel_wcoX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cLabel_wcoX.Location = new System.Drawing.Point(325, 116);
            this.cLabel_wcoX.Name = "cLabel_wcoX";
            this.cLabel_wcoX.OverrideFontSize = 12F;
            this.cLabel_wcoX.Size = new System.Drawing.Size(85, 20);
            this.cLabel_wcoX.TabIndex = 39;
            this.cLabel_wcoX.Text = "000.000";
            this.cLabel_wcoX.TextStyle = CCL.eTextStyle.Medium;
            this.cLabel_wcoX.UseFontSizeOverride = false;
            // 
            // cLabel8
            // 
            this.cLabel8.AutoSize = true;
            this.cLabel8.BackColor = System.Drawing.Color.Transparent;
            this.cLabel8.Font = new System.Drawing.Font("Armata", 16F, System.Drawing.FontStyle.Bold);
            this.cLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cLabel8.Location = new System.Drawing.Point(324, 82);
            this.cLabel8.Name = "cLabel8";
            this.cLabel8.OverrideFontSize = 12F;
            this.cLabel8.Size = new System.Drawing.Size(66, 27);
            this.cLabel8.TabIndex = 38;
            this.cLabel8.Text = "WCO";
            this.cLabel8.TextStyle = CCL.eTextStyle.Title3;
            this.cLabel8.UseFontSizeOverride = false;
            // 
            // cCheckBox_showQuery
            // 
            this.cCheckBox_showQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cCheckBox_showQuery.AutoSize = true;
            this.cCheckBox_showQuery.CheckBoxHeight = 18;
            this.cCheckBox_showQuery.Enabled = false;
            this.cCheckBox_showQuery.Font = new System.Drawing.Font("Armata", 10F);
            this.cCheckBox_showQuery.Location = new System.Drawing.Point(6, 609);
            this.cCheckBox_showQuery.Name = "cCheckBox_showQuery";
            this.cCheckBox_showQuery.Size = new System.Drawing.Size(111, 22);
            this.cCheckBox_showQuery.TabIndex = 37;
            this.cCheckBox_showQuery.Text = "Show Query";
            this.cCheckBox_showQuery.TextStyle = CCL.eTextStyle.Normal;
            this.cCheckBox_showQuery.TextYOffset = 0;
            this.cCheckBox_showQuery.Underline = false;
            this.cCheckBox_showQuery.UnderlineYOffset = 0;
            this.cCheckBox_showQuery.UseVisualStyleBackColor = true;
            this.cCheckBox_showQuery.CheckedChanged += new System.EventHandler(this.cCheckBox_showQuery_CheckedChanged);
            // 
            // cButton_sendCommand
            // 
            this.cButton_sendCommand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cButton_sendCommand.DrawBorder = true;
            this.cButton_sendCommand.Enabled = false;
            this.cButton_sendCommand.Font = new System.Drawing.Font("Armata", 12F);
            this.cButton_sendCommand.Location = new System.Drawing.Point(220, 587);
            this.cButton_sendCommand.Name = "cButton_sendCommand";
            this.cButton_sendCommand.Size = new System.Drawing.Size(92, 21);
            this.cButton_sendCommand.TabIndex = 36;
            this.cButton_sendCommand.Text = "SEND";
            this.cButton_sendCommand.TextStyle = CCL.eTextStyle.Medium;
            this.cButton_sendCommand.UseVisualStyleBackColor = true;
            this.cButton_sendCommand.Click += new System.EventHandler(this.cButton_sendCommand_Click);
            // 
            // cTextBox_command
            // 
            this.cTextBox_command.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cTextBox_command.Depth = 0;
            this.cTextBox_command.Enabled = false;
            this.cTextBox_command.Font = new System.Drawing.Font("Armata", 12F);
            this.cTextBox_command.Hint = "Command...";
            this.cTextBox_command.LineHeight = 1;
            this.cTextBox_command.Location = new System.Drawing.Point(6, 587);
            this.cTextBox_command.MaxLength = 32767;
            this.cTextBox_command.MouseState = CCL.MouseState.HOVER;
            this.cTextBox_command.Name = "cTextBox_command";
            this.cTextBox_command.PasswordChar = '\0';
            this.cTextBox_command.SelectedText = "";
            this.cTextBox_command.SelectionLength = 0;
            this.cTextBox_command.SelectionStart = 0;
            this.cTextBox_command.Size = new System.Drawing.Size(208, 21);
            this.cTextBox_command.TabIndex = 35;
            this.cTextBox_command.TabStop = false;
            this.cTextBox_command.TextStyle = CCL.eTextStyle.Medium;
            this.cTextBox_command.UseSystemPasswordChar = false;
            this.cTextBox_command.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cTextBox_command_KeyDown);
            // 
            // cRichTextBox1
            // 
            this.cRichTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cRichTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.cRichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cRichTextBox1.Font = new System.Drawing.Font("Armata", 10F);
            this.cRichTextBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cRichTextBox1.Location = new System.Drawing.Point(6, 395);
            this.cRichTextBox1.Name = "cRichTextBox1";
            this.cRichTextBox1.ReadOnly = true;
            this.cRichTextBox1.Size = new System.Drawing.Size(404, 186);
            this.cRichTextBox1.TabIndex = 34;
            this.cRichTextBox1.Text = "";
            this.cRichTextBox1.TextStyle = CCL.eTextStyle.Normal;
            // 
            // cLabel_machineState
            // 
            this.cLabel_machineState.BackColor = System.Drawing.Color.Transparent;
            this.cLabel_machineState.Font = new System.Drawing.Font("Armata", 20F, System.Drawing.FontStyle.Bold);
            this.cLabel_machineState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cLabel_machineState.Location = new System.Drawing.Point(6, 34);
            this.cLabel_machineState.Name = "cLabel_machineState";
            this.cLabel_machineState.OverrideFontSize = 12F;
            this.cLabel_machineState.Size = new System.Drawing.Size(404, 48);
            this.cLabel_machineState.TabIndex = 33;
            this.cLabel_machineState.Text = "No Connection";
            this.cLabel_machineState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cLabel_machineState.TextStyle = CCL.eTextStyle.Title1;
            this.cLabel_machineState.UseFontSizeOverride = false;
            // 
            // cTabControl2
            // 
            this.cTabControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cTabControl2.Controls.Add(this.tabPage_move);
            this.cTabControl2.Controls.Add(this.tabPage_spindle);
            this.cTabControl2.Controls.Add(this.tabPage_override);
            this.cTabControl2.Controls.Add(this.tabPage_file);
            this.cTabControl2.Location = new System.Drawing.Point(416, 34);
            this.cTabControl2.Name = "cTabControl2";
            this.cTabControl2.SelectedIndex = 0;
            this.cTabControl2.Size = new System.Drawing.Size(383, 597);
            this.cTabControl2.TabIndex = 29;
            // 
            // tabPage_move
            // 
            this.tabPage_move.BackColor = System.Drawing.Color.Silver;
            this.tabPage_move.Controls.Add(this.cPanel_manualMove);
            this.tabPage_move.Location = new System.Drawing.Point(4, 22);
            this.tabPage_move.Name = "tabPage_move";
            this.tabPage_move.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_move.Size = new System.Drawing.Size(375, 571);
            this.tabPage_move.TabIndex = 0;
            this.tabPage_move.Text = "Move";
            // 
            // cPanel_manualMove
            // 
            this.cPanel_manualMove.Controls.Add(this.cCheckBox_lockX);
            this.cPanel_manualMove.Controls.Add(this.cCheckBox_lockY);
            this.cPanel_manualMove.Controls.Add(this.joggingKnob1);
            this.cPanel_manualMove.Controls.Add(this.cLabel7);
            this.cPanel_manualMove.Controls.Add(this.cDropDown_workSpace);
            this.cPanel_manualMove.Controls.Add(this.cRadioButton_g1);
            this.cPanel_manualMove.Controls.Add(this.cRadioButton_g0);
            this.cPanel_manualMove.Controls.Add(this.cLabel6);
            this.cPanel_manualMove.Controls.Add(this.cLabel5);
            this.cPanel_manualMove.Controls.Add(this.cTextBox_feedRate);
            this.cPanel_manualMove.Controls.Add(this.cTextBox_distance);
            this.cPanel_manualMove.Controls.Add(this.cButton_XmYp);
            this.cPanel_manualMove.Controls.Add(this.cButton_Zm);
            this.cPanel_manualMove.Controls.Add(this.cButton_Ym);
            this.cPanel_manualMove.Controls.Add(this.cButton_ZZero);
            this.cPanel_manualMove.Controls.Add(this.cButton_XpYm);
            this.cPanel_manualMove.Controls.Add(this.cButton_Zp);
            this.cPanel_manualMove.Controls.Add(this.cButton_XmYm);
            this.cPanel_manualMove.Controls.Add(this.cButton_XpYp);
            this.cPanel_manualMove.Controls.Add(this.cButton_Xp);
            this.cPanel_manualMove.Controls.Add(this.cButton_Yp);
            this.cPanel_manualMove.Controls.Add(this.cButton_XYZero);
            this.cPanel_manualMove.Controls.Add(this.cButton_Xm);
            this.cPanel_manualMove.DrawBorder = true;
            this.cPanel_manualMove.Enabled = false;
            this.cPanel_manualMove.Location = new System.Drawing.Point(6, 3);
            this.cPanel_manualMove.Name = "cPanel_manualMove";
            this.cPanel_manualMove.Size = new System.Drawing.Size(363, 562);
            this.cPanel_manualMove.TabIndex = 52;
            // 
            // cCheckBox_lockX
            // 
            this.cCheckBox_lockX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cCheckBox_lockX.AutoSize = true;
            this.cCheckBox_lockX.CheckBoxHeight = 18;
            this.cCheckBox_lockX.Enabled = false;
            this.cCheckBox_lockX.Font = new System.Drawing.Font("Armata", 10F);
            this.cCheckBox_lockX.Location = new System.Drawing.Point(101, 502);
            this.cCheckBox_lockX.Name = "cCheckBox_lockX";
            this.cCheckBox_lockX.Size = new System.Drawing.Size(71, 22);
            this.cCheckBox_lockX.TabIndex = 62;
            this.cCheckBox_lockX.Text = "Lock X";
            this.cCheckBox_lockX.TextStyle = CCL.eTextStyle.Normal;
            this.cCheckBox_lockX.TextYOffset = 0;
            this.cCheckBox_lockX.Underline = false;
            this.cCheckBox_lockX.UnderlineYOffset = 0;
            this.cCheckBox_lockX.UseVisualStyleBackColor = true;
            // 
            // cCheckBox_lockY
            // 
            this.cCheckBox_lockY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cCheckBox_lockY.AutoSize = true;
            this.cCheckBox_lockY.CheckBoxHeight = 18;
            this.cCheckBox_lockY.Enabled = false;
            this.cCheckBox_lockY.Font = new System.Drawing.Font("Armata", 10F);
            this.cCheckBox_lockY.Location = new System.Drawing.Point(191, 502);
            this.cCheckBox_lockY.Name = "cCheckBox_lockY";
            this.cCheckBox_lockY.Size = new System.Drawing.Size(70, 22);
            this.cCheckBox_lockY.TabIndex = 61;
            this.cCheckBox_lockY.Text = "Lock Y";
            this.cCheckBox_lockY.TextStyle = CCL.eTextStyle.Normal;
            this.cCheckBox_lockY.TextYOffset = 0;
            this.cCheckBox_lockY.Underline = false;
            this.cCheckBox_lockY.UnderlineYOffset = 0;
            this.cCheckBox_lockY.UseVisualStyleBackColor = true;
            // 
            // joggingKnob1
            // 
            this.joggingKnob1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.joggingKnob1.Enabled = false;
            this.joggingKnob1.Location = new System.Drawing.Point(101, 336);
            this.joggingKnob1.Name = "joggingKnob1";
            this.joggingKnob1.Size = new System.Drawing.Size(160, 160);
            this.joggingKnob1.TabIndex = 60;
            this.joggingKnob1.Text = "joggingKnob1";
            // 
            // cLabel7
            // 
            this.cLabel7.AutoSize = true;
            this.cLabel7.BackColor = System.Drawing.Color.Transparent;
            this.cLabel7.Font = new System.Drawing.Font("Armata", 10F);
            this.cLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cLabel7.Location = new System.Drawing.Point(75, 275);
            this.cLabel7.Name = "cLabel7";
            this.cLabel7.OverrideFontSize = 12F;
            this.cLabel7.Size = new System.Drawing.Size(91, 18);
            this.cLabel7.TabIndex = 59;
            this.cLabel7.Text = "Work space";
            this.cLabel7.TextStyle = CCL.eTextStyle.Normal;
            this.cLabel7.UseFontSizeOverride = false;
            // 
            // cDropDown_workSpace
            // 
            this.cDropDown_workSpace.Font = new System.Drawing.Font("Armata", 10F);
            this.cDropDown_workSpace.Items.Add("G54");
            this.cDropDown_workSpace.Items.Add("G55");
            this.cDropDown_workSpace.Items.Add("G56");
            this.cDropDown_workSpace.Items.Add("G57");
            this.cDropDown_workSpace.Items.Add("G58");
            this.cDropDown_workSpace.Items.Add("G59");
            this.cDropDown_workSpace.Location = new System.Drawing.Point(173, 272);
            this.cDropDown_workSpace.Name = "cDropDown_workSpace";
            this.cDropDown_workSpace.SelectedIndex = -1;
            this.cDropDown_workSpace.Size = new System.Drawing.Size(114, 25);
            this.cDropDown_workSpace.TabIndex = 58;
            this.cDropDown_workSpace.Text = "cDropDown1";
            this.cDropDown_workSpace.TextStyle = CCL.eTextStyle.Normal;
            // 
            // cRadioButton_g1
            // 
            this.cRadioButton_g1.BackColor = System.Drawing.Color.Transparent;
            this.cRadioButton_g1.CheckMarkSize = 10;
            this.cRadioButton_g1.Font = new System.Drawing.Font("Armata", 10F);
            this.cRadioButton_g1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cRadioButton_g1.Location = new System.Drawing.Point(255, 229);
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
            this.cRadioButton_g0.Location = new System.Drawing.Point(255, 205);
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
            this.cLabel6.Location = new System.Drawing.Point(49, 202);
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
            this.cLabel5.Location = new System.Drawing.Point(49, 226);
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
            this.cTextBox_feedRate.Location = new System.Drawing.Point(127, 226);
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
            this.cTextBox_feedRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cTextBox_feedRate_KeyPress);
            // 
            // cTextBox_distance
            // 
            this.cTextBox_distance.Depth = 0;
            this.cTextBox_distance.Font = new System.Drawing.Font("Armata", 10F);
            this.cTextBox_distance.Hint = "";
            this.cTextBox_distance.LineHeight = 1;
            this.cTextBox_distance.Location = new System.Drawing.Point(127, 202);
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
            this.cTextBox_distance.Text = "50";
            this.cTextBox_distance.TextStyle = CCL.eTextStyle.Normal;
            this.cTextBox_distance.UseSystemPasswordChar = false;
            this.cTextBox_distance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cTextBox_distance_KeyPress);
            // 
            // cButton_XmYp
            // 
            this.cButton_XmYp.BackgroundImage = global::CNCV.Properties.Resources.ArrowUpLeft;
            this.cButton_XmYp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cButton_XmYp.DrawBorder = false;
            this.cButton_XmYp.Font = new System.Drawing.Font("Armata", 12F, System.Drawing.FontStyle.Bold);
            this.cButton_XmYp.Location = new System.Drawing.Point(52, 8);
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
            this.cButton_Zm.Location = new System.Drawing.Point(256, 130);
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
            this.cButton_Ym.Location = new System.Drawing.Point(113, 131);
            this.cButton_Ym.Name = "cButton_Ym";
            this.cButton_Ym.Size = new System.Drawing.Size(55, 55);
            this.cButton_Ym.TabIndex = 40;
            this.cButton_Ym.TextStyle = CCL.eTextStyle.Title5;
            this.cButton_Ym.UseVisualStyleBackColor = true;
            this.cButton_Ym.Click += new System.EventHandler(this.cButton_Ym_Click);
            // 
            // cButton_ZZero
            // 
            this.cButton_ZZero.BackgroundImage = global::CNCV.Properties.Resources.ZeroSmall;
            this.cButton_ZZero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cButton_ZZero.DrawBorder = false;
            this.cButton_ZZero.Font = new System.Drawing.Font("Armata", 12F, System.Drawing.FontStyle.Bold);
            this.cButton_ZZero.Location = new System.Drawing.Point(256, 69);
            this.cButton_ZZero.Name = "cButton_ZZero";
            this.cButton_ZZero.Size = new System.Drawing.Size(55, 55);
            this.cButton_ZZero.TabIndex = 50;
            this.cButton_ZZero.TextStyle = CCL.eTextStyle.Title5;
            this.cButton_ZZero.UseVisualStyleBackColor = true;
            this.cButton_ZZero.Click += new System.EventHandler(this.cButton_ZZero_Click);
            // 
            // cButton_XpYm
            // 
            this.cButton_XpYm.BackgroundImage = global::CNCV.Properties.Resources.ArrowDownRight;
            this.cButton_XpYm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cButton_XpYm.DrawBorder = false;
            this.cButton_XpYm.Font = new System.Drawing.Font("Armata", 12F, System.Drawing.FontStyle.Bold);
            this.cButton_XpYm.Location = new System.Drawing.Point(174, 131);
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
            this.cButton_Zp.Location = new System.Drawing.Point(256, 8);
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
            this.cButton_XmYm.Location = new System.Drawing.Point(52, 131);
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
            this.cButton_XpYp.Location = new System.Drawing.Point(174, 8);
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
            this.cButton_Xp.Location = new System.Drawing.Point(174, 69);
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
            this.cButton_Yp.Location = new System.Drawing.Point(113, 8);
            this.cButton_Yp.Name = "cButton_Yp";
            this.cButton_Yp.Size = new System.Drawing.Size(55, 55);
            this.cButton_Yp.TabIndex = 47;
            this.cButton_Yp.TextStyle = CCL.eTextStyle.Title5;
            this.cButton_Yp.UseVisualStyleBackColor = true;
            this.cButton_Yp.Click += new System.EventHandler(this.cButton_Yp_Click);
            // 
            // cButton_XYZero
            // 
            this.cButton_XYZero.BackgroundImage = global::CNCV.Properties.Resources.ZeroSmall;
            this.cButton_XYZero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cButton_XYZero.DrawBorder = false;
            this.cButton_XYZero.Font = new System.Drawing.Font("Armata", 12F, System.Drawing.FontStyle.Bold);
            this.cButton_XYZero.Location = new System.Drawing.Point(113, 69);
            this.cButton_XYZero.Name = "cButton_XYZero";
            this.cButton_XYZero.Size = new System.Drawing.Size(55, 55);
            this.cButton_XYZero.TabIndex = 44;
            this.cButton_XYZero.TextStyle = CCL.eTextStyle.Title5;
            this.cButton_XYZero.UseVisualStyleBackColor = true;
            this.cButton_XYZero.Click += new System.EventHandler(this.cButton_XYZero_Click);
            // 
            // cButton_Xm
            // 
            this.cButton_Xm.BackgroundImage = global::CNCV.Properties.Resources.ArrowLeft;
            this.cButton_Xm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cButton_Xm.DrawBorder = false;
            this.cButton_Xm.Font = new System.Drawing.Font("Armata", 12F, System.Drawing.FontStyle.Bold);
            this.cButton_Xm.Location = new System.Drawing.Point(52, 69);
            this.cButton_Xm.Name = "cButton_Xm";
            this.cButton_Xm.Size = new System.Drawing.Size(55, 55);
            this.cButton_Xm.TabIndex = 45;
            this.cButton_Xm.TextStyle = CCL.eTextStyle.Title5;
            this.cButton_Xm.UseVisualStyleBackColor = true;
            this.cButton_Xm.Click += new System.EventHandler(this.cButton_Xm_Click);
            // 
            // tabPage_spindle
            // 
            this.tabPage_spindle.BackColor = System.Drawing.Color.Silver;
            this.tabPage_spindle.Controls.Add(this.cTabControl_spindleLaser);
            this.tabPage_spindle.Location = new System.Drawing.Point(4, 22);
            this.tabPage_spindle.Name = "tabPage_spindle";
            this.tabPage_spindle.Size = new System.Drawing.Size(375, 571);
            this.tabPage_spindle.TabIndex = 2;
            this.tabPage_spindle.Text = "Spindle";
            // 
            // cTabControl_spindleLaser
            // 
            this.cTabControl_spindleLaser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cTabControl_spindleLaser.Controls.Add(this.tabPage_spindleControls);
            this.cTabControl_spindleLaser.Controls.Add(this.tabPage_laserControls);
            this.cTabControl_spindleLaser.Location = new System.Drawing.Point(3, 3);
            this.cTabControl_spindleLaser.Name = "cTabControl_spindleLaser";
            this.cTabControl_spindleLaser.SelectedIndex = 0;
            this.cTabControl_spindleLaser.Size = new System.Drawing.Size(369, 565);
            this.cTabControl_spindleLaser.TabIndex = 22;
            // 
            // tabPage_spindleControls
            // 
            this.tabPage_spindleControls.BackColor = System.Drawing.Color.Silver;
            this.tabPage_spindleControls.Controls.Add(this.cLabel14);
            this.tabPage_spindleControls.Controls.Add(this.cLabel10);
            this.tabPage_spindleControls.Controls.Add(this.cLabel9);
            this.tabPage_spindleControls.Controls.Add(this.cButton_touchThePlate);
            this.tabPage_spindleControls.Controls.Add(this.cSwitch_enableSpindle);
            this.tabPage_spindleControls.Location = new System.Drawing.Point(4, 22);
            this.tabPage_spindleControls.Name = "tabPage_spindleControls";
            this.tabPage_spindleControls.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_spindleControls.Size = new System.Drawing.Size(361, 539);
            this.tabPage_spindleControls.TabIndex = 0;
            this.tabPage_spindleControls.Text = "Spindle";
            // 
            // cLabel14
            // 
            this.cLabel14.AutoSize = true;
            this.cLabel14.BackColor = System.Drawing.Color.Transparent;
            this.cLabel14.Font = new System.Drawing.Font("Armata", 12F);
            this.cLabel14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cLabel14.Location = new System.Drawing.Point(129, 53);
            this.cLabel14.Name = "cLabel14";
            this.cLabel14.OverrideFontSize = 12F;
            this.cLabel14.Size = new System.Drawing.Size(101, 20);
            this.cLabel14.TabIndex = 45;
            this.cLabel14.Text = "Slider here";
            this.cLabel14.TextStyle = CCL.eTextStyle.Medium;
            this.cLabel14.UseFontSizeOverride = false;
            // 
            // cLabel10
            // 
            this.cLabel10.AutoSize = true;
            this.cLabel10.BackColor = System.Drawing.Color.Transparent;
            this.cLabel10.Font = new System.Drawing.Font("Armata", 12F);
            this.cLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cLabel10.Location = new System.Drawing.Point(272, 53);
            this.cLabel10.Name = "cLabel10";
            this.cLabel10.OverrideFontSize = 12F;
            this.cLabel10.Size = new System.Drawing.Size(69, 20);
            this.cLabel10.TabIndex = 44;
            this.cLabel10.Text = "00000";
            this.cLabel10.TextStyle = CCL.eTextStyle.Medium;
            this.cLabel10.UseFontSizeOverride = false;
            // 
            // cLabel9
            // 
            this.cLabel9.AutoSize = true;
            this.cLabel9.BackColor = System.Drawing.Color.Transparent;
            this.cLabel9.Font = new System.Drawing.Font("Armata", 12F);
            this.cLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cLabel9.Location = new System.Drawing.Point(21, 53);
            this.cLabel9.Name = "cLabel9";
            this.cLabel9.OverrideFontSize = 12F;
            this.cLabel9.Size = new System.Drawing.Size(47, 20);
            this.cLabel9.TabIndex = 43;
            this.cLabel9.Text = "RPM";
            this.cLabel9.TextStyle = CCL.eTextStyle.Medium;
            this.cLabel9.UseFontSizeOverride = false;
            // 
            // cButton_touchThePlate
            // 
            this.cButton_touchThePlate.DrawBorder = true;
            this.cButton_touchThePlate.Enabled = false;
            this.cButton_touchThePlate.Font = new System.Drawing.Font("Armata", 12F, System.Drawing.FontStyle.Bold);
            this.cButton_touchThePlate.Location = new System.Drawing.Point(110, 139);
            this.cButton_touchThePlate.Name = "cButton_touchThePlate";
            this.cButton_touchThePlate.Size = new System.Drawing.Size(140, 47);
            this.cButton_touchThePlate.TabIndex = 22;
            this.cButton_touchThePlate.Text = "Touch the plate";
            this.cButton_touchThePlate.TextStyle = CCL.eTextStyle.Title5;
            this.cButton_touchThePlate.UseVisualStyleBackColor = true;
            this.cButton_touchThePlate.Click += new System.EventHandler(this.cButton_touchThePlate_Click);
            // 
            // cSwitch_enableSpindle
            // 
            this.cSwitch_enableSpindle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.cSwitch_enableSpindle.CircleSize = 20;
            this.cSwitch_enableSpindle.Enabled = false;
            this.cSwitch_enableSpindle.Font = new System.Drawing.Font("Armata", 10F);
            this.cSwitch_enableSpindle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cSwitch_enableSpindle.IsOn = false;
            this.cSwitch_enableSpindle.Location = new System.Drawing.Point(98, 4);
            this.cSwitch_enableSpindle.Name = "cSwitch_enableSpindle";
            this.cSwitch_enableSpindle.OffIcon = ((System.Drawing.Image)(resources.GetObject("cSwitch_enableSpindle.OffIcon")));
            this.cSwitch_enableSpindle.OnIcon = ((System.Drawing.Image)(resources.GetObject("cSwitch_enableSpindle.OnIcon")));
            this.cSwitch_enableSpindle.Size = new System.Drawing.Size(165, 25);
            this.cSwitch_enableSpindle.SwitchSize = new System.Drawing.Size(50, 25);
            this.cSwitch_enableSpindle.TabIndex = 3;
            this.cSwitch_enableSpindle.Text = "Enable Spindle";
            this.cSwitch_enableSpindle.TextStyle = CCL.eTextStyle.Normal;
            this.cSwitch_enableSpindle.UseIcons = false;
            this.cSwitch_enableSpindle.Click += new System.EventHandler(this.cSwitch_enableSpindle_Click);
            // 
            // tabPage_laserControls
            // 
            this.tabPage_laserControls.BackColor = System.Drawing.Color.Silver;
            this.tabPage_laserControls.Controls.Add(this.cSwitch_enableStrongLaser);
            this.tabPage_laserControls.Controls.Add(this.cButton_showLaserArea);
            this.tabPage_laserControls.Controls.Add(this.cSwitch_enableWeakLaser);
            this.tabPage_laserControls.Location = new System.Drawing.Point(4, 22);
            this.tabPage_laserControls.Name = "tabPage_laserControls";
            this.tabPage_laserControls.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_laserControls.Size = new System.Drawing.Size(361, 539);
            this.tabPage_laserControls.TabIndex = 1;
            this.tabPage_laserControls.Text = "Laser";
            // 
            // cSwitch_enableStrongLaser
            // 
            this.cSwitch_enableStrongLaser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.cSwitch_enableStrongLaser.CircleSize = 20;
            this.cSwitch_enableStrongLaser.Enabled = false;
            this.cSwitch_enableStrongLaser.Font = new System.Drawing.Font("Armata", 10F);
            this.cSwitch_enableStrongLaser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cSwitch_enableStrongLaser.IsOn = false;
            this.cSwitch_enableStrongLaser.Location = new System.Drawing.Point(6, 4);
            this.cSwitch_enableStrongLaser.Name = "cSwitch_enableStrongLaser";
            this.cSwitch_enableStrongLaser.OffIcon = ((System.Drawing.Image)(resources.GetObject("cSwitch_enableStrongLaser.OffIcon")));
            this.cSwitch_enableStrongLaser.OnIcon = ((System.Drawing.Image)(resources.GetObject("cSwitch_enableStrongLaser.OnIcon")));
            this.cSwitch_enableStrongLaser.Size = new System.Drawing.Size(201, 25);
            this.cSwitch_enableStrongLaser.SwitchSize = new System.Drawing.Size(50, 25);
            this.cSwitch_enableStrongLaser.TabIndex = 2;
            this.cSwitch_enableStrongLaser.Text = "Enable Strong Laser";
            this.cSwitch_enableStrongLaser.TextStyle = CCL.eTextStyle.Normal;
            this.cSwitch_enableStrongLaser.UseIcons = false;
            // 
            // cButton_showLaserArea
            // 
            this.cButton_showLaserArea.DrawBorder = true;
            this.cButton_showLaserArea.Font = new System.Drawing.Font("Armata", 12F, System.Drawing.FontStyle.Bold);
            this.cButton_showLaserArea.Location = new System.Drawing.Point(6, 83);
            this.cButton_showLaserArea.Name = "cButton_showLaserArea";
            this.cButton_showLaserArea.Size = new System.Drawing.Size(140, 35);
            this.cButton_showLaserArea.TabIndex = 21;
            this.cButton_showLaserArea.Text = "Show Area";
            this.cButton_showLaserArea.TextStyle = CCL.eTextStyle.Title5;
            this.cButton_showLaserArea.UseVisualStyleBackColor = true;
            // 
            // cSwitch_enableWeakLaser
            // 
            this.cSwitch_enableWeakLaser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.cSwitch_enableWeakLaser.CircleSize = 20;
            this.cSwitch_enableWeakLaser.Enabled = false;
            this.cSwitch_enableWeakLaser.Font = new System.Drawing.Font("Armata", 10F);
            this.cSwitch_enableWeakLaser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cSwitch_enableWeakLaser.IsOn = false;
            this.cSwitch_enableWeakLaser.Location = new System.Drawing.Point(6, 35);
            this.cSwitch_enableWeakLaser.Name = "cSwitch_enableWeakLaser";
            this.cSwitch_enableWeakLaser.OffIcon = ((System.Drawing.Image)(resources.GetObject("cSwitch_enableWeakLaser.OffIcon")));
            this.cSwitch_enableWeakLaser.OnIcon = ((System.Drawing.Image)(resources.GetObject("cSwitch_enableWeakLaser.OnIcon")));
            this.cSwitch_enableWeakLaser.Size = new System.Drawing.Size(194, 25);
            this.cSwitch_enableWeakLaser.SwitchSize = new System.Drawing.Size(50, 25);
            this.cSwitch_enableWeakLaser.TabIndex = 3;
            this.cSwitch_enableWeakLaser.Text = "Enable Weak Laser";
            this.cSwitch_enableWeakLaser.TextStyle = CCL.eTextStyle.Normal;
            this.cSwitch_enableWeakLaser.UseIcons = false;
            // 
            // tabPage_override
            // 
            this.tabPage_override.BackColor = System.Drawing.Color.Silver;
            this.tabPage_override.Controls.Add(this.cGroupBox_overrideRapid);
            this.tabPage_override.Controls.Add(this.cGroupBox_overrideSpindle);
            this.tabPage_override.Controls.Add(this.cGroupBox_overrideFeed);
            this.tabPage_override.Location = new System.Drawing.Point(4, 22);
            this.tabPage_override.Name = "tabPage_override";
            this.tabPage_override.Size = new System.Drawing.Size(375, 571);
            this.tabPage_override.TabIndex = 3;
            this.tabPage_override.Text = "Override";
            // 
            // cGroupBox_overrideRapid
            // 
            this.cGroupBox_overrideRapid.Controls.Add(this.cLabel_overrideRapid);
            this.cGroupBox_overrideRapid.Controls.Add(this.cRadioButton_overrideRapidQuarter);
            this.cGroupBox_overrideRapid.Controls.Add(this.cRadioButton_overrideRapidHalf);
            this.cGroupBox_overrideRapid.Controls.Add(this.cRadioButton_overrideRapidFull);
            this.cGroupBox_overrideRapid.Enabled = false;
            this.cGroupBox_overrideRapid.Font = new System.Drawing.Font("Armata", 10F);
            this.cGroupBox_overrideRapid.Location = new System.Drawing.Point(45, 169);
            this.cGroupBox_overrideRapid.Name = "cGroupBox_overrideRapid";
            this.cGroupBox_overrideRapid.Radius = 25;
            this.cGroupBox_overrideRapid.Size = new System.Drawing.Size(284, 50);
            this.cGroupBox_overrideRapid.TabIndex = 40;
            this.cGroupBox_overrideRapid.TabStop = false;
            this.cGroupBox_overrideRapid.Text = "RAPID";
            this.cGroupBox_overrideRapid.TextAlignment = System.Drawing.StringAlignment.Center;
            this.cGroupBox_overrideRapid.TextStyle = CCL.eTextStyle.Normal;
            // 
            // cLabel_overrideRapid
            // 
            this.cLabel_overrideRapid.AutoSize = true;
            this.cLabel_overrideRapid.BackColor = System.Drawing.Color.Transparent;
            this.cLabel_overrideRapid.Font = new System.Drawing.Font("Armata", 12F);
            this.cLabel_overrideRapid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cLabel_overrideRapid.Location = new System.Drawing.Point(6, 15);
            this.cLabel_overrideRapid.Name = "cLabel_overrideRapid";
            this.cLabel_overrideRapid.OverrideFontSize = 12F;
            this.cLabel_overrideRapid.Size = new System.Drawing.Size(45, 20);
            this.cLabel_overrideRapid.TabIndex = 43;
            this.cLabel_overrideRapid.Text = "000";
            this.cLabel_overrideRapid.TextStyle = CCL.eTextStyle.Medium;
            this.cLabel_overrideRapid.UseFontSizeOverride = false;
            // 
            // cRadioButton_overrideRapidQuarter
            // 
            this.cRadioButton_overrideRapidQuarter.BackColor = System.Drawing.Color.Transparent;
            this.cRadioButton_overrideRapidQuarter.CheckMarkSize = 10;
            this.cRadioButton_overrideRapidQuarter.Font = new System.Drawing.Font("Armata", 10F);
            this.cRadioButton_overrideRapidQuarter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cRadioButton_overrideRapidQuarter.Location = new System.Drawing.Point(200, 23);
            this.cRadioButton_overrideRapidQuarter.Name = "cRadioButton_overrideRapidQuarter";
            this.cRadioButton_overrideRapidQuarter.RadioButtonHeight = 18;
            this.cRadioButton_overrideRapidQuarter.Size = new System.Drawing.Size(43, 18);
            this.cRadioButton_overrideRapidQuarter.TabIndex = 2;
            this.cRadioButton_overrideRapidQuarter.Text = "25";
            this.cRadioButton_overrideRapidQuarter.TextStyle = CCL.eTextStyle.Normal;
            this.cRadioButton_overrideRapidQuarter.UseVisualStyleBackColor = false;
            this.cRadioButton_overrideRapidQuarter.CheckedChanged += new System.EventHandler(this.cRadioButton_overrideRapidQuarter_CheckedChanged);
            // 
            // cRadioButton_overrideRapidHalf
            // 
            this.cRadioButton_overrideRapidHalf.BackColor = System.Drawing.Color.Transparent;
            this.cRadioButton_overrideRapidHalf.CheckMarkSize = 10;
            this.cRadioButton_overrideRapidHalf.Font = new System.Drawing.Font("Armata", 10F);
            this.cRadioButton_overrideRapidHalf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cRadioButton_overrideRapidHalf.Location = new System.Drawing.Point(149, 23);
            this.cRadioButton_overrideRapidHalf.Name = "cRadioButton_overrideRapidHalf";
            this.cRadioButton_overrideRapidHalf.RadioButtonHeight = 18;
            this.cRadioButton_overrideRapidHalf.Size = new System.Drawing.Size(45, 18);
            this.cRadioButton_overrideRapidHalf.TabIndex = 1;
            this.cRadioButton_overrideRapidHalf.Text = "50";
            this.cRadioButton_overrideRapidHalf.TextStyle = CCL.eTextStyle.Normal;
            this.cRadioButton_overrideRapidHalf.UseVisualStyleBackColor = false;
            this.cRadioButton_overrideRapidHalf.CheckedChanged += new System.EventHandler(this.cRadioButton_overrideRapidHalf_CheckedChanged);
            // 
            // cRadioButton_overrideRapidFull
            // 
            this.cRadioButton_overrideRapidFull.BackColor = System.Drawing.Color.Transparent;
            this.cRadioButton_overrideRapidFull.Checked = true;
            this.cRadioButton_overrideRapidFull.CheckMarkSize = 10;
            this.cRadioButton_overrideRapidFull.Font = new System.Drawing.Font("Armata", 10F);
            this.cRadioButton_overrideRapidFull.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cRadioButton_overrideRapidFull.Location = new System.Drawing.Point(90, 23);
            this.cRadioButton_overrideRapidFull.Name = "cRadioButton_overrideRapidFull";
            this.cRadioButton_overrideRapidFull.RadioButtonHeight = 18;
            this.cRadioButton_overrideRapidFull.Size = new System.Drawing.Size(53, 18);
            this.cRadioButton_overrideRapidFull.TabIndex = 0;
            this.cRadioButton_overrideRapidFull.TabStop = true;
            this.cRadioButton_overrideRapidFull.Text = "100";
            this.cRadioButton_overrideRapidFull.TextStyle = CCL.eTextStyle.Normal;
            this.cRadioButton_overrideRapidFull.UseVisualStyleBackColor = false;
            this.cRadioButton_overrideRapidFull.CheckedChanged += new System.EventHandler(this.cRadioButton_overrideRapidFull_CheckedChanged);
            // 
            // cGroupBox_overrideSpindle
            // 
            this.cGroupBox_overrideSpindle.Controls.Add(this.cLabel_overrideSpindle);
            this.cGroupBox_overrideSpindle.Controls.Add(this.cButton_overrideSpindleReduce);
            this.cGroupBox_overrideSpindle.Controls.Add(this.cButton_overrideSpindleIncrease);
            this.cGroupBox_overrideSpindle.Controls.Add(this.cRadioButton_overrideSpindleAddTen);
            this.cGroupBox_overrideSpindle.Controls.Add(this.cRadioButton_overrideSpindleAddOne);
            this.cGroupBox_overrideSpindle.Enabled = false;
            this.cGroupBox_overrideSpindle.Font = new System.Drawing.Font("Armata", 10F);
            this.cGroupBox_overrideSpindle.Location = new System.Drawing.Point(45, 86);
            this.cGroupBox_overrideSpindle.Name = "cGroupBox_overrideSpindle";
            this.cGroupBox_overrideSpindle.Radius = 25;
            this.cGroupBox_overrideSpindle.Size = new System.Drawing.Size(284, 77);
            this.cGroupBox_overrideSpindle.TabIndex = 39;
            this.cGroupBox_overrideSpindle.TabStop = false;
            this.cGroupBox_overrideSpindle.Text = "SPINDLE";
            this.cGroupBox_overrideSpindle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.cGroupBox_overrideSpindle.TextStyle = CCL.eTextStyle.Normal;
            // 
            // cLabel_overrideSpindle
            // 
            this.cLabel_overrideSpindle.AutoSize = true;
            this.cLabel_overrideSpindle.BackColor = System.Drawing.Color.Transparent;
            this.cLabel_overrideSpindle.Font = new System.Drawing.Font("Armata", 12F);
            this.cLabel_overrideSpindle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cLabel_overrideSpindle.Location = new System.Drawing.Point(6, 28);
            this.cLabel_overrideSpindle.Name = "cLabel_overrideSpindle";
            this.cLabel_overrideSpindle.OverrideFontSize = 12F;
            this.cLabel_overrideSpindle.Size = new System.Drawing.Size(45, 20);
            this.cLabel_overrideSpindle.TabIndex = 44;
            this.cLabel_overrideSpindle.Text = "000";
            this.cLabel_overrideSpindle.TextStyle = CCL.eTextStyle.Medium;
            this.cLabel_overrideSpindle.UseFontSizeOverride = false;
            // 
            // cButton_overrideSpindleReduce
            // 
            this.cButton_overrideSpindleReduce.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cButton_overrideSpindleReduce.DrawBorder = true;
            this.cButton_overrideSpindleReduce.Font = new System.Drawing.Font("Armata", 12F);
            this.cButton_overrideSpindleReduce.Location = new System.Drawing.Point(145, 47);
            this.cButton_overrideSpindleReduce.Name = "cButton_overrideSpindleReduce";
            this.cButton_overrideSpindleReduce.Size = new System.Drawing.Size(123, 21);
            this.cButton_overrideSpindleReduce.TabIndex = 38;
            this.cButton_overrideSpindleReduce.Text = "REDUCE";
            this.cButton_overrideSpindleReduce.TextStyle = CCL.eTextStyle.Medium;
            this.cButton_overrideSpindleReduce.UseVisualStyleBackColor = true;
            this.cButton_overrideSpindleReduce.Click += new System.EventHandler(this.cButton_overrideSpindleReduce_Click);
            // 
            // cButton_overrideSpindleIncrease
            // 
            this.cButton_overrideSpindleIncrease.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cButton_overrideSpindleIncrease.DrawBorder = true;
            this.cButton_overrideSpindleIncrease.Font = new System.Drawing.Font("Armata", 12F);
            this.cButton_overrideSpindleIncrease.Location = new System.Drawing.Point(145, 23);
            this.cButton_overrideSpindleIncrease.Name = "cButton_overrideSpindleIncrease";
            this.cButton_overrideSpindleIncrease.Size = new System.Drawing.Size(123, 21);
            this.cButton_overrideSpindleIncrease.TabIndex = 37;
            this.cButton_overrideSpindleIncrease.Text = "INCREASE";
            this.cButton_overrideSpindleIncrease.TextStyle = CCL.eTextStyle.Medium;
            this.cButton_overrideSpindleIncrease.UseVisualStyleBackColor = true;
            this.cButton_overrideSpindleIncrease.Click += new System.EventHandler(this.cButton_overrideSpindleIncrease_Click);
            // 
            // cRadioButton_overrideSpindleAddTen
            // 
            this.cRadioButton_overrideSpindleAddTen.BackColor = System.Drawing.Color.Transparent;
            this.cRadioButton_overrideSpindleAddTen.CheckMarkSize = 10;
            this.cRadioButton_overrideSpindleAddTen.Font = new System.Drawing.Font("Armata", 10F);
            this.cRadioButton_overrideSpindleAddTen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cRadioButton_overrideSpindleAddTen.Location = new System.Drawing.Point(90, 50);
            this.cRadioButton_overrideSpindleAddTen.Name = "cRadioButton_overrideSpindleAddTen";
            this.cRadioButton_overrideSpindleAddTen.RadioButtonHeight = 18;
            this.cRadioButton_overrideSpindleAddTen.Size = new System.Drawing.Size(43, 18);
            this.cRadioButton_overrideSpindleAddTen.TabIndex = 1;
            this.cRadioButton_overrideSpindleAddTen.Text = "10";
            this.cRadioButton_overrideSpindleAddTen.TextStyle = CCL.eTextStyle.Normal;
            this.cRadioButton_overrideSpindleAddTen.UseVisualStyleBackColor = false;
            // 
            // cRadioButton_overrideSpindleAddOne
            // 
            this.cRadioButton_overrideSpindleAddOne.BackColor = System.Drawing.Color.Transparent;
            this.cRadioButton_overrideSpindleAddOne.Checked = true;
            this.cRadioButton_overrideSpindleAddOne.CheckMarkSize = 10;
            this.cRadioButton_overrideSpindleAddOne.Font = new System.Drawing.Font("Armata", 10F);
            this.cRadioButton_overrideSpindleAddOne.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cRadioButton_overrideSpindleAddOne.Location = new System.Drawing.Point(90, 23);
            this.cRadioButton_overrideSpindleAddOne.Name = "cRadioButton_overrideSpindleAddOne";
            this.cRadioButton_overrideSpindleAddOne.RadioButtonHeight = 18;
            this.cRadioButton_overrideSpindleAddOne.Size = new System.Drawing.Size(33, 18);
            this.cRadioButton_overrideSpindleAddOne.TabIndex = 0;
            this.cRadioButton_overrideSpindleAddOne.TabStop = true;
            this.cRadioButton_overrideSpindleAddOne.Text = "1";
            this.cRadioButton_overrideSpindleAddOne.TextStyle = CCL.eTextStyle.Normal;
            this.cRadioButton_overrideSpindleAddOne.UseVisualStyleBackColor = false;
            // 
            // cGroupBox_overrideFeed
            // 
            this.cGroupBox_overrideFeed.Controls.Add(this.cLabel_overrideFeed);
            this.cGroupBox_overrideFeed.Controls.Add(this.cButton_overrideFeedReduce);
            this.cGroupBox_overrideFeed.Controls.Add(this.cButton_overrideFeedIncrease);
            this.cGroupBox_overrideFeed.Controls.Add(this.cRadioButton_overrideFeedAddTen);
            this.cGroupBox_overrideFeed.Controls.Add(this.cRadioButton_overrideFeedAddOne);
            this.cGroupBox_overrideFeed.Enabled = false;
            this.cGroupBox_overrideFeed.Font = new System.Drawing.Font("Armata", 10F);
            this.cGroupBox_overrideFeed.Location = new System.Drawing.Point(45, 3);
            this.cGroupBox_overrideFeed.Name = "cGroupBox_overrideFeed";
            this.cGroupBox_overrideFeed.Radius = 25;
            this.cGroupBox_overrideFeed.Size = new System.Drawing.Size(284, 77);
            this.cGroupBox_overrideFeed.TabIndex = 0;
            this.cGroupBox_overrideFeed.TabStop = false;
            this.cGroupBox_overrideFeed.Text = "FEED RATE";
            this.cGroupBox_overrideFeed.TextAlignment = System.Drawing.StringAlignment.Center;
            this.cGroupBox_overrideFeed.TextStyle = CCL.eTextStyle.Normal;
            // 
            // cLabel_overrideFeed
            // 
            this.cLabel_overrideFeed.AutoSize = true;
            this.cLabel_overrideFeed.BackColor = System.Drawing.Color.Transparent;
            this.cLabel_overrideFeed.Font = new System.Drawing.Font("Armata", 12F);
            this.cLabel_overrideFeed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cLabel_overrideFeed.Location = new System.Drawing.Point(6, 28);
            this.cLabel_overrideFeed.Name = "cLabel_overrideFeed";
            this.cLabel_overrideFeed.OverrideFontSize = 12F;
            this.cLabel_overrideFeed.Size = new System.Drawing.Size(45, 20);
            this.cLabel_overrideFeed.TabIndex = 44;
            this.cLabel_overrideFeed.Text = "000";
            this.cLabel_overrideFeed.TextStyle = CCL.eTextStyle.Medium;
            this.cLabel_overrideFeed.UseFontSizeOverride = false;
            // 
            // cButton_overrideFeedReduce
            // 
            this.cButton_overrideFeedReduce.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cButton_overrideFeedReduce.DrawBorder = true;
            this.cButton_overrideFeedReduce.Font = new System.Drawing.Font("Armata", 12F);
            this.cButton_overrideFeedReduce.Location = new System.Drawing.Point(145, 47);
            this.cButton_overrideFeedReduce.Name = "cButton_overrideFeedReduce";
            this.cButton_overrideFeedReduce.Size = new System.Drawing.Size(123, 21);
            this.cButton_overrideFeedReduce.TabIndex = 38;
            this.cButton_overrideFeedReduce.Text = "REDUCE";
            this.cButton_overrideFeedReduce.TextStyle = CCL.eTextStyle.Medium;
            this.cButton_overrideFeedReduce.UseVisualStyleBackColor = true;
            this.cButton_overrideFeedReduce.Click += new System.EventHandler(this.cButton_overrideFeedReduce_Click);
            // 
            // cButton_overrideFeedIncrease
            // 
            this.cButton_overrideFeedIncrease.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cButton_overrideFeedIncrease.DrawBorder = true;
            this.cButton_overrideFeedIncrease.Font = new System.Drawing.Font("Armata", 12F);
            this.cButton_overrideFeedIncrease.Location = new System.Drawing.Point(145, 23);
            this.cButton_overrideFeedIncrease.Name = "cButton_overrideFeedIncrease";
            this.cButton_overrideFeedIncrease.Size = new System.Drawing.Size(123, 21);
            this.cButton_overrideFeedIncrease.TabIndex = 37;
            this.cButton_overrideFeedIncrease.Text = "INCREASE";
            this.cButton_overrideFeedIncrease.TextStyle = CCL.eTextStyle.Medium;
            this.cButton_overrideFeedIncrease.UseVisualStyleBackColor = true;
            this.cButton_overrideFeedIncrease.Click += new System.EventHandler(this.cButton_overrideFeedIncrease_Click);
            // 
            // cRadioButton_overrideFeedAddTen
            // 
            this.cRadioButton_overrideFeedAddTen.BackColor = System.Drawing.Color.Transparent;
            this.cRadioButton_overrideFeedAddTen.CheckMarkSize = 10;
            this.cRadioButton_overrideFeedAddTen.Font = new System.Drawing.Font("Armata", 10F);
            this.cRadioButton_overrideFeedAddTen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cRadioButton_overrideFeedAddTen.Location = new System.Drawing.Point(90, 50);
            this.cRadioButton_overrideFeedAddTen.Name = "cRadioButton_overrideFeedAddTen";
            this.cRadioButton_overrideFeedAddTen.RadioButtonHeight = 18;
            this.cRadioButton_overrideFeedAddTen.Size = new System.Drawing.Size(43, 18);
            this.cRadioButton_overrideFeedAddTen.TabIndex = 1;
            this.cRadioButton_overrideFeedAddTen.Text = "10";
            this.cRadioButton_overrideFeedAddTen.TextStyle = CCL.eTextStyle.Normal;
            this.cRadioButton_overrideFeedAddTen.UseVisualStyleBackColor = false;
            // 
            // cRadioButton_overrideFeedAddOne
            // 
            this.cRadioButton_overrideFeedAddOne.BackColor = System.Drawing.Color.Transparent;
            this.cRadioButton_overrideFeedAddOne.Checked = true;
            this.cRadioButton_overrideFeedAddOne.CheckMarkSize = 10;
            this.cRadioButton_overrideFeedAddOne.Font = new System.Drawing.Font("Armata", 10F);
            this.cRadioButton_overrideFeedAddOne.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cRadioButton_overrideFeedAddOne.Location = new System.Drawing.Point(90, 23);
            this.cRadioButton_overrideFeedAddOne.Name = "cRadioButton_overrideFeedAddOne";
            this.cRadioButton_overrideFeedAddOne.RadioButtonHeight = 18;
            this.cRadioButton_overrideFeedAddOne.Size = new System.Drawing.Size(33, 18);
            this.cRadioButton_overrideFeedAddOne.TabIndex = 0;
            this.cRadioButton_overrideFeedAddOne.TabStop = true;
            this.cRadioButton_overrideFeedAddOne.Text = "1";
            this.cRadioButton_overrideFeedAddOne.TextStyle = CCL.eTextStyle.Normal;
            this.cRadioButton_overrideFeedAddOne.UseVisualStyleBackColor = false;
            // 
            // tabPage_file
            // 
            this.tabPage_file.BackColor = System.Drawing.Color.Silver;
            this.tabPage_file.Controls.Add(this.cLabel_approximate);
            this.tabPage_file.Controls.Add(this.cListView_fileTools);
            this.tabPage_file.Controls.Add(this.cLabel_usedTime);
            this.tabPage_file.Controls.Add(this.cButton_openFile);
            this.tabPage_file.Controls.Add(this.cLabel_endTime);
            this.tabPage_file.Controls.Add(this.cLabel16);
            this.tabPage_file.Controls.Add(this.cLabel_startTime);
            this.tabPage_file.Controls.Add(this.cButton_sendFile);
            this.tabPage_file.Controls.Add(this.cButton_stopFile);
            this.tabPage_file.Controls.Add(this.cProgressBar1);
            this.tabPage_file.Controls.Add(this.cLabel_percentage);
            this.tabPage_file.Location = new System.Drawing.Point(4, 22);
            this.tabPage_file.Name = "tabPage_file";
            this.tabPage_file.Size = new System.Drawing.Size(375, 571);
            this.tabPage_file.TabIndex = 4;
            this.tabPage_file.Text = "File";
            // 
            // cLabel_approximate
            // 
            this.cLabel_approximate.AutoSize = true;
            this.cLabel_approximate.BackColor = System.Drawing.Color.Transparent;
            this.cLabel_approximate.Font = new System.Drawing.Font("Armata", 12F);
            this.cLabel_approximate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cLabel_approximate.Location = new System.Drawing.Point(7, 93);
            this.cLabel_approximate.Name = "cLabel_approximate";
            this.cLabel_approximate.OverrideFontSize = 12F;
            this.cLabel_approximate.Size = new System.Drawing.Size(316, 20);
            this.cLabel_approximate.TabIndex = 50;
            this.cLabel_approximate.Text = "Approximate machining time: 00:00";
            this.cLabel_approximate.TextStyle = CCL.eTextStyle.Medium;
            this.cLabel_approximate.UseFontSizeOverride = false;
            // 
            // cListView_fileTools
            // 
            this.cListView_fileTools.ColumnHeaderTextStyle = CCL.eTextStyle.Normal;
            this.cListView_fileTools.ColumnHeight = 24;
            this.cListView_fileTools.Columns.Add(this.columnHeader20);
            this.cListView_fileTools.Columns.Add(this.columnHeader21);
            this.cListView_fileTools.Columns.Add(this.columnHeader22);
            this.cListView_fileTools.Columns.Add(this.columnHeader23);
            this.cListView_fileTools.Columns.Add(this.columnHeader24);
            this.cListView_fileTools.ContentTextStyle = CCL.eTextStyle.Normal;
            this.cListView_fileTools.DrawBorder = true;
            this.cListView_fileTools.EnableItemEdit = false;
            this.cListView_fileTools.HorizontalLines = true;
            this.cListView_fileTools.ItemHeight = 24;
            this.cListView_fileTools.ItemHoverEffect = true;
            this.cListView_fileTools.Location = new System.Drawing.Point(6, 150);
            this.cListView_fileTools.MinColumnWidth = 20;
            this.cListView_fileTools.Name = "cListView_fileTools";
            this.cListView_fileTools.Size = new System.Drawing.Size(368, 421);
            this.cListView_fileTools.TabIndex = 48;
            this.cListView_fileTools.Text = "cListView1";
            this.cListView_fileTools.TitleText = "TOOLS IN FILE";
            this.cListView_fileTools.TitleTextStyle = CCL.eTextStyle.Title3;
            this.cListView_fileTools.VerticalLines = false;
            // 
            // columnHeader20
            // 
            this.columnHeader20.Text = "ID";
            // 
            // columnHeader21
            // 
            this.columnHeader21.Text = "Name";
            this.columnHeader21.Width = 120;
            // 
            // columnHeader22
            // 
            this.columnHeader22.Text = "CD";
            // 
            // columnHeader23
            // 
            this.columnHeader23.Text = "SD";
            // 
            // columnHeader24
            // 
            this.columnHeader24.Text = "Queue";
            // 
            // cLabel_usedTime
            // 
            this.cLabel_usedTime.AutoSize = true;
            this.cLabel_usedTime.BackColor = System.Drawing.Color.Transparent;
            this.cLabel_usedTime.Font = new System.Drawing.Font("Armata", 12F);
            this.cLabel_usedTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cLabel_usedTime.Location = new System.Drawing.Point(211, 73);
            this.cLabel_usedTime.Name = "cLabel_usedTime";
            this.cLabel_usedTime.OverrideFontSize = 12F;
            this.cLabel_usedTime.Size = new System.Drawing.Size(112, 20);
            this.cLabel_usedTime.TabIndex = 47;
            this.cLabel_usedTime.Text = "Used: 00:00";
            this.cLabel_usedTime.TextStyle = CCL.eTextStyle.Medium;
            this.cLabel_usedTime.UseFontSizeOverride = false;
            // 
            // cButton_openFile
            // 
            this.cButton_openFile.DrawBorder = true;
            this.cButton_openFile.Enabled = false;
            this.cButton_openFile.Font = new System.Drawing.Font("Armata", 12F);
            this.cButton_openFile.Location = new System.Drawing.Point(31, 23);
            this.cButton_openFile.Name = "cButton_openFile";
            this.cButton_openFile.Size = new System.Drawing.Size(100, 27);
            this.cButton_openFile.TabIndex = 41;
            this.cButton_openFile.Text = "OPEN";
            this.cButton_openFile.TextStyle = CCL.eTextStyle.Medium;
            this.cButton_openFile.UseVisualStyleBackColor = true;
            this.cButton_openFile.Click += new System.EventHandler(this.cButton_openFile_Click);
            // 
            // cLabel_endTime
            // 
            this.cLabel_endTime.AutoSize = true;
            this.cLabel_endTime.BackColor = System.Drawing.Color.Transparent;
            this.cLabel_endTime.Font = new System.Drawing.Font("Armata", 12F);
            this.cLabel_endTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cLabel_endTime.Location = new System.Drawing.Point(222, 53);
            this.cLabel_endTime.Name = "cLabel_endTime";
            this.cLabel_endTime.OverrideFontSize = 12F;
            this.cLabel_endTime.Size = new System.Drawing.Size(128, 20);
            this.cLabel_endTime.TabIndex = 46;
            this.cLabel_endTime.Text = "End: 00:00:00";
            this.cLabel_endTime.TextStyle = CCL.eTextStyle.Medium;
            this.cLabel_endTime.UseFontSizeOverride = false;
            // 
            // cLabel16
            // 
            this.cLabel16.BackColor = System.Drawing.Color.Transparent;
            this.cLabel16.Font = new System.Drawing.Font("Armata", 12F);
            this.cLabel16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cLabel16.Location = new System.Drawing.Point(3, 0);
            this.cLabel16.Name = "cLabel16";
            this.cLabel16.OverrideFontSize = 12F;
            this.cLabel16.Size = new System.Drawing.Size(300, 20);
            this.cLabel16.TabIndex = 42;
            this.cLabel16.Text = "FilePath";
            this.cLabel16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cLabel16.TextStyle = CCL.eTextStyle.Medium;
            this.cLabel16.UseFontSizeOverride = false;
            // 
            // cLabel_startTime
            // 
            this.cLabel_startTime.AutoSize = true;
            this.cLabel_startTime.BackColor = System.Drawing.Color.Transparent;
            this.cLabel_startTime.Font = new System.Drawing.Font("Armata", 12F);
            this.cLabel_startTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cLabel_startTime.Location = new System.Drawing.Point(27, 53);
            this.cLabel_startTime.Name = "cLabel_startTime";
            this.cLabel_startTime.OverrideFontSize = 12F;
            this.cLabel_startTime.Size = new System.Drawing.Size(138, 20);
            this.cLabel_startTime.TabIndex = 45;
            this.cLabel_startTime.Text = "Start: 00:00:00";
            this.cLabel_startTime.TextStyle = CCL.eTextStyle.Medium;
            this.cLabel_startTime.UseFontSizeOverride = false;
            // 
            // cButton_sendFile
            // 
            this.cButton_sendFile.DrawBorder = true;
            this.cButton_sendFile.Enabled = false;
            this.cButton_sendFile.Font = new System.Drawing.Font("Armata", 12F);
            this.cButton_sendFile.Location = new System.Drawing.Point(138, 23);
            this.cButton_sendFile.Name = "cButton_sendFile";
            this.cButton_sendFile.Size = new System.Drawing.Size(100, 27);
            this.cButton_sendFile.TabIndex = 43;
            this.cButton_sendFile.Text = "SEND";
            this.cButton_sendFile.TextStyle = CCL.eTextStyle.Medium;
            this.cButton_sendFile.UseVisualStyleBackColor = true;
            this.cButton_sendFile.Click += new System.EventHandler(this.cButton_sendFile_Click);
            // 
            // cButton_stopFile
            // 
            this.cButton_stopFile.DrawBorder = true;
            this.cButton_stopFile.Enabled = false;
            this.cButton_stopFile.Font = new System.Drawing.Font("Armata", 12F);
            this.cButton_stopFile.Location = new System.Drawing.Point(244, 23);
            this.cButton_stopFile.Name = "cButton_stopFile";
            this.cButton_stopFile.Size = new System.Drawing.Size(100, 27);
            this.cButton_stopFile.TabIndex = 44;
            this.cButton_stopFile.Text = "STOP";
            this.cButton_stopFile.TextStyle = CCL.eTextStyle.Medium;
            this.cButton_stopFile.UseVisualStyleBackColor = true;
            this.cButton_stopFile.Click += new System.EventHandler(this.cButton_stopFile_Click);
            // 
            // cProgressBar1
            // 
            this.cProgressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cProgressBar1.Location = new System.Drawing.Point(3, 116);
            this.cProgressBar1.Name = "cProgressBar1";
            this.cProgressBar1.ProgressBarHeight = 8;
            this.cProgressBar1.Size = new System.Drawing.Size(365, 8);
            this.cProgressBar1.TabIndex = 21;
            this.cProgressBar1.Visible = false;
            // 
            // cLabel_percentage
            // 
            this.cLabel_percentage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cLabel_percentage.BackColor = System.Drawing.Color.Transparent;
            this.cLabel_percentage.Font = new System.Drawing.Font("Armata", 12F);
            this.cLabel_percentage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cLabel_percentage.Location = new System.Drawing.Point(293, 127);
            this.cLabel_percentage.Name = "cLabel_percentage";
            this.cLabel_percentage.OverrideFontSize = 12F;
            this.cLabel_percentage.Size = new System.Drawing.Size(75, 20);
            this.cLabel_percentage.TabIndex = 31;
            this.cLabel_percentage.Text = "100%";
            this.cLabel_percentage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cLabel_percentage.TextStyle = CCL.eTextStyle.Medium;
            this.cLabel_percentage.UseFontSizeOverride = false;
            this.cLabel_percentage.Visible = false;
            // 
            // cTabSelector1
            // 
            this.cTabSelector1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cTabSelector1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.cTabSelector1.BaseTabControl = this.cTabControl2;
            this.cTabSelector1.DrawLineAllTheWay = true;
            this.cTabSelector1.Font = new System.Drawing.Font("Armata", 10F);
            this.cTabSelector1.IndicatorHeight = 4;
            this.cTabSelector1.LineHeight = 1;
            this.cTabSelector1.Location = new System.Drawing.Point(416, 7);
            this.cTabSelector1.Name = "cTabSelector1";
            this.cTabSelector1.SelectorHeight = 24;
            this.cTabSelector1.SelectorPadding = 10;
            this.cTabSelector1.Size = new System.Drawing.Size(383, 24);
            this.cTabSelector1.TabIndex = 28;
            this.cTabSelector1.TabsAlignment = CCL.Controls.CTabSelector.eTabsAlignment.Left;
            this.cTabSelector1.Text = "cTabSelector1";
            this.cTabSelector1.TextStyle = CCL.eTextStyle.Normal;
            // 
            // cButton_hold
            // 
            this.cButton_hold.DrawBorder = true;
            this.cButton_hold.Enabled = false;
            this.cButton_hold.Font = new System.Drawing.Font("Armata", 12F, System.Drawing.FontStyle.Bold);
            this.cButton_hold.Location = new System.Drawing.Point(221, 308);
            this.cButton_hold.Name = "cButton_hold";
            this.cButton_hold.Size = new System.Drawing.Size(140, 76);
            this.cButton_hold.TabIndex = 27;
            this.cButton_hold.Text = "HOLD";
            this.cButton_hold.TextStyle = CCL.eTextStyle.Title5;
            this.cButton_hold.UseVisualStyleBackColor = true;
            this.cButton_hold.Click += new System.EventHandler(this.cButton_hold_Click);
            // 
            // cButton_startResume
            // 
            this.cButton_startResume.DrawBorder = true;
            this.cButton_startResume.Enabled = false;
            this.cButton_startResume.Font = new System.Drawing.Font("Armata", 12F, System.Drawing.FontStyle.Bold);
            this.cButton_startResume.Location = new System.Drawing.Point(55, 308);
            this.cButton_startResume.Name = "cButton_startResume";
            this.cButton_startResume.Size = new System.Drawing.Size(140, 76);
            this.cButton_startResume.TabIndex = 26;
            this.cButton_startResume.Text = "START/RESUME";
            this.cButton_startResume.TextStyle = CCL.eTextStyle.Title5;
            this.cButton_startResume.UseVisualStyleBackColor = true;
            this.cButton_startResume.Click += new System.EventHandler(this.cButton_startResume_Click);
            // 
            // cLabel15
            // 
            this.cLabel15.AutoSize = true;
            this.cLabel15.BackColor = System.Drawing.Color.Transparent;
            this.cLabel15.Font = new System.Drawing.Font("Armata", 16F, System.Drawing.FontStyle.Bold);
            this.cLabel15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cLabel15.Location = new System.Drawing.Point(1, 190);
            this.cLabel15.Name = "cLabel15";
            this.cLabel15.OverrideFontSize = 12F;
            this.cLabel15.Size = new System.Drawing.Size(40, 27);
            this.cLabel15.TabIndex = 24;
            this.cLabel15.Text = "FS";
            this.cLabel15.TextStyle = CCL.eTextStyle.Title3;
            this.cLabel15.UseFontSizeOverride = false;
            // 
            // cLabel_fs
            // 
            this.cLabel_fs.AutoSize = true;
            this.cLabel_fs.BackColor = System.Drawing.Color.Transparent;
            this.cLabel_fs.Font = new System.Drawing.Font("Armata", 12F);
            this.cLabel_fs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cLabel_fs.Location = new System.Drawing.Point(40, 195);
            this.cLabel_fs.Name = "cLabel_fs";
            this.cLabel_fs.OverrideFontSize = 12F;
            this.cLabel_fs.Size = new System.Drawing.Size(85, 20);
            this.cLabel_fs.TabIndex = 23;
            this.cLabel_fs.Text = "000.000";
            this.cLabel_fs.TextStyle = CCL.eTextStyle.Medium;
            this.cLabel_fs.UseFontSizeOverride = false;
            // 
            // cButton_home
            // 
            this.cButton_home.DrawBorder = true;
            this.cButton_home.Enabled = false;
            this.cButton_home.Font = new System.Drawing.Font("Armata", 12F, System.Drawing.FontStyle.Bold);
            this.cButton_home.Location = new System.Drawing.Point(55, 267);
            this.cButton_home.Name = "cButton_home";
            this.cButton_home.Size = new System.Drawing.Size(306, 35);
            this.cButton_home.TabIndex = 22;
            this.cButton_home.Text = "HOME";
            this.cButton_home.TextStyle = CCL.eTextStyle.Title5;
            this.cButton_home.UseVisualStyleBackColor = true;
            this.cButton_home.Click += new System.EventHandler(this.cButton_home_Click);
            // 
            // cButton_unlock
            // 
            this.cButton_unlock.DrawBorder = true;
            this.cButton_unlock.Enabled = false;
            this.cButton_unlock.Font = new System.Drawing.Font("Armata", 12F, System.Drawing.FontStyle.Bold);
            this.cButton_unlock.Location = new System.Drawing.Point(221, 226);
            this.cButton_unlock.Name = "cButton_unlock";
            this.cButton_unlock.Size = new System.Drawing.Size(140, 35);
            this.cButton_unlock.TabIndex = 20;
            this.cButton_unlock.Text = "UNLOCK";
            this.cButton_unlock.TextStyle = CCL.eTextStyle.Title5;
            this.cButton_unlock.UseVisualStyleBackColor = true;
            this.cButton_unlock.Click += new System.EventHandler(this.cButton_unlock_Click);
            // 
            // cButton_reset
            // 
            this.cButton_reset.DrawBorder = true;
            this.cButton_reset.Enabled = false;
            this.cButton_reset.Font = new System.Drawing.Font("Armata", 12F, System.Drawing.FontStyle.Bold);
            this.cButton_reset.Location = new System.Drawing.Point(55, 226);
            this.cButton_reset.Name = "cButton_reset";
            this.cButton_reset.Size = new System.Drawing.Size(140, 35);
            this.cButton_reset.TabIndex = 19;
            this.cButton_reset.Text = "RESET";
            this.cButton_reset.TextStyle = CCL.eTextStyle.Title5;
            this.cButton_reset.UseVisualStyleBackColor = true;
            this.cButton_reset.Click += new System.EventHandler(this.cButton_reset_Click);
            // 
            // cLinkLabel_zeroAll
            // 
            this.cLinkLabel_zeroAll.AutomaticSize = true;
            this.cLinkLabel_zeroAll.Enabled = false;
            this.cLinkLabel_zeroAll.Font = new System.Drawing.Font("Armata", 10F);
            this.cLinkLabel_zeroAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cLinkLabel_zeroAll.LineHeight = 2;
            this.cLinkLabel_zeroAll.Location = new System.Drawing.Point(258, 90);
            this.cLinkLabel_zeroAll.MaximumSize = new System.Drawing.Size(60, 20);
            this.cLinkLabel_zeroAll.MinimumSize = new System.Drawing.Size(60, 20);
            this.cLinkLabel_zeroAll.Name = "cLinkLabel_zeroAll";
            this.cLinkLabel_zeroAll.Size = new System.Drawing.Size(60, 20);
            this.cLinkLabel_zeroAll.TabIndex = 18;
            this.cLinkLabel_zeroAll.Text = "Zero All";
            this.cLinkLabel_zeroAll.TextStyle = CCL.eTextStyle.Normal;
            this.cLinkLabel_zeroAll.Click += new System.EventHandler(this.cLinkLabel_zeroAll_Click);
            // 
            // cLinkLabel_zeroZ
            // 
            this.cLinkLabel_zeroZ.AutomaticSize = true;
            this.cLinkLabel_zeroZ.Enabled = false;
            this.cLinkLabel_zeroZ.Font = new System.Drawing.Font("Armata", 10F);
            this.cLinkLabel_zeroZ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cLinkLabel_zeroZ.LineHeight = 2;
            this.cLinkLabel_zeroZ.Location = new System.Drawing.Point(268, 168);
            this.cLinkLabel_zeroZ.MaximumSize = new System.Drawing.Size(38, 20);
            this.cLinkLabel_zeroZ.MinimumSize = new System.Drawing.Size(38, 20);
            this.cLinkLabel_zeroZ.Name = "cLinkLabel_zeroZ";
            this.cLinkLabel_zeroZ.Size = new System.Drawing.Size(38, 20);
            this.cLinkLabel_zeroZ.TabIndex = 17;
            this.cLinkLabel_zeroZ.Text = "Zero";
            this.cLinkLabel_zeroZ.TextStyle = CCL.eTextStyle.Normal;
            this.cLinkLabel_zeroZ.Click += new System.EventHandler(this.cLinkLabel_zeroZ_Click);
            // 
            // cLinkLabel_zeroY
            // 
            this.cLinkLabel_zeroY.AutomaticSize = true;
            this.cLinkLabel_zeroY.Enabled = false;
            this.cLinkLabel_zeroY.Font = new System.Drawing.Font("Armata", 10F);
            this.cLinkLabel_zeroY.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cLinkLabel_zeroY.LineHeight = 2;
            this.cLinkLabel_zeroY.Location = new System.Drawing.Point(268, 141);
            this.cLinkLabel_zeroY.MaximumSize = new System.Drawing.Size(38, 20);
            this.cLinkLabel_zeroY.MinimumSize = new System.Drawing.Size(38, 20);
            this.cLinkLabel_zeroY.Name = "cLinkLabel_zeroY";
            this.cLinkLabel_zeroY.Size = new System.Drawing.Size(38, 20);
            this.cLinkLabel_zeroY.TabIndex = 16;
            this.cLinkLabel_zeroY.Text = "Zero";
            this.cLinkLabel_zeroY.TextStyle = CCL.eTextStyle.Normal;
            this.cLinkLabel_zeroY.Click += new System.EventHandler(this.cLinkLabel_zeroY_Click);
            // 
            // cLinkLabel_zeroX
            // 
            this.cLinkLabel_zeroX.AutomaticSize = true;
            this.cLinkLabel_zeroX.Enabled = false;
            this.cLinkLabel_zeroX.Font = new System.Drawing.Font("Armata", 10F);
            this.cLinkLabel_zeroX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cLinkLabel_zeroX.LineHeight = 2;
            this.cLinkLabel_zeroX.Location = new System.Drawing.Point(268, 116);
            this.cLinkLabel_zeroX.MaximumSize = new System.Drawing.Size(38, 20);
            this.cLinkLabel_zeroX.MinimumSize = new System.Drawing.Size(38, 20);
            this.cLinkLabel_zeroX.Name = "cLinkLabel_zeroX";
            this.cLinkLabel_zeroX.Size = new System.Drawing.Size(38, 20);
            this.cLinkLabel_zeroX.TabIndex = 15;
            this.cLinkLabel_zeroX.Text = "Zero";
            this.cLinkLabel_zeroX.TextStyle = CCL.eTextStyle.Normal;
            this.cLinkLabel_zeroX.Click += new System.EventHandler(this.cLinkLabel_zeroX_Click);
            // 
            // cLabel13
            // 
            this.cLabel13.AutoSize = true;
            this.cLabel13.BackColor = System.Drawing.Color.Transparent;
            this.cLabel13.Font = new System.Drawing.Font("Armata", 16F, System.Drawing.FontStyle.Bold);
            this.cLabel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cLabel13.Location = new System.Drawing.Point(6, 163);
            this.cLabel13.Name = "cLabel13";
            this.cLabel13.OverrideFontSize = 12F;
            this.cLabel13.Size = new System.Drawing.Size(26, 27);
            this.cLabel13.TabIndex = 14;
            this.cLabel13.Text = "Z";
            this.cLabel13.TextStyle = CCL.eTextStyle.Title3;
            this.cLabel13.UseFontSizeOverride = false;
            // 
            // cLabel12
            // 
            this.cLabel12.AutoSize = true;
            this.cLabel12.BackColor = System.Drawing.Color.Transparent;
            this.cLabel12.Font = new System.Drawing.Font("Armata", 16F, System.Drawing.FontStyle.Bold);
            this.cLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cLabel12.Location = new System.Drawing.Point(6, 136);
            this.cLabel12.Name = "cLabel12";
            this.cLabel12.OverrideFontSize = 12F;
            this.cLabel12.Size = new System.Drawing.Size(26, 27);
            this.cLabel12.TabIndex = 13;
            this.cLabel12.Text = "Y";
            this.cLabel12.TextStyle = CCL.eTextStyle.Title3;
            this.cLabel12.UseFontSizeOverride = false;
            // 
            // cLabel11
            // 
            this.cLabel11.AutoSize = true;
            this.cLabel11.BackColor = System.Drawing.Color.Transparent;
            this.cLabel11.Font = new System.Drawing.Font("Armata", 16F, System.Drawing.FontStyle.Bold);
            this.cLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cLabel11.Location = new System.Drawing.Point(6, 109);
            this.cLabel11.Name = "cLabel11";
            this.cLabel11.OverrideFontSize = 12F;
            this.cLabel11.Size = new System.Drawing.Size(28, 27);
            this.cLabel11.TabIndex = 12;
            this.cLabel11.Text = "X";
            this.cLabel11.TextStyle = CCL.eTextStyle.Title3;
            this.cLabel11.UseFontSizeOverride = false;
            // 
            // cLabel_mposZ
            // 
            this.cLabel_mposZ.AutoSize = true;
            this.cLabel_mposZ.BackColor = System.Drawing.Color.Transparent;
            this.cLabel_mposZ.Font = new System.Drawing.Font("Armata", 12F);
            this.cLabel_mposZ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cLabel_mposZ.Location = new System.Drawing.Point(157, 168);
            this.cLabel_mposZ.Name = "cLabel_mposZ";
            this.cLabel_mposZ.OverrideFontSize = 12F;
            this.cLabel_mposZ.Size = new System.Drawing.Size(85, 20);
            this.cLabel_mposZ.TabIndex = 11;
            this.cLabel_mposZ.Text = "000.000";
            this.cLabel_mposZ.TextStyle = CCL.eTextStyle.Medium;
            this.cLabel_mposZ.UseFontSizeOverride = false;
            // 
            // cLabel_mposY
            // 
            this.cLabel_mposY.AutoSize = true;
            this.cLabel_mposY.BackColor = System.Drawing.Color.Transparent;
            this.cLabel_mposY.Font = new System.Drawing.Font("Armata", 12F);
            this.cLabel_mposY.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cLabel_mposY.Location = new System.Drawing.Point(157, 141);
            this.cLabel_mposY.Name = "cLabel_mposY";
            this.cLabel_mposY.OverrideFontSize = 12F;
            this.cLabel_mposY.Size = new System.Drawing.Size(85, 20);
            this.cLabel_mposY.TabIndex = 10;
            this.cLabel_mposY.Text = "000.000";
            this.cLabel_mposY.TextStyle = CCL.eTextStyle.Medium;
            this.cLabel_mposY.UseFontSizeOverride = false;
            // 
            // cLabel_mposX
            // 
            this.cLabel_mposX.AutoSize = true;
            this.cLabel_mposX.BackColor = System.Drawing.Color.Transparent;
            this.cLabel_mposX.Font = new System.Drawing.Font("Armata", 12F);
            this.cLabel_mposX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cLabel_mposX.Location = new System.Drawing.Point(157, 116);
            this.cLabel_mposX.Name = "cLabel_mposX";
            this.cLabel_mposX.OverrideFontSize = 12F;
            this.cLabel_mposX.Size = new System.Drawing.Size(85, 20);
            this.cLabel_mposX.TabIndex = 9;
            this.cLabel_mposX.Text = "000.000";
            this.cLabel_mposX.TextStyle = CCL.eTextStyle.Medium;
            this.cLabel_mposX.UseFontSizeOverride = false;
            // 
            // cLabel_wposZ
            // 
            this.cLabel_wposZ.AutoSize = true;
            this.cLabel_wposZ.BackColor = System.Drawing.Color.Transparent;
            this.cLabel_wposZ.Font = new System.Drawing.Font("Armata", 12F);
            this.cLabel_wposZ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cLabel_wposZ.Location = new System.Drawing.Point(40, 168);
            this.cLabel_wposZ.Name = "cLabel_wposZ";
            this.cLabel_wposZ.OverrideFontSize = 12F;
            this.cLabel_wposZ.Size = new System.Drawing.Size(85, 20);
            this.cLabel_wposZ.TabIndex = 8;
            this.cLabel_wposZ.Text = "000.000";
            this.cLabel_wposZ.TextStyle = CCL.eTextStyle.Medium;
            this.cLabel_wposZ.UseFontSizeOverride = false;
            // 
            // cLabel_wposY
            // 
            this.cLabel_wposY.AutoSize = true;
            this.cLabel_wposY.BackColor = System.Drawing.Color.Transparent;
            this.cLabel_wposY.Font = new System.Drawing.Font("Armata", 12F);
            this.cLabel_wposY.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cLabel_wposY.Location = new System.Drawing.Point(40, 141);
            this.cLabel_wposY.Name = "cLabel_wposY";
            this.cLabel_wposY.OverrideFontSize = 12F;
            this.cLabel_wposY.Size = new System.Drawing.Size(85, 20);
            this.cLabel_wposY.TabIndex = 7;
            this.cLabel_wposY.Text = "000.000";
            this.cLabel_wposY.TextStyle = CCL.eTextStyle.Medium;
            this.cLabel_wposY.UseFontSizeOverride = false;
            // 
            // cLabel_wposX
            // 
            this.cLabel_wposX.AutoSize = true;
            this.cLabel_wposX.BackColor = System.Drawing.Color.Transparent;
            this.cLabel_wposX.Font = new System.Drawing.Font("Armata", 12F);
            this.cLabel_wposX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cLabel_wposX.Location = new System.Drawing.Point(40, 114);
            this.cLabel_wposX.Name = "cLabel_wposX";
            this.cLabel_wposX.OverrideFontSize = 12F;
            this.cLabel_wposX.Size = new System.Drawing.Size(85, 20);
            this.cLabel_wposX.TabIndex = 6;
            this.cLabel_wposX.Text = "000.000";
            this.cLabel_wposX.TextStyle = CCL.eTextStyle.Medium;
            this.cLabel_wposX.UseFontSizeOverride = false;
            // 
            // cLabel4
            // 
            this.cLabel4.AutoSize = true;
            this.cLabel4.BackColor = System.Drawing.Color.Transparent;
            this.cLabel4.Font = new System.Drawing.Font("Armata", 16F, System.Drawing.FontStyle.Bold);
            this.cLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cLabel4.Location = new System.Drawing.Point(156, 82);
            this.cLabel4.Name = "cLabel4";
            this.cLabel4.OverrideFontSize = 12F;
            this.cLabel4.Size = new System.Drawing.Size(82, 27);
            this.cLabel4.TabIndex = 5;
            this.cLabel4.Text = "MPOS";
            this.cLabel4.TextStyle = CCL.eTextStyle.Title3;
            this.cLabel4.UseFontSizeOverride = false;
            // 
            // cLabel3
            // 
            this.cLabel3.AutoSize = true;
            this.cLabel3.BackColor = System.Drawing.Color.Transparent;
            this.cLabel3.Font = new System.Drawing.Font("Armata", 16F, System.Drawing.FontStyle.Bold);
            this.cLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cLabel3.Location = new System.Drawing.Point(39, 82);
            this.cLabel3.Name = "cLabel3";
            this.cLabel3.OverrideFontSize = 12F;
            this.cLabel3.Size = new System.Drawing.Size(82, 27);
            this.cLabel3.TabIndex = 4;
            this.cLabel3.Text = "WPOS";
            this.cLabel3.TextStyle = CCL.eTextStyle.Title3;
            this.cLabel3.UseFontSizeOverride = false;
            // 
            // cSwitch_openPort
            // 
            this.cSwitch_openPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.cSwitch_openPort.CircleSize = 20;
            this.cSwitch_openPort.Font = new System.Drawing.Font("Armata", 10F);
            this.cSwitch_openPort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cSwitch_openPort.IsOn = false;
            this.cSwitch_openPort.Location = new System.Drawing.Point(280, 6);
            this.cSwitch_openPort.Name = "cSwitch_openPort";
            this.cSwitch_openPort.OffIcon = ((System.Drawing.Image)(resources.GetObject("cSwitch_openPort.OffIcon")));
            this.cSwitch_openPort.OnIcon = ((System.Drawing.Image)(resources.GetObject("cSwitch_openPort.OnIcon")));
            this.cSwitch_openPort.Size = new System.Drawing.Size(130, 25);
            this.cSwitch_openPort.SwitchSize = new System.Drawing.Size(50, 25);
            this.cSwitch_openPort.TabIndex = 1;
            this.cSwitch_openPort.Text = "Open Port";
            this.cSwitch_openPort.TextStyle = CCL.eTextStyle.Normal;
            this.cSwitch_openPort.UseIcons = false;
            this.cSwitch_openPort.Click += new System.EventHandler(this.cSwitch_openPort_Click);
            // 
            // cDropDown_machineProfiles
            // 
            this.cDropDown_machineProfiles.Font = new System.Drawing.Font("Armata", 10F);
            this.cDropDown_machineProfiles.Location = new System.Drawing.Point(6, 6);
            this.cDropDown_machineProfiles.Name = "cDropDown_machineProfiles";
            this.cDropDown_machineProfiles.SelectedIndex = -1;
            this.cDropDown_machineProfiles.Size = new System.Drawing.Size(268, 25);
            this.cDropDown_machineProfiles.TabIndex = 0;
            this.cDropDown_machineProfiles.Text = "cDropDown1";
            this.cDropDown_machineProfiles.TextStyle = CCL.eTextStyle.Normal;
            // 
            // tabPage_Machines
            // 
            this.tabPage_Machines.BackColor = System.Drawing.Color.Silver;
            this.tabPage_Machines.Controls.Add(this.cButton_cancelMachineSave);
            this.tabPage_Machines.Controls.Add(this.cButton_saveMachines);
            this.tabPage_Machines.Controls.Add(this.cListView_machines);
            this.tabPage_Machines.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Machines.Name = "tabPage_Machines";
            this.tabPage_Machines.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Machines.Size = new System.Drawing.Size(805, 637);
            this.tabPage_Machines.TabIndex = 1;
            this.tabPage_Machines.Text = "Machines";
            // 
            // cButton_cancelMachineSave
            // 
            this.cButton_cancelMachineSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cButton_cancelMachineSave.DrawBorder = true;
            this.cButton_cancelMachineSave.Font = new System.Drawing.Font("Armata", 10F);
            this.cButton_cancelMachineSave.Location = new System.Drawing.Point(699, 596);
            this.cButton_cancelMachineSave.Name = "cButton_cancelMachineSave";
            this.cButton_cancelMachineSave.Size = new System.Drawing.Size(100, 35);
            this.cButton_cancelMachineSave.TabIndex = 7;
            this.cButton_cancelMachineSave.Text = "Cancel";
            this.cButton_cancelMachineSave.TextStyle = CCL.eTextStyle.Normal;
            this.cButton_cancelMachineSave.UseVisualStyleBackColor = true;
            this.cButton_cancelMachineSave.Click += new System.EventHandler(this.cButton_cancelMachineSave_Click);
            // 
            // cButton_saveMachines
            // 
            this.cButton_saveMachines.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cButton_saveMachines.DrawBorder = true;
            this.cButton_saveMachines.Font = new System.Drawing.Font("Armata", 10F);
            this.cButton_saveMachines.Location = new System.Drawing.Point(593, 596);
            this.cButton_saveMachines.Name = "cButton_saveMachines";
            this.cButton_saveMachines.Size = new System.Drawing.Size(100, 35);
            this.cButton_saveMachines.TabIndex = 6;
            this.cButton_saveMachines.Text = "Save";
            this.cButton_saveMachines.TextStyle = CCL.eTextStyle.Normal;
            this.cButton_saveMachines.UseVisualStyleBackColor = true;
            this.cButton_saveMachines.Click += new System.EventHandler(this.cButton_saveMachines_Click);
            // 
            // cListView_machines
            // 
            this.cListView_machines.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cListView_machines.ColumnHeaderTextStyle = CCL.eTextStyle.Normal;
            this.cListView_machines.ColumnHeight = 24;
            this.cListView_machines.Columns.Add(this.columnHeader19);
            this.cListView_machines.Columns.Add(this.columnHeader12);
            this.cListView_machines.Columns.Add(this.columnHeader18);
            this.cListView_machines.Columns.Add(this.columnHeader14);
            this.cListView_machines.Columns.Add(this.columnHeader15);
            this.cListView_machines.Columns.Add(this.columnHeader16);
            this.cListView_machines.Columns.Add(this.columnHeader13);
            this.cListView_machines.Columns.Add(this.columnHeader17);
            this.cListView_machines.ContentTextStyle = CCL.eTextStyle.Normal;
            this.cListView_machines.ContextMenuStrip = this.cContextMenuStrip_editMachine;
            this.cListView_machines.DrawBorder = false;
            this.cListView_machines.EnableItemEdit = false;
            this.cListView_machines.HorizontalLines = false;
            this.cListView_machines.ItemHeight = 24;
            this.cListView_machines.ItemHoverEffect = true;
            this.cListView_machines.Location = new System.Drawing.Point(3, 3);
            this.cListView_machines.MinColumnWidth = 20;
            this.cListView_machines.Name = "cListView_machines";
            this.cListView_machines.Size = new System.Drawing.Size(796, 587);
            this.cListView_machines.TabIndex = 0;
            this.cListView_machines.Text = "cListView1";
            this.cListView_machines.TitleText = "MACHINES";
            this.cListView_machines.TitleTextStyle = CCL.eTextStyle.Title3;
            this.cListView_machines.VerticalLines = false;
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "ID";
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Machine";
            this.columnHeader12.Width = 150;
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "Type";
            this.columnHeader18.Width = 80;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Max X";
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Max Y";
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Max Z";
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "GRBL v.";
            this.columnHeader13.Width = 100;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "OPT";
            this.columnHeader17.Width = 100;
            // 
            // cContextMenuStrip_editMachine
            // 
            this.cContextMenuStrip_editMachine.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addMachineToolStripMenuItem,
            this.duplicateMachineToolStripMenuItem,
            this.toolStripSeparator3,
            this.exportMachineToolStripMenuItem,
            this.importMachineToolStripMenuItem,
            this.toolStripSeparator4,
            this.deleteMachineToolStripMenuItem,
            this.reloadMachinesToolStripMenuItem,
            this.toolStripSeparator5,
            this.editMachineToolStripMenuItem});
            this.cContextMenuStrip_editMachine.Name = "cContextMenuStrip_editToolValues";
            this.cContextMenuStrip_editMachine.Size = new System.Drawing.Size(125, 176);
            this.cContextMenuStrip_editMachine.TextStyle = CCL.eTextStyle.Normal;
            this.cContextMenuStrip_editMachine.Opening += new System.ComponentModel.CancelEventHandler(this.cContextMenuStrip_editMachine_Opening);
            // 
            // addMachineToolStripMenuItem
            // 
            this.addMachineToolStripMenuItem.Name = "addMachineToolStripMenuItem";
            this.addMachineToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.addMachineToolStripMenuItem.Text = "Add New";
            this.addMachineToolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem_addNewMachine_Click);
            // 
            // duplicateMachineToolStripMenuItem
            // 
            this.duplicateMachineToolStripMenuItem.Name = "duplicateMachineToolStripMenuItem";
            this.duplicateMachineToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.duplicateMachineToolStripMenuItem.Text = "Duplicate";
            this.duplicateMachineToolStripMenuItem.Click += new System.EventHandler(this.duplicateMachineToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(121, 6);
            // 
            // exportMachineToolStripMenuItem
            // 
            this.exportMachineToolStripMenuItem.Name = "exportMachineToolStripMenuItem";
            this.exportMachineToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.exportMachineToolStripMenuItem.Text = "Export";
            this.exportMachineToolStripMenuItem.Click += new System.EventHandler(this.exportMachineToolStripMenuItem_Click);
            // 
            // importMachineToolStripMenuItem
            // 
            this.importMachineToolStripMenuItem.Name = "importMachineToolStripMenuItem";
            this.importMachineToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.importMachineToolStripMenuItem.Text = "Import";
            this.importMachineToolStripMenuItem.Click += new System.EventHandler(this.importMachineToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(121, 6);
            // 
            // deleteMachineToolStripMenuItem
            // 
            this.deleteMachineToolStripMenuItem.Name = "deleteMachineToolStripMenuItem";
            this.deleteMachineToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.deleteMachineToolStripMenuItem.Text = "Delete";
            this.deleteMachineToolStripMenuItem.Click += new System.EventHandler(this.deleteMachineToolStripMenuItem_Click);
            // 
            // reloadMachinesToolStripMenuItem
            // 
            this.reloadMachinesToolStripMenuItem.Name = "reloadMachinesToolStripMenuItem";
            this.reloadMachinesToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.reloadMachinesToolStripMenuItem.Text = "Reload";
            this.reloadMachinesToolStripMenuItem.Click += new System.EventHandler(this.reloadMachinesToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(121, 6);
            // 
            // editMachineToolStripMenuItem
            // 
            this.editMachineToolStripMenuItem.Name = "editMachineToolStripMenuItem";
            this.editMachineToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.editMachineToolStripMenuItem.Text = "Edit";
            this.editMachineToolStripMenuItem.Click += new System.EventHandler(this.editMachineToolStripMenuItem_Click);
            // 
            // tabPage_Tools
            // 
            this.tabPage_Tools.BackColor = System.Drawing.Color.Silver;
            this.tabPage_Tools.Controls.Add(this.cButton_cancelToolSave);
            this.tabPage_Tools.Controls.Add(this.cButton_saveTools);
            this.tabPage_Tools.Controls.Add(this.cLabel1);
            this.tabPage_Tools.Controls.Add(this.cCheckBox_editToolValues);
            this.tabPage_Tools.Controls.Add(this.cListView_tools);
            this.tabPage_Tools.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Tools.Name = "tabPage_Tools";
            this.tabPage_Tools.Size = new System.Drawing.Size(805, 637);
            this.tabPage_Tools.TabIndex = 2;
            this.tabPage_Tools.Text = "Tools";
            // 
            // cButton_cancelToolSave
            // 
            this.cButton_cancelToolSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cButton_cancelToolSave.DrawBorder = true;
            this.cButton_cancelToolSave.Font = new System.Drawing.Font("Armata", 10F);
            this.cButton_cancelToolSave.Location = new System.Drawing.Point(702, 599);
            this.cButton_cancelToolSave.Name = "cButton_cancelToolSave";
            this.cButton_cancelToolSave.Size = new System.Drawing.Size(100, 35);
            this.cButton_cancelToolSave.TabIndex = 4;
            this.cButton_cancelToolSave.Text = "Cancel";
            this.cButton_cancelToolSave.TextStyle = CCL.eTextStyle.Normal;
            this.cButton_cancelToolSave.UseVisualStyleBackColor = true;
            this.cButton_cancelToolSave.Click += new System.EventHandler(this.cButton_cancelToolSave_Click);
            // 
            // cButton_saveTools
            // 
            this.cButton_saveTools.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cButton_saveTools.DrawBorder = true;
            this.cButton_saveTools.Font = new System.Drawing.Font("Armata", 10F);
            this.cButton_saveTools.Location = new System.Drawing.Point(596, 599);
            this.cButton_saveTools.Name = "cButton_saveTools";
            this.cButton_saveTools.Size = new System.Drawing.Size(100, 35);
            this.cButton_saveTools.TabIndex = 3;
            this.cButton_saveTools.Text = "Save";
            this.cButton_saveTools.TextStyle = CCL.eTextStyle.Normal;
            this.cButton_saveTools.UseVisualStyleBackColor = true;
            this.cButton_saveTools.Click += new System.EventHandler(this.cButton_saveTools_Click);
            // 
            // cLabel1
            // 
            this.cLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cLabel1.BackColor = System.Drawing.Color.Transparent;
            this.cLabel1.Font = new System.Drawing.Font("Armata", 10F);
            this.cLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cLabel1.Location = new System.Drawing.Point(3, 571);
            this.cLabel1.Name = "cLabel1";
            this.cLabel1.OverrideFontSize = 12F;
            this.cLabel1.Size = new System.Drawing.Size(492, 63);
            this.cLabel1.TabIndex = 2;
            this.cLabel1.Text = "INFO\r\nCD = Cutting Diameter SD = Shank Diameter FL = Flute Lenght\r\nF = Flutes A =" +
    " Angle R = Radius W = Watts";
            this.cLabel1.TextStyle = CCL.eTextStyle.Normal;
            this.cLabel1.UseFontSizeOverride = false;
            // 
            // cCheckBox_editToolValues
            // 
            this.cCheckBox_editToolValues.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cCheckBox_editToolValues.AutoSize = true;
            this.cCheckBox_editToolValues.CheckBoxHeight = 18;
            this.cCheckBox_editToolValues.Font = new System.Drawing.Font("Armata", 10F);
            this.cCheckBox_editToolValues.Location = new System.Drawing.Point(595, 571);
            this.cCheckBox_editToolValues.Name = "cCheckBox_editToolValues";
            this.cCheckBox_editToolValues.Size = new System.Drawing.Size(207, 22);
            this.cCheckBox_editToolValues.TabIndex = 1;
            this.cCheckBox_editToolValues.Text = "Edit values - Double Click";
            this.cCheckBox_editToolValues.TextStyle = CCL.eTextStyle.Normal;
            this.cCheckBox_editToolValues.TextYOffset = 0;
            this.cCheckBox_editToolValues.Underline = true;
            this.cCheckBox_editToolValues.UnderlineYOffset = 0;
            this.cCheckBox_editToolValues.UseVisualStyleBackColor = true;
            this.cCheckBox_editToolValues.CheckedChanged += new System.EventHandler(this.cCheckBox_editToolValues_CheckedChanged);
            // 
            // cListView_tools
            // 
            this.cListView_tools.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cListView_tools.ColumnHeaderTextStyle = CCL.eTextStyle.Normal;
            this.cListView_tools.ColumnHeight = 24;
            this.cListView_tools.Columns.Add(this.columnHeader2);
            this.cListView_tools.Columns.Add(this.columnHeader3);
            this.cListView_tools.Columns.Add(this.columnHeader4);
            this.cListView_tools.Columns.Add(this.columnHeader5);
            this.cListView_tools.Columns.Add(this.columnHeader6);
            this.cListView_tools.Columns.Add(this.columnHeader7);
            this.cListView_tools.Columns.Add(this.columnHeader8);
            this.cListView_tools.Columns.Add(this.columnHeader9);
            this.cListView_tools.Columns.Add(this.columnHeader10);
            this.cListView_tools.Columns.Add(this.columnHeader11);
            this.cListView_tools.ContentTextStyle = CCL.eTextStyle.Normal;
            this.cListView_tools.ContextMenuStrip = this.cContextMenuStrip_editToolValues;
            this.cListView_tools.DrawBorder = false;
            this.cListView_tools.DropDownColumns.Add("2");
            this.cListView_tools.DropDownItems.Add("Flat Ball Carving Drill Chamfer Rounding Laser");
            this.cListView_tools.EnableItemEdit = false;
            this.cListView_tools.HorizontalLines = true;
            this.cListView_tools.ItemHeight = 24;
            this.cListView_tools.ItemHoverEffect = true;
            this.cListView_tools.Location = new System.Drawing.Point(3, 3);
            this.cListView_tools.MinColumnWidth = 20;
            this.cListView_tools.Name = "cListView_tools";
            this.cListView_tools.Size = new System.Drawing.Size(799, 562);
            this.cListView_tools.TabIndex = 0;
            this.cListView_tools.Text = "cListView1";
            this.cListView_tools.TitleText = "TOOLS";
            this.cListView_tools.TitleTextStyle = CCL.eTextStyle.Title3;
            this.cListView_tools.VerticalLines = false;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ID";
            this.columnHeader2.Width = 50;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Name";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Type";
            this.columnHeader4.Width = 80;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "CD";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "SD";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "FL";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "F";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "A";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "R";
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "W";
            // 
            // cContextMenuStrip_editToolValues
            // 
            this.cContextMenuStrip_editToolValues.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewToolStripMenuItem,
            this.duplicateToolStripMenuItem,
            this.toolStripSeparator1,
            this.exportToolStripMenuItem,
            this.importToolStripMenuItem,
            this.toolStripSeparator2,
            this.deleteToolStripMenuItem,
            this.reloadToolStripMenuItem});
            this.cContextMenuStrip_editToolValues.Name = "cContextMenuStrip_editToolValues";
            this.cContextMenuStrip_editToolValues.Size = new System.Drawing.Size(125, 148);
            this.cContextMenuStrip_editToolValues.TextStyle = CCL.eTextStyle.Normal;
            this.cContextMenuStrip_editToolValues.Opening += new System.ComponentModel.CancelEventHandler(this.cContextMenuStrip_editToolValues_Opening);
            // 
            // addNewToolStripMenuItem
            // 
            this.addNewToolStripMenuItem.Name = "addNewToolStripMenuItem";
            this.addNewToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.addNewToolStripMenuItem.Text = "Add New";
            this.addNewToolStripMenuItem.Click += new System.EventHandler(this.addNewToolStripMenuItem_Click);
            // 
            // duplicateToolStripMenuItem
            // 
            this.duplicateToolStripMenuItem.Name = "duplicateToolStripMenuItem";
            this.duplicateToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.duplicateToolStripMenuItem.Text = "Duplicate";
            this.duplicateToolStripMenuItem.Click += new System.EventHandler(this.duplicateToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(121, 6);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.importToolStripMenuItem.Text = "Import";
            this.importToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(121, 6);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // reloadToolStripMenuItem
            // 
            this.reloadToolStripMenuItem.Name = "reloadToolStripMenuItem";
            this.reloadToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.reloadToolStripMenuItem.Text = "Reload";
            this.reloadToolStripMenuItem.Click += new System.EventHandler(this.reloadToolStripMenuItem_Click);
            // 
            // tabPage_Settings
            // 
            this.tabPage_Settings.BackColor = System.Drawing.Color.Silver;
            this.tabPage_Settings.Controls.Add(this.cGroupBox2);
            this.tabPage_Settings.Controls.Add(this.cButton_cancelAppSettings);
            this.tabPage_Settings.Controls.Add(this.cButton_saveAppSettings);
            this.tabPage_Settings.Controls.Add(this.cGroupBox1);
            this.tabPage_Settings.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Settings.Name = "tabPage_Settings";
            this.tabPage_Settings.Size = new System.Drawing.Size(805, 637);
            this.tabPage_Settings.TabIndex = 3;
            this.tabPage_Settings.Text = "Settings";
            // 
            // cGroupBox2
            // 
            this.cGroupBox2.Controls.Add(this.cRadioButtonSettingsTheme6);
            this.cGroupBox2.Controls.Add(this.cRadioButtonSettingsTheme5);
            this.cGroupBox2.Controls.Add(this.cRadioButtonSettingsTheme4);
            this.cGroupBox2.Controls.Add(this.cRadioButtonSettingsTheme3);
            this.cGroupBox2.Controls.Add(this.cRadioButtonSettingsTheme2);
            this.cGroupBox2.Controls.Add(this.cRadioButtonSettingsTheme1);
            this.cGroupBox2.Font = new System.Drawing.Font("Armata", 12F, System.Drawing.FontStyle.Bold);
            this.cGroupBox2.Location = new System.Drawing.Point(3, 153);
            this.cGroupBox2.Name = "cGroupBox2";
            this.cGroupBox2.Radius = 10;
            this.cGroupBox2.Size = new System.Drawing.Size(453, 82);
            this.cGroupBox2.TabIndex = 4;
            this.cGroupBox2.TabStop = false;
            this.cGroupBox2.Text = "Teema";
            this.cGroupBox2.TextAlignment = System.Drawing.StringAlignment.Near;
            this.cGroupBox2.TextStyle = CCL.eTextStyle.Title5;
            // 
            // cRadioButtonSettingsTheme6
            // 
            this.cRadioButtonSettingsTheme6.BackColor = System.Drawing.Color.Transparent;
            this.cRadioButtonSettingsTheme6.Checked = true;
            this.cRadioButtonSettingsTheme6.CheckMarkSize = 10;
            this.cRadioButtonSettingsTheme6.Font = new System.Drawing.Font("Armata", 10F);
            this.cRadioButtonSettingsTheme6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cRadioButtonSettingsTheme6.Location = new System.Drawing.Point(96, 50);
            this.cRadioButtonSettingsTheme6.Name = "cRadioButtonSettingsTheme6";
            this.cRadioButtonSettingsTheme6.RadioButtonHeight = 18;
            this.cRadioButtonSettingsTheme6.Size = new System.Drawing.Size(88, 18);
            this.cRadioButtonSettingsTheme6.TabIndex = 5;
            this.cRadioButtonSettingsTheme6.TabStop = true;
            this.cRadioButtonSettingsTheme6.Text = "Theme 6";
            this.cRadioButtonSettingsTheme6.TextStyle = CCL.eTextStyle.Normal;
            this.cRadioButtonSettingsTheme6.UseVisualStyleBackColor = false;
            this.cRadioButtonSettingsTheme6.CheckedChanged += new System.EventHandler(this.cRadioButtonSettingsTheme6_CheckedChanged);
            // 
            // cRadioButtonSettingsTheme5
            // 
            this.cRadioButtonSettingsTheme5.BackColor = System.Drawing.Color.Transparent;
            this.cRadioButtonSettingsTheme5.CheckMarkSize = 10;
            this.cRadioButtonSettingsTheme5.Font = new System.Drawing.Font("Armata", 10F);
            this.cRadioButtonSettingsTheme5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cRadioButtonSettingsTheme5.Location = new System.Drawing.Point(6, 50);
            this.cRadioButtonSettingsTheme5.Name = "cRadioButtonSettingsTheme5";
            this.cRadioButtonSettingsTheme5.RadioButtonHeight = 18;
            this.cRadioButtonSettingsTheme5.Size = new System.Drawing.Size(86, 18);
            this.cRadioButtonSettingsTheme5.TabIndex = 4;
            this.cRadioButtonSettingsTheme5.TabStop = true;
            this.cRadioButtonSettingsTheme5.Text = "Theme 5";
            this.cRadioButtonSettingsTheme5.TextStyle = CCL.eTextStyle.Normal;
            this.cRadioButtonSettingsTheme5.UseVisualStyleBackColor = false;
            this.cRadioButtonSettingsTheme5.CheckedChanged += new System.EventHandler(this.cRadioButtonSettingsTheme5_CheckedChanged);
            // 
            // cRadioButtonSettingsTheme4
            // 
            this.cRadioButtonSettingsTheme4.BackColor = System.Drawing.Color.Transparent;
            this.cRadioButtonSettingsTheme4.CheckMarkSize = 10;
            this.cRadioButtonSettingsTheme4.Font = new System.Drawing.Font("Armata", 10F);
            this.cRadioButtonSettingsTheme4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cRadioButtonSettingsTheme4.Location = new System.Drawing.Point(276, 26);
            this.cRadioButtonSettingsTheme4.Name = "cRadioButtonSettingsTheme4";
            this.cRadioButtonSettingsTheme4.RadioButtonHeight = 18;
            this.cRadioButtonSettingsTheme4.Size = new System.Drawing.Size(88, 18);
            this.cRadioButtonSettingsTheme4.TabIndex = 3;
            this.cRadioButtonSettingsTheme4.TabStop = true;
            this.cRadioButtonSettingsTheme4.Text = "Theme 4";
            this.cRadioButtonSettingsTheme4.TextStyle = CCL.eTextStyle.Normal;
            this.cRadioButtonSettingsTheme4.UseVisualStyleBackColor = false;
            this.cRadioButtonSettingsTheme4.CheckedChanged += new System.EventHandler(this.cRadioButtonSettingsTheme4_CheckedChanged);
            // 
            // cRadioButtonSettingsTheme3
            // 
            this.cRadioButtonSettingsTheme3.BackColor = System.Drawing.Color.Transparent;
            this.cRadioButtonSettingsTheme3.CheckMarkSize = 10;
            this.cRadioButtonSettingsTheme3.Font = new System.Drawing.Font("Armata", 10F);
            this.cRadioButtonSettingsTheme3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cRadioButtonSettingsTheme3.Location = new System.Drawing.Point(186, 26);
            this.cRadioButtonSettingsTheme3.Name = "cRadioButtonSettingsTheme3";
            this.cRadioButtonSettingsTheme3.RadioButtonHeight = 18;
            this.cRadioButtonSettingsTheme3.Size = new System.Drawing.Size(86, 18);
            this.cRadioButtonSettingsTheme3.TabIndex = 2;
            this.cRadioButtonSettingsTheme3.TabStop = true;
            this.cRadioButtonSettingsTheme3.Text = "Theme 3";
            this.cRadioButtonSettingsTheme3.TextStyle = CCL.eTextStyle.Normal;
            this.cRadioButtonSettingsTheme3.UseVisualStyleBackColor = false;
            this.cRadioButtonSettingsTheme3.CheckedChanged += new System.EventHandler(this.cRadioButtonSettingsTheme3_CheckedChanged);
            // 
            // cRadioButtonSettingsTheme2
            // 
            this.cRadioButtonSettingsTheme2.BackColor = System.Drawing.Color.Transparent;
            this.cRadioButtonSettingsTheme2.CheckMarkSize = 10;
            this.cRadioButtonSettingsTheme2.Font = new System.Drawing.Font("Armata", 10F);
            this.cRadioButtonSettingsTheme2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cRadioButtonSettingsTheme2.Location = new System.Drawing.Point(96, 26);
            this.cRadioButtonSettingsTheme2.Name = "cRadioButtonSettingsTheme2";
            this.cRadioButtonSettingsTheme2.RadioButtonHeight = 18;
            this.cRadioButtonSettingsTheme2.Size = new System.Drawing.Size(86, 18);
            this.cRadioButtonSettingsTheme2.TabIndex = 1;
            this.cRadioButtonSettingsTheme2.TabStop = true;
            this.cRadioButtonSettingsTheme2.Text = "Theme 2";
            this.cRadioButtonSettingsTheme2.TextStyle = CCL.eTextStyle.Normal;
            this.cRadioButtonSettingsTheme2.UseVisualStyleBackColor = false;
            this.cRadioButtonSettingsTheme2.CheckedChanged += new System.EventHandler(this.cRadioButtonSettingsTheme2_CheckedChanged);
            // 
            // cRadioButtonSettingsTheme1
            // 
            this.cRadioButtonSettingsTheme1.BackColor = System.Drawing.Color.Transparent;
            this.cRadioButtonSettingsTheme1.CheckMarkSize = 10;
            this.cRadioButtonSettingsTheme1.Font = new System.Drawing.Font("Armata", 10F);
            this.cRadioButtonSettingsTheme1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cRadioButtonSettingsTheme1.Location = new System.Drawing.Point(6, 26);
            this.cRadioButtonSettingsTheme1.Name = "cRadioButtonSettingsTheme1";
            this.cRadioButtonSettingsTheme1.RadioButtonHeight = 18;
            this.cRadioButtonSettingsTheme1.Size = new System.Drawing.Size(84, 18);
            this.cRadioButtonSettingsTheme1.TabIndex = 0;
            this.cRadioButtonSettingsTheme1.TabStop = true;
            this.cRadioButtonSettingsTheme1.Text = "Theme 1";
            this.cRadioButtonSettingsTheme1.TextStyle = CCL.eTextStyle.Normal;
            this.cRadioButtonSettingsTheme1.UseVisualStyleBackColor = false;
            this.cRadioButtonSettingsTheme1.CheckedChanged += new System.EventHandler(this.cRadioButtonSettingsTheme1_CheckedChanged);
            // 
            // cButton_cancelAppSettings
            // 
            this.cButton_cancelAppSettings.DrawBorder = true;
            this.cButton_cancelAppSettings.Font = new System.Drawing.Font("Armata", 10F);
            this.cButton_cancelAppSettings.Location = new System.Drawing.Point(356, 241);
            this.cButton_cancelAppSettings.Name = "cButton_cancelAppSettings";
            this.cButton_cancelAppSettings.Size = new System.Drawing.Size(100, 35);
            this.cButton_cancelAppSettings.TabIndex = 6;
            this.cButton_cancelAppSettings.Text = "Cancel";
            this.cButton_cancelAppSettings.TextStyle = CCL.eTextStyle.Normal;
            this.cButton_cancelAppSettings.UseVisualStyleBackColor = true;
            this.cButton_cancelAppSettings.Click += new System.EventHandler(this.cButton_cancelAppSettings_Click);
            // 
            // cButton_saveAppSettings
            // 
            this.cButton_saveAppSettings.DrawBorder = true;
            this.cButton_saveAppSettings.Font = new System.Drawing.Font("Armata", 10F);
            this.cButton_saveAppSettings.Location = new System.Drawing.Point(250, 241);
            this.cButton_saveAppSettings.Name = "cButton_saveAppSettings";
            this.cButton_saveAppSettings.Size = new System.Drawing.Size(100, 35);
            this.cButton_saveAppSettings.TabIndex = 5;
            this.cButton_saveAppSettings.Text = "Save";
            this.cButton_saveAppSettings.TextStyle = CCL.eTextStyle.Normal;
            this.cButton_saveAppSettings.UseVisualStyleBackColor = true;
            this.cButton_saveAppSettings.Click += new System.EventHandler(this.cButton_saveAppSettings_Click);
            // 
            // cGroupBox1
            // 
            this.cGroupBox1.Controls.Add(this.cLabel2);
            this.cGroupBox1.Controls.Add(this.cLabel_dataFolderPath);
            this.cGroupBox1.Controls.Add(this.cButton_selectFolder);
            this.cGroupBox1.Font = new System.Drawing.Font("Armata", 12F, System.Drawing.FontStyle.Bold);
            this.cGroupBox1.Location = new System.Drawing.Point(3, 3);
            this.cGroupBox1.Name = "cGroupBox1";
            this.cGroupBox1.Radius = 10;
            this.cGroupBox1.Size = new System.Drawing.Size(453, 144);
            this.cGroupBox1.TabIndex = 1;
            this.cGroupBox1.TabStop = false;
            this.cGroupBox1.Text = "Saving things here";
            this.cGroupBox1.TextAlignment = System.Drawing.StringAlignment.Near;
            this.cGroupBox1.TextStyle = CCL.eTextStyle.Title5;
            // 
            // cLabel2
            // 
            this.cLabel2.BackColor = System.Drawing.Color.Transparent;
            this.cLabel2.Font = new System.Drawing.Font("Armata", 10F);
            this.cLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cLabel2.Location = new System.Drawing.Point(3, 80);
            this.cLabel2.Name = "cLabel2";
            this.cLabel2.OverrideFontSize = 12F;
            this.cLabel2.Size = new System.Drawing.Size(335, 61);
            this.cLabel2.TabIndex = 3;
            this.cLabel2.Text = "Machines and tools are saved here:\r\n...\\CNC Vision\\Machines\r\n...\\CNC Vision\\Tools" +
    "";
            this.cLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cLabel2.TextStyle = CCL.eTextStyle.Normal;
            this.cLabel2.UseFontSizeOverride = false;
            // 
            // cLabel_dataFolderPath
            // 
            this.cLabel_dataFolderPath.BackColor = System.Drawing.Color.Transparent;
            this.cLabel_dataFolderPath.Font = new System.Drawing.Font("Armata", 10F);
            this.cLabel_dataFolderPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cLabel_dataFolderPath.Location = new System.Drawing.Point(6, 23);
            this.cLabel_dataFolderPath.Name = "cLabel_dataFolderPath";
            this.cLabel_dataFolderPath.OverrideFontSize = 12F;
            this.cLabel_dataFolderPath.Size = new System.Drawing.Size(441, 31);
            this.cLabel_dataFolderPath.TabIndex = 2;
            this.cLabel_dataFolderPath.Text = "Nothing selected";
            this.cLabel_dataFolderPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cLabel_dataFolderPath.TextStyle = CCL.eTextStyle.Normal;
            this.cLabel_dataFolderPath.UseFontSizeOverride = false;
            // 
            // cButton_selectFolder
            // 
            this.cButton_selectFolder.DrawBorder = true;
            this.cButton_selectFolder.Font = new System.Drawing.Font("Armata", 10F);
            this.cButton_selectFolder.Location = new System.Drawing.Point(6, 57);
            this.cButton_selectFolder.Name = "cButton_selectFolder";
            this.cButton_selectFolder.Size = new System.Drawing.Size(100, 20);
            this.cButton_selectFolder.TabIndex = 0;
            this.cButton_selectFolder.Text = "Select";
            this.cButton_selectFolder.TextStyle = CCL.eTextStyle.Normal;
            this.cButton_selectFolder.UseVisualStyleBackColor = true;
            this.cButton_selectFolder.Click += new System.EventHandler(this.cButton_selectFolder_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Machine";
            // 
            // tabPanelSelector1
            // 
            this.tabPanelSelector1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tabPanelSelector1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tabPanelSelector1.BaseTabControl = this.cTabControl1;
            this.tabPanelSelector1.ButtonMargin = 5;
            this.tabPanelSelector1.Font = new System.Drawing.Font("Armata", 12F, System.Drawing.FontStyle.Bold);
            this.tabPanelSelector1.ItemHeight = 30;
            this.tabPanelSelector1.LastItemsToBottom = 0;
            this.tabPanelSelector1.Location = new System.Drawing.Point(1, 25);
            this.tabPanelSelector1.Name = "tabPanelSelector1";
            this.tabPanelSelector1.PanelCloseSize = 38;
            this.tabPanelSelector1.PanelIsOpen = false;
            this.tabPanelSelector1.PanelOpenWidth = 180;
            this.tabPanelSelector1.Size = new System.Drawing.Size(38, 674);
            this.tabPanelSelector1.TabIndex = 1;
            this.tabPanelSelector1.Text = "tabPanelSelector1";
            this.tabPanelSelector1.TextAlignment = System.Drawing.StringAlignment.Near;
            this.tabPanelSelector1.TextStyle = CCL.eTextStyle.Title5;
            // 
            // ch_Tool_ID
            // 
            this.ch_Tool_ID.Text = "ID";
            this.ch_Tool_ID.Width = 40;
            // 
            // ch_Tool_Name
            // 
            this.ch_Tool_Name.Text = "Name";
            this.ch_Tool_Name.Width = 150;
            // 
            // ch_Tool_Type
            // 
            this.ch_Tool_Type.Text = "Type";
            this.ch_Tool_Type.Width = 100;
            // 
            // ch_Tool_CD
            // 
            this.ch_Tool_CD.Text = "CD";
            // 
            // ch_Tool_SD
            // 
            this.ch_Tool_SD.Text = "SD";
            // 
            // ch_Tool_FL
            // 
            this.ch_Tool_FL.Text = "FL";
            // 
            // ch_Tool_F
            // 
            this.ch_Tool_F.Text = "F";
            // 
            // ch_Tool_A
            // 
            this.ch_Tool_A.Text = "A";
            // 
            // ch_Tool_R
            // 
            this.ch_Tool_R.Text = "R";
            // 
            // ch_Tool_W
            // 
            this.ch_Tool_W.Text = "W";
            // 
            // schemeComponent1
            // 
            this.schemeComponent1.BackgroundColor = System.Drawing.Color.DarkGray;
            this.schemeComponent1.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.schemeComponent1.ForeColor = System.Drawing.Color.Black;
            this.schemeComponent1.MouseDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.schemeComponent1.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.schemeComponent1.SchemeColor = System.Drawing.Color.Gainsboro;
            this.schemeComponent1.SelectedColor = System.Drawing.Color.Gray;
            // 
            // schemeComponent2
            // 
            this.schemeComponent2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.schemeComponent2.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.schemeComponent2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.schemeComponent2.MouseDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.schemeComponent2.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.schemeComponent2.SchemeColor = System.Drawing.Color.DeepSkyBlue;
            this.schemeComponent2.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 700);
            this.Controls.Add(this.tabPanelSelector1);
            this.Controls.Add(this.cTabControl1);
            this.CustomSchemeComponent = this.schemeComponent2;
            this.MinimumSize = new System.Drawing.Size(870, 700);
            this.Name = "Form_Main";
            this.Text = "CNC VISION";
            this.cTabControl1.ResumeLayout(false);
            this.tabPage_Controls.ResumeLayout(false);
            this.tabPage_Controls.PerformLayout();
            this.cTabControl2.ResumeLayout(false);
            this.tabPage_move.ResumeLayout(false);
            this.cPanel_manualMove.ResumeLayout(false);
            this.cPanel_manualMove.PerformLayout();
            this.tabPage_spindle.ResumeLayout(false);
            this.cTabControl_spindleLaser.ResumeLayout(false);
            this.tabPage_spindleControls.ResumeLayout(false);
            this.tabPage_spindleControls.PerformLayout();
            this.tabPage_laserControls.ResumeLayout(false);
            this.tabPage_override.ResumeLayout(false);
            this.cGroupBox_overrideRapid.ResumeLayout(false);
            this.cGroupBox_overrideRapid.PerformLayout();
            this.cGroupBox_overrideSpindle.ResumeLayout(false);
            this.cGroupBox_overrideSpindle.PerformLayout();
            this.cGroupBox_overrideFeed.ResumeLayout(false);
            this.cGroupBox_overrideFeed.PerformLayout();
            this.tabPage_file.ResumeLayout(false);
            this.tabPage_file.PerformLayout();
            this.tabPage_Machines.ResumeLayout(false);
            this.cContextMenuStrip_editMachine.ResumeLayout(false);
            this.tabPage_Tools.ResumeLayout(false);
            this.tabPage_Tools.PerformLayout();
            this.cContextMenuStrip_editToolValues.ResumeLayout(false);
            this.tabPage_Settings.ResumeLayout(false);
            this.cGroupBox2.ResumeLayout(false);
            this.cGroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CCL.Controls.CTabControl cTabControl1;
        private System.Windows.Forms.TabPage tabPage_Controls;
        private System.Windows.Forms.TabPage tabPage_Machines;
        private CCL.Controls.TabPanelSelector tabPanelSelector1;
        private System.Windows.Forms.TabPage tabPage_Tools;
        private System.Windows.Forms.TabPage tabPage_Settings;
        private CCL.Controls.CGroupBox cGroupBox1;
        private CCL.Controls.CButton cButton_selectFolder;
        private CCL.Controls.CLabel cLabel_dataFolderPath;
        private CCL.Controls.CListView cListView_tools;
        private CCL.Controls.CLabel cLabel1;
        private CCL.Controls.CButton cButton_cancelToolSave;
        private CCL.Controls.CButton cButton_saveTools;
        private CCL.Controls.CContextMenuStrip cContextMenuStrip_editToolValues;
        private System.Windows.Forms.ToolStripMenuItem addNewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem duplicateToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private CCL.Controls.CCheckBox cCheckBox_editToolValues;
        private CCL.Controls.CLabel cLabel2;
        private CCL.Controls.CButton cButton_cancelAppSettings;
        private CCL.Controls.CButton cButton_saveAppSettings;
        private System.Windows.Forms.ToolStripMenuItem reloadToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader ch_Tool_ID;
        private System.Windows.Forms.ColumnHeader ch_Tool_Name;
        private System.Windows.Forms.ColumnHeader ch_Tool_Type;
        private System.Windows.Forms.ColumnHeader ch_Tool_CD;
        private System.Windows.Forms.ColumnHeader ch_Tool_SD;
        private System.Windows.Forms.ColumnHeader ch_Tool_FL;
        private System.Windows.Forms.ColumnHeader ch_Tool_F;
        private System.Windows.Forms.ColumnHeader ch_Tool_A;
        private System.Windows.Forms.ColumnHeader ch_Tool_R;
        private System.Windows.Forms.ColumnHeader ch_Tool_W;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private CCL.Controls.CListView cListView_machines;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private CCL.Controls.CButton cButton_cancelMachineSave;
        private CCL.Controls.CButton cButton_saveMachines;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private CCL.Controls.CContextMenuStrip cContextMenuStrip_editMachine;
        private System.Windows.Forms.ToolStripMenuItem addMachineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem duplicateMachineToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem exportMachineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importMachineToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem deleteMachineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reloadMachinesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem editMachineToolStripMenuItem;
        private CCL.Controls.CDropDown cDropDown_machineProfiles;
        private CCL.Controls.CSwitch cSwitch_openPort;
        private CCL.Controls.CLabel cLabel4;
        private CCL.Controls.CLabel cLabel3;
        private CCL.Controls.CLabel cLabel_wposX;
        private CCL.Controls.CLabel cLabel13;
        private CCL.Controls.CLabel cLabel12;
        private CCL.Controls.CLabel cLabel11;
        private CCL.Controls.CLabel cLabel_mposZ;
        private CCL.Controls.CLabel cLabel_mposY;
        private CCL.Controls.CLabel cLabel_mposX;
        private CCL.Controls.CLabel cLabel_wposZ;
        private CCL.Controls.CLabel cLabel_wposY;
        private CCL.Controls.CLinkLabel cLinkLabel_zeroX;
        private CCL.Controls.CLinkLabel cLinkLabel_zeroZ;
        private CCL.Controls.CLinkLabel cLinkLabel_zeroY;
        private CCL.Controls.CLinkLabel cLinkLabel_zeroAll;
        private CCL.Controls.CButton cButton_reset;
        private CCL.Controls.CButton cButton_unlock;
        private CCL.Controls.CProgressBar cProgressBar1;
        private CCL.Controls.CButton cButton_home;
        private CCL.Controls.CLabel cLabel15;
        private CCL.Controls.CLabel cLabel_fs;
        private CCL.Controls.CButton cButton_hold;
        private CCL.Controls.CButton cButton_startResume;
        private CCL.Controls.CTabSelector cTabSelector1;
        private CCL.Controls.CTabControl cTabControl2;
        private System.Windows.Forms.TabPage tabPage_move;
        private System.Windows.Forms.TabPage tabPage_spindle;
        private CCL.Controls.CLabel cLabel_percentage;
        private System.Windows.Forms.ColumnHeader columnHeader19;
        private CCL.Controls.CLabel cLabel_machineState;
        private CCL.Controls.CButton cButton_sendCommand;
        private CCL.Controls.CTextBox cTextBox_command;
        private CCL.Controls.CRichTextBox cRichTextBox1;
        private CCL.Controls.CSwitch cSwitch_enableWeakLaser;
        private CCL.Controls.CSwitch cSwitch_enableStrongLaser;
        private CCL.Controls.CButton cButton_showLaserArea;
        private System.Windows.Forms.TabPage tabPage_override;
        private System.Windows.Forms.TabPage tabPage_file;
        private CCL.Controls.CGroupBox cGroupBox_overrideFeed;
        private CCL.Controls.CRadioButton cRadioButton_overrideFeedAddTen;
        private CCL.Controls.CRadioButton cRadioButton_overrideFeedAddOne;
        private CCL.Controls.CButton cButton_overrideFeedReduce;
        private CCL.Controls.CButton cButton_overrideFeedIncrease;
        private CCL.Controls.CGroupBox cGroupBox_overrideSpindle;
        private CCL.Controls.CButton cButton_overrideSpindleReduce;
        private CCL.Controls.CButton cButton_overrideSpindleIncrease;
        private CCL.Controls.CRadioButton cRadioButton_overrideSpindleAddTen;
        private CCL.Controls.CRadioButton cRadioButton_overrideSpindleAddOne;
        private CCL.Controls.CGroupBox cGroupBox_overrideRapid;
        private CCL.Controls.CRadioButton cRadioButton_overrideRapidFull;
        private CCL.Controls.CRadioButton cRadioButton_overrideRapidQuarter;
        private CCL.Controls.CRadioButton cRadioButton_overrideRapidHalf;
        private CCL.Controls.CLabel cLabel_usedTime;
        private CCL.Controls.CButton cButton_openFile;
        private CCL.Controls.CLabel cLabel_endTime;
        private CCL.Controls.CLabel cLabel16;
        private CCL.Controls.CLabel cLabel_startTime;
        private CCL.Controls.CButton cButton_sendFile;
        private CCL.Controls.CButton cButton_stopFile;
        private CCL.Controls.CListView cListView_fileTools;
        private System.Windows.Forms.ColumnHeader columnHeader20;
        private System.Windows.Forms.ColumnHeader columnHeader21;
        private System.Windows.Forms.ColumnHeader columnHeader22;
        private System.Windows.Forms.ColumnHeader columnHeader23;
        private System.Windows.Forms.ColumnHeader columnHeader24;
        private CCL.Controls.CTabControl cTabControl_spindleLaser;
        private System.Windows.Forms.TabPage tabPage_spindleControls;
        private System.Windows.Forms.TabPage tabPage_laserControls;
        private CCL.Controls.CSwitch cSwitch_enableSpindle;
        private CCL.Controls.CLabel cLabel_wcoZ;
        private CCL.Controls.CLabel cLabel_wcoY;
        private CCL.Controls.CLabel cLabel_wcoX;
        private CCL.Controls.CLabel cLabel8;
        private CCL.Controls.CCheckBox cCheckBox_showQuery;
        private CCL.Controls.CButton cButton_Zm;
        private CCL.Controls.CButton cButton_ZZero;
        private CCL.Controls.CButton cButton_Zp;
        private CCL.Controls.CButton cButton_XpYp;
        private CCL.Controls.CButton cButton_Yp;
        private CCL.Controls.CButton cButton_XmYp;
        private CCL.Controls.CButton cButton_Xm;
        private CCL.Controls.CButton cButton_XYZero;
        private CCL.Controls.CButton cButton_Xp;
        private CCL.Controls.CButton cButton_XmYm;
        private CCL.Controls.CButton cButton_XpYm;
        private CCL.Controls.CButton cButton_Ym;
        private CCL.Controls.CPanel cPanel_manualMove;
        private CCL.Controls.CTextBox cTextBox_feedRate;
        private CCL.Controls.CTextBox cTextBox_distance;
        private CCL.Controls.CLabel cLabel6;
        private CCL.Controls.CLabel cLabel5;
        private CCL.Controls.CRadioButton cRadioButton_g1;
        private CCL.Controls.CRadioButton cRadioButton_g0;
        private CCL.Controls.CButton cButton_clear;
        private CCL.Controls.CLabel cLabel_approximate;
        private CCL.Controls.CLabel cLabel7;
        private CCL.Controls.CDropDown cDropDown_workSpace;
        private CCL.Controls.CCheckBox cCheckBox_lockX;
        private CCL.Controls.CCheckBox cCheckBox_lockY;
        private GRBL.Controls.JoggingKnob joggingKnob1;
        private CCL.Controls.CButton cButton_touchThePlate;
        private CCL.Controls.CLabel cLabel9;
        private CCL.Controls.CLabel cLabel10;
        private CCL.Controls.CLabel cLabel14;
        private CCL.Controls.CLabel cLabel_overrideRapid;
        private CCL.Controls.CLabel cLabel_overrideSpindle;
        private CCL.Controls.CLabel cLabel_overrideFeed;
        private CCL.Controls.CGroupBox cGroupBox2;
        private CCL.Controls.CRadioButton cRadioButtonSettingsTheme6;
        private CCL.Controls.CRadioButton cRadioButtonSettingsTheme5;
        private CCL.Controls.CRadioButton cRadioButtonSettingsTheme4;
        private CCL.Controls.CRadioButton cRadioButtonSettingsTheme3;
        private CCL.Controls.CRadioButton cRadioButtonSettingsTheme2;
        private CCL.Controls.CRadioButton cRadioButtonSettingsTheme1;
        private CCL.SchemeComponent schemeComponent1;
        private CCL.SchemeComponent schemeComponent2;
    }
}