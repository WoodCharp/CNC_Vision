using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

using CCL;
using CCL.Controls;
using CNCV.Generator;
using CNCV.Machines;
using CNCV.Tools;

using GRBL;
using GRBL.Wiki;

namespace CNCV.Pages
{
    public partial class Form_Main : CForm, IManager, IGRBL
    {
        public Manager Manager => Manager.Instance;
        public GRBLManager GRBLFramework => GRBLManager.Instance;

        private System.Windows.Forms.Timer grblTimer;

        private bool ToolChangeWindowVisible = false;
        private Form_ToolChangeWindow ToolChangeWindow;
        private int ToolChangeIndex = 0;

        private bool PositioningAutoSet = true, PositioningDropaDownSet = false;
        private ePositioning CurPositioning = ePositioning.Absolute;

        public Form_Main()
        {
            InitializeComponent();

            //Setting up theme
            var skinmanager = CSkinManager.Instance;
            skinmanager.AddFormToManage(this);
            skinmanager.SchemePreset = SchemePreset;

            //Adding icons to tab panel selector
            tabPanelSelector1.Icons.Add(Properties.Resources.Controls);
            tabPanelSelector1.Icons.Add(Properties.Resources.Machines);
            tabPanelSelector1.Icons.Add(Properties.Resources.Tools);
            //tabPanelSelector1.Icons.Add(Properties.Resources.GC);
            tabPanelSelector1.Icons.Add(Properties.Resources.Gear001);

            //Set active form to GRBL Framework
            GRBLFramework.CurrentForm = this;
            //Add action to program end
            GRBLFramework.FileHasBeenSent = new Action(PgmEnd);
            //After check action
            GRBLFramework.CheckEndAction = new Action(CheckComplete);
            //Set console box to GRBL Framework
            GRBLFramework.ConsoleBox = cRichTextBox1;
            GRBLFramework.ShowQuery = false;
            //Set up jogging knob to GRBL Framework
            GRBLFramework.joggingKnob = joggingKnob1;
            GRBLFramework.InitializeJoggingKnob();
            //When message is received from GRBL
            GRBLFramework.MessageReceived = new Action(MessageReceivedAction);
            GRBLFramework.ShowMessagesInConsole_ALARM = false;
            GRBLFramework.ShowMessagesInConsole_ERROR = false;
            GRBLFramework.ShowMessagesInConsole_MSG = false;

            //Set up timer to update UI stuff
            grblTimer = new System.Windows.Forms.Timer();
            grblTimer.Interval = 500;
            grblTimer.Tick += new EventHandler(grblTimer_Tick);

            //Add index change event to work space drop down box
            cDropDown_workSpace.SelectedIndexChanged += new EventHandler(cDropDown_workSpace_SelectedIndexChanged);

            //Tool change window, shows tool info and continues machining
            ToolChangeWindow = new Form_ToolChangeWindow();

            //Load stuff
            LoadAppSettings();
            LoadTools();
            LoadMachines(true);

            //Show splash screen
            /*using (Form_SplashScreen ss = new Form_SplashScreen())
            {
                ss.ShowDialog();
            }*/
        }

        #region Preferences

        /// <summary>
        /// Load settings to settings tab
        /// </summary>
        private void LoadAppSettings()
        {
            //If app settings are loaded
            if(Manager.LoadAppSettings())
            {
                //Select settings theme
                switch (Manager.CurrentSettings.SchemeID)
                {
                    case 0:
                        cRadioButtonSettingsTheme1.Checked = true;
                        SchemePreset = CSkinManager.SchemePresets.DARK_ORANGE;
                        break;
                    case 1:
                        cRadioButtonSettingsTheme2.Checked = true;
                        SchemePreset = CSkinManager.SchemePresets.DARK_BLUE;
                        break;
                    case 2:
                        cRadioButtonSettingsTheme3.Checked = true;
                        SchemePreset = CSkinManager.SchemePresets.LIGHT_BLUE;
                        break;
                    case 3:
                        cRadioButtonSettingsTheme4.Checked = true;
                        SchemePreset = CSkinManager.SchemePresets.LIGHT_ORANGE;
                        break;
                    case 4:
                        cRadioButtonSettingsTheme5.Checked = true;
                        CustomSchemeComponent = schemeComponent1;
                        SchemePreset = CSkinManager.SchemePresets.CUSTOM;
                        break;
                    case 5:
                        cRadioButtonSettingsTheme6.Checked = true;
                        CustomSchemeComponent = schemeComponent2;
                        SchemePreset = CSkinManager.SchemePresets.CUSTOM;
                        break;
                }

                //Show current data folder path
                cLabel_dataFolderPath.Text = Manager.GetDataFolderPath();
            }

            //If there is no path, show alternative text
            if (cLabel_dataFolderPath.Text.Length <= 0)
                cLabel_dataFolderPath.Text = "Select folder";
        }

        private void cButton_selectFolder_Click(object sender, EventArgs e)
        {
            //Get folder path
            string folder = PathPicker.GetFolder();
            //Set file path
            string file = folder + @"\AppSettings.txt";

            //If destination folder already contains settings file, ask if user wants to use the old one
            if (Manager.FileManager.AppSettingsExist(file))
            {
                DialogResult res = MessageBox.Show("App settings found, use it ?", "CNC Vision", MessageBoxButtons.YesNo);
                if(res == DialogResult.Yes)
                {
                    Properties.Settings.Default.DataFolder = folder;
                    Properties.Settings.Default.Save();
                    Properties.Settings.Default.Reload();
                    Manager.LoadAppSettings();

                    cLabel_dataFolderPath.Text = Manager.CurrentSettings.DataFolderPath;
                    return;
                }
            }

            //If returned string is empty, choose the one in application settings
            if (folder.Length <= 0)
            {
                //And if even the property setting is empty set nothing text else use property setting
                if (Properties.Settings.Default.DataFolder.Length <= 0)
                {
                    cLabel_dataFolderPath.Text = "Nothing selected";
                    return;
                }
            }

            //Show data folder path
            cLabel_dataFolderPath.Text = folder;
        }


        private void cRadioButtonSettingsTheme1_CheckedChanged(object sender, EventArgs e)
        {
            SchemePreset = CSkinManager.SchemePresets.DARK_ORANGE;
        }

        private void cRadioButtonSettingsTheme2_CheckedChanged(object sender, EventArgs e)
        {
            SchemePreset = CSkinManager.SchemePresets.DARK_BLUE;
        }

        private void cRadioButtonSettingsTheme3_CheckedChanged(object sender, EventArgs e)
        {
            SchemePreset = CSkinManager.SchemePresets.LIGHT_BLUE;
        }

        private void cRadioButtonSettingsTheme4_CheckedChanged(object sender, EventArgs e)
        {
            SchemePreset = CSkinManager.SchemePresets.LIGHT_ORANGE;
        }

        private void cRadioButtonSettingsTheme5_CheckedChanged(object sender, EventArgs e)
        {
            CustomSchemeComponent = schemeComponent1;
            SchemePreset = CSkinManager.SchemePresets.CUSTOM;

        }

        private void cRadioButtonSettingsTheme6_CheckedChanged(object sender, EventArgs e)
        {
            CustomSchemeComponent = schemeComponent2;
            SchemePreset = CSkinManager.SchemePresets.CUSTOM;
        }


        private void cButton_saveAppSettings_Click(object sender, EventArgs e)
        {
            AppSetting appSetting = new AppSetting();

            //Check if folders exists
            if (!Manager.FileManager.DataFolderExist())
                Directory.CreateDirectory(cLabel_dataFolderPath.Text);

            if (!Manager.FileManager.ToolsFolderExist())
                Directory.CreateDirectory(Manager.FileManager.ToolsFolder);

            if (!Manager.FileManager.MachinesFolderExist())
                Directory.CreateDirectory(Manager.FileManager.MachinesFolder);

            if (cRadioButtonSettingsTheme1.Checked)
                appSetting.SchemeID = 0;
            else if (cRadioButtonSettingsTheme2.Checked)
                appSetting.SchemeID = 1;
            else if (cRadioButtonSettingsTheme3.Checked)
                appSetting.SchemeID = 2;
            else if (cRadioButtonSettingsTheme4.Checked)
                appSetting.SchemeID = 3;
            else if (cRadioButtonSettingsTheme5.Checked)
                appSetting.SchemeID = 4;
            else if (cRadioButtonSettingsTheme6.Checked)
                appSetting.SchemeID = 5;

            //Save new directory to application settings
            Properties.Settings.Default.DataFolder = cLabel_dataFolderPath.Text;
            Properties.Settings.Default.Save();
            Properties.Settings.Default.Reload();

            appSetting.DataFolderPath = Properties.Settings.Default.DataFolder;

            //Save settings
            Manager.SaveNewSettings(appSetting);
        }

        private void cButton_cancelAppSettings_Click(object sender, EventArgs e)
        {
            //Simply reload settings
            LoadAppSettings();
        }

        #endregion

        #region Tools

        /// <summary>
        /// Load tools to tools tab list view
        /// </summary>
        private void LoadTools()
        {
            //Clear list view items
            cListView_tools.Items.Clear();

            //Read tools folder again
            Manager.ReloadToolsList();

            //If no files found, no reason to continue
            if (Manager.CNCTools == null || Manager.CNCTools.Count <= 0)
                return;

            //Loop tools and add them to list view
            foreach (CNCTool tool in Manager.CNCTools)
            {
                ListViewItem item = new ListViewItem(tool.ID.ToString());
                item.SubItems.Add(tool.Name);
                item.SubItems.Add(tool.ToolType.ToString());
                item.SubItems.Add(tool.CD.ToString());
                item.SubItems.Add(tool.SD.ToString());
                item.SubItems.Add(tool.FL.ToString());
                item.SubItems.Add(tool.F.ToString());
                item.SubItems.Add(tool.A.ToString());
                item.SubItems.Add(tool.R.ToString());
                item.SubItems.Add(tool.W.ToString());

                cListView_tools.Items.Add(item);
            }
        }

        
        private void cContextMenuStrip_editToolValues_Opening(object sender, CancelEventArgs e)
        {
            //Choosing what items to show in context menu strip
            //If no item has been selected while opening context menu, disable buttons what needs the item
            if(cListView_tools.SelectedItem == null)
            {
                duplicateToolStripMenuItem.Enabled = false;
                exportToolStripMenuItem.Enabled = false;
                deleteToolStripMenuItem.Enabled = false;
            }
            else
            {
                duplicateToolStripMenuItem.Enabled = true;
                exportToolStripMenuItem.Enabled = true;
                deleteToolStripMenuItem.Enabled = true;
            }
        }

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Add new tool to list view
            Manager.AddEmptyTool(cListView_tools);
        }

        private void duplicateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Duplicates selected item on list view
            Manager.DuplicateTool(cListView_tools);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Remove tool from list view and delete tool file
            Manager.DeleteTool(cListView_tools);
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //This is to easily share tool files or move to another computer
            MessageBox.Show("Not yet.");
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //This is to easily add shared or moved tool from another computer
            MessageBox.Show("Not yet.");
        }

        private void reloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Reload tool files again and add them to list view
            LoadTools();
        }


        private void cCheckBox_editToolValues_CheckedChanged(object sender, EventArgs e)
        {
            //Enable value editing at list view
            cListView_tools.EnableItemEdit = cCheckBox_editToolValues.Checked;
        }

        private void cButton_saveTools_Click(object sender, EventArgs e)
        {
            //Save tools in list
            Manager.SaveToolsList(cListView_tools);

            //Reload files
            LoadTools();
        }

        private void cButton_cancelToolSave_Click(object sender, EventArgs e)
        {
            //Simply reload tools
            LoadTools();
        }

        #endregion

        #region Machine

        /// <summary>
        /// Load machine profiles to list view
        /// </summary>
        /// <param name="reload">If reading files again is needed</param>
        private void LoadMachines(bool reload)
        {
            //Clear profiles drop down box
            cDropDown_machineProfiles.Items.Clear();

            //Clear machines list view
            cListView_machines.Items.Clear();

            //If reload is needed, reads saved files again
            if (reload)
                Manager.ReloadMachinesList();

            //If no machines in manager machines list, nothingto show
            if (Manager.Machines == null || Manager.Machines.Count <= 0)
                return;

            //Loop all machines and add items to list view
            foreach (Machine machine in Manager.Machines)
            {
                ListViewItem item = new ListViewItem(machine.ID.ToString());
                item.SubItems.Add(machine.Name);
                item.SubItems.Add(machine.MachineType.ToString());
                item.SubItems.Add(machine.GetSettingValueByID(130).ToString());
                item.SubItems.Add(machine.GetSettingValueByID(131).ToString());
                item.SubItems.Add(machine.GetSettingValueByID(132).ToString());
                item.SubItems.Add(machine.VER);
                item.SubItems.Add(machine.OPT);

                cListView_machines.Items.Add(item);
            }

            //Update list view paint
            cListView_machines.Invalidate();

            //Add items to machine profiles drop down box if there is profiles at manager
            if(Manager.Machines.Count > 0)
            {
                foreach(Machine machine in Manager.Machines)
                {
                    cDropDown_machineProfiles.Items.Add(machine.Name);
                }
            }
        }

        private void cButton_saveMachines_Click(object sender, EventArgs e)
        {
            //Save machine profiles
            Manager.SaveMachinesList();

            //Load machine profiles again, no need to read files again. Machine editing differs from tool editing
            LoadMachines(false);
        }

        private void cButton_cancelMachineSave_Click(object sender, EventArgs e)
        {
            //Simply reload machines
            LoadMachines(true);
        }



        private void cContextMenuStrip_editMachine_Opening(object sender, CancelEventArgs e)
        {
            //Choosing what items to show in context menu strip
            //If no item has been selected while opening context menu, disable buttons what needs the item
            if (cListView_machines.SelectedItem == null)
            {
                duplicateMachineToolStripMenuItem.Enabled = false;
                exportMachineToolStripMenuItem.Enabled = false;
                deleteMachineToolStripMenuItem.Enabled = false;
            }
            else
            {
                duplicateMachineToolStripMenuItem.Enabled = true;
                exportMachineToolStripMenuItem.Enabled = true;
                deleteMachineToolStripMenuItem.Enabled = true;
            }
        }

        private void toolStripMenuItem_addNewMachine_Click(object sender, EventArgs e)
        {
            //Add new machine to list view
            Manager.AddEmptyMachine(cListView_machines);
        }

        private void duplicateMachineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Duplicate selected item in list view
            Manager.DuplicateMachine(cListView_machines.SelectedItem.Y_Index);

            //Load machines, reload not needed
            LoadMachines(false);
        }

        private void deleteMachineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Remove machine from list view and delete file
            Manager.DeleteMachine(cListView_machines);

            //Load machines, reload not needed
            LoadMachines(false);
        }

        private void exportMachineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //This is to easily share tool files or move to another computer
            MessageBox.Show("Not yet.");
        }

        private void importMachineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //This is to easily add shared or moved tool from another computer
            MessageBox.Show("Not yet.");
        }

        private void reloadMachinesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Simply reload machines
            LoadMachines(true);
        }

        private void editMachineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Get machine index
            int index = cListView_machines.SelectedItem.Y_Index;
            //Show machine editing window and pass down index
            using(Form_Machine fm = new Form_Machine(index))
            {
                fm.ShowDialog();
            }

            //Load machines, reload not needed
            LoadMachines(false);

            //Machine editing uses GRBL Framework to get GRBL setting. Setting this form again to GRBL Framework.
            GRBLFramework.CurrentForm = this;
        }

        #endregion

        #region Controls

        /// <summary>
        /// Enable and disable controls depending if opening or closing serial port.
        /// </summary>
        /// <param name="enable"></param>
        private void EnableControls(bool enable)
        {
            cLinkLabel_zeroAll.Enabled = enable;
            cLinkLabel_zeroX.Enabled = enable;
            cLinkLabel_zeroY.Enabled = enable;
            cLinkLabel_zeroZ.Enabled = enable;

            cDropDown_machineProfiles.Enabled = !enable;

            cButton_reset.Enabled = enable;
            cButton_unlock.Enabled = enable;
            cButton_home.Enabled = enable;
            cButton_hold.Enabled = enable;
            cButton_startResume.Enabled = enable;

            cButton_sendCommand.Enabled = enable;
            cTextBox_command.Enabled = enable;
            cCheckBox_showQuery.Enabled = enable;

            joggingKnob1.Enabled = enable;
            cCheckBox_lockX.Enabled = enable;
            cCheckBox_lockY.Enabled = enable;

            cSwitch_enableSpindle.Enabled = enable;
            cSwitch_enableStrongLaser.Enabled = enable;
            cSwitch_enableWeakLaser.Enabled = enable;
            cButton_showLaserArea.Enabled = enable;

            cPanel_manualMove.Enabled = enable;

            cButton_openFile.Enabled = enable;

            if(!enable)
            {
                cButton_sendFile.Enabled = false;
                cButton_stopFile.Enabled = false;
            }

            cGroupBox_overrideFeed.Enabled = enable;
            cGroupBox_overrideRapid.Enabled = enable;
            cGroupBox_overrideSpindle.Enabled = enable;

            cButton_touchThePlate.Enabled = enable;
        }

        //Open and close serial port
        private void cSwitch_openPort_Click(object sender, EventArgs e)
        {
            //Open serial port
            if (cSwitch_openPort.IsOn)
            {
                //If machine profile has not been selected, return
                if (cDropDown_machineProfiles.Items.Count <= 0 || cDropDown_machineProfiles.SelectedIndex < 0)
                {
                    //Set switch state back to off
                    cSwitch_openPort.IsOn = false;
                    return;
                }

                //GRBL Framework sets workspace to G54 at serial open
                cDropDown_workSpace.SelectedIndex = 0;
                //Open serial port
                GRBLFramework.OpenSerialPort(Manager.Machines[cDropDown_machineProfiles.SelectedIndex].PortData);
                //Start timer to update UI stuff
                grblTimer.Start();

                //Choosing what spindle type controls is shown
                if (Manager.Machines[cDropDown_machineProfiles.SelectedIndex].MachineType == eMachine.Router)
                {
                    cTabControl_spindleLaser.SelectedIndex = 1;
                    cSliderRouterRPM.MinValue = Manager.Machines[cDropDown_machineProfiles.SelectedIndex].GetSettingValueByID(31);
                    cSliderRouterRPM.MaxValue = Manager.Machines[cDropDown_machineProfiles.SelectedIndex].GetSettingValueByID(30);
                    cSliderRouterRPM.Enabled = true;
                    cButtonSetRPM.Enabled = true;
                }
                else
                {
                    cTabControl_spindleLaser.SelectedIndex = 2;
                    cSliderRouterRPM.Enabled = false;
                    cButtonSetRPM.Enabled = false;
                }
                
                EnableControls(true);

                cDropDownPositioning.SelectedIndex = 0;

                //Setting OPT value to GRBL framework. It reads the buffer size from it.
                GRBLFramework.ScannedOPT = Manager.Machines[cDropDown_machineProfiles.SelectedIndex].OPT;
            }
            else //Close serial port
            {
                cSliderRouterRPM.Enabled = false;
                cButtonSetRPM.Enabled = false;
                cTabControl_spindleLaser.SelectedIndex = 0;

                //Stop timer, updating UI stuff is no longer needed
                grblTimer.Stop();
                //Close serial port
                GRBLFramework.CloseSerialPort();

                //Set machine state label
                cLabel_machineState.Text = "No Connection";

                EnableControls(false);
            }
        }


        private void cDropDown_workSpace_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Set current workspace. No need to check if serial is open, it's done in GRBL Framework
            switch(cDropDown_workSpace.SelectedIndex)
            {
                case 0:
                    GRBLFramework.SetCoordinateSystem(eP.P1);
                    break;
                case 1:
                    GRBLFramework.SetCoordinateSystem(eP.P2);
                    break;
                case 2:
                    GRBLFramework.SetCoordinateSystem(eP.P3);
                    break;
                case 3:
                    GRBLFramework.SetCoordinateSystem(eP.P4);
                    break;
                case 4:
                    GRBLFramework.SetCoordinateSystem(eP.P5);
                    break;
                case 5:
                    GRBLFramework.SetCoordinateSystem(eP.P6);
                    break;
            }
        }


        private void cButton_reset_Click(object sender, EventArgs e)
        {
            GRBLFramework.RESET();
        }

        private void cButton_unlock_Click(object sender, EventArgs e)
        {
            GRBLFramework.UNLOCK();
        }

        private void cButton_home_Click(object sender, EventArgs e)
        {
            GRBLFramework.HOME();
        }

        private void cButton_startResume_Click(object sender, EventArgs e)
        {
            GRBLFramework.START_RESUME();
        }

        private void cButton_hold_Click(object sender, EventArgs e)
        {
            GRBLFramework.HOLD();
        }


        private void cLinkLabel_zeroAll_Click(object sender, EventArgs e)
        {
            GRBLFramework.ZeroAllAxis();
        }

        private void cLinkLabel_zeroX_Click(object sender, EventArgs e)
        {
            GRBLFramework.ZeroSingleAxis(eAxis.X);
        }

        private void cLinkLabel_zeroY_Click(object sender, EventArgs e)
        {
            GRBLFramework.ZeroSingleAxis(eAxis.Y);
        }

        private void cLinkLabel_zeroZ_Click(object sender, EventArgs e)
        {
            GRBLFramework.ZeroSingleAxis(eAxis.Z);
        }


        private void SendCommand()
        {
            GRBLFramework.SendLine(cTextBox_command.Text, true);
            cTextBox_command.Clear();
        }

        private void cCheckBox_showQuery_CheckedChanged(object sender, EventArgs e)
        {
            GRBLFramework.ShowQuery = cCheckBox_showQuery.Checked;
        }

        private void cTextBox_command_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && cTextBox_command.Text.Length > 0)
                SendCommand();

            //Remove 'ding' sound
            if(e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void cButton_sendCommand_Click(object sender, EventArgs e)
        {
            if (cTextBox_command.Text.Length > 0)
                SendCommand();
        }

        private void cButton_clear_Click(object sender, EventArgs e)
        {
            cRichTextBox1.Clear();
        }


        private void cButton_XYZero_Click(object sender, EventArgs e)
        {
            GRBLFramework.MoveToZero_TwoAxis();
        }

        private void cButton_ZZero_Click(object sender, EventArgs e)
        {
            GRBLFramework.MoveToZero_SingleAxis(eAxis.Z);
        }


        private void cTextBox_distance_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
                e.Handled = true;

            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
                e.Handled = true;
        }

        private void cTextBox_feedRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }


        private void cButton_Xp_Click(object sender, EventArgs e)
        {
            if(cTextBox_distance.Text.Length > 0 && cTextBox_feedRate.Text.Length > 0)
                GRBLFramework.MoveSingleAxis(eAxis.X, cRadioButton_g0.Checked, true, float.Parse(cTextBox_distance.Text), int.Parse(cTextBox_feedRate.Text));
        }

        private void cButton_Xm_Click(object sender, EventArgs e)
        {
            if (cTextBox_distance.Text.Length > 0 && cTextBox_feedRate.Text.Length > 0)
                GRBLFramework.MoveSingleAxis(eAxis.X, cRadioButton_g0.Checked, true, -float.Parse(cTextBox_distance.Text), int.Parse(cTextBox_feedRate.Text));
        }

        private void cButton_Yp_Click(object sender, EventArgs e)
        {
            if (cTextBox_distance.Text.Length > 0 && cTextBox_feedRate.Text.Length > 0)
                GRBLFramework.MoveSingleAxis(eAxis.Y, cRadioButton_g0.Checked, true, float.Parse(cTextBox_distance.Text), int.Parse(cTextBox_feedRate.Text));
        }

        private void cButton_Ym_Click(object sender, EventArgs e)
        {
            if (cTextBox_distance.Text.Length > 0 && cTextBox_feedRate.Text.Length > 0)
                GRBLFramework.MoveSingleAxis(eAxis.Y, cRadioButton_g0.Checked, true, -float.Parse(cTextBox_distance.Text), int.Parse(cTextBox_feedRate.Text));
        }

        private void cButton_XmYp_Click(object sender, EventArgs e)
        {
            if (cTextBox_distance.Text.Length > 0 && cTextBox_feedRate.Text.Length > 0)
                GRBLFramework.MoveTwoAxis(cRadioButton_g0.Checked, true,
                    -float.Parse(cTextBox_distance.Text),
                    float.Parse(cTextBox_distance.Text),
                    int.Parse(cTextBox_feedRate.Text));
        }

        private void cButton_XpYp_Click(object sender, EventArgs e)
        {
            if (cTextBox_distance.Text.Length > 0 && cTextBox_feedRate.Text.Length > 0)
                GRBLFramework.MoveTwoAxis(cRadioButton_g0.Checked, true,
                    float.Parse(cTextBox_distance.Text),
                    float.Parse(cTextBox_distance.Text),
                    int.Parse(cTextBox_feedRate.Text));
        }

        private void cButton_XmYm_Click(object sender, EventArgs e)
        {
            if (cTextBox_distance.Text.Length > 0 && cTextBox_feedRate.Text.Length > 0)
                    GRBLFramework.MoveTwoAxis(cRadioButton_g0.Checked, true,
                    -float.Parse(cTextBox_distance.Text),
                    -float.Parse(cTextBox_distance.Text),
                    int.Parse(cTextBox_feedRate.Text));
        }

        private void cButton_XpYm_Click(object sender, EventArgs e)
        {
            if (cTextBox_distance.Text.Length > 0 && cTextBox_feedRate.Text.Length > 0)
                GRBLFramework.MoveTwoAxis(cRadioButton_g0.Checked, true,
                    float.Parse(cTextBox_distance.Text),
                    -float.Parse(cTextBox_distance.Text),
                    int.Parse(cTextBox_feedRate.Text));
        }

        private void cButton_Zp_Click(object sender, EventArgs e)
        {
            if (cTextBox_distance.Text.Length > 0 && cTextBox_feedRate.Text.Length > 0)
                GRBLFramework.MoveSingleAxis(eAxis.Z, cRadioButton_g0.Checked, true, float.Parse(cTextBox_distance.Text), int.Parse(cTextBox_feedRate.Text));
        }

        private void cButton_Zm_Click(object sender, EventArgs e)
        {
            if (cTextBox_distance.Text.Length > 0 && cTextBox_feedRate.Text.Length > 0)
                GRBLFramework.MoveSingleAxis(eAxis.Z, cRadioButton_g0.Checked, true, -float.Parse(cTextBox_distance.Text), int.Parse(cTextBox_feedRate.Text));
        }


        private void cButton_touchThePlate_Click(object sender, EventArgs e)
        {
            GRBLFramework.ToutchThePlate(Manager.Machines[cDropDown_machineProfiles.SelectedIndex].TouchPlateHeight,
                Manager.Machines[cDropDown_machineProfiles.SelectedIndex].MoveUpDistance);
        }

        private void cSwitch_enableSpindle_Click(object sender, EventArgs e)
        {
            if (cSwitch_enableSpindle.IsOn)
                GRBLFramework.PowerSpidle();
            else
                GRBLFramework.PowerOffSpindle();
        }

        private void cButton_overrideFeedIncrease_Click(object sender, EventArgs e)
        {
            GRBLFramework.FeedRateOverrideAdd(cRadioButton_overrideFeedAddOne.Checked);
        }

        private void cButton_overrideFeedReduce_Click(object sender, EventArgs e)
        {
            GRBLFramework.FeedRateOverrideRemove(cRadioButton_overrideFeedAddOne.Checked);
        }


        private void cButton_overrideSpindleIncrease_Click(object sender, EventArgs e)
        {
            GRBLFramework.SpindleOverrideAdd(cRadioButton_overrideSpindleAddOne.Checked);
        }

        private void cButton_overrideSpindleReduce_Click(object sender, EventArgs e)
        {
            GRBLFramework.SpindleOverrideRemove(cRadioButton_overrideSpindleAddOne.Checked);
        }


        private void cRadioButton_overrideRapidFull_CheckedChanged(object sender, EventArgs e)
        {
            if (cRadioButton_overrideRapidFull.Checked)
                GRBLFramework.RapidOverride(0);
        }

        private void cRadioButton_overrideRapidHalf_CheckedChanged(object sender, EventArgs e)
        {
            if (cRadioButton_overrideRapidHalf.Checked)
                GRBLFramework.RapidOverride(1);
        }

        private void cRadioButton_overrideRapidQuarter_CheckedChanged(object sender, EventArgs e)
        {
            if (cRadioButton_overrideRapidQuarter.Checked)
                GRBLFramework.RapidOverride(2);
        }


        #endregion

        //Update UI stuff
        private void grblTimer_Tick(object sender, EventArgs e)
        {
            cLabel_mposX.Text = GRBLFramework.MPos.X.ToString();
            cLabel_mposY.Text = GRBLFramework.MPos.Y.ToString();
            cLabel_mposZ.Text = GRBLFramework.MPos.Z.ToString();

            cLabel_wposX.Text = GRBLFramework.WPos.X.ToString();
            cLabel_wposY.Text = GRBLFramework.WPos.Y.ToString();
            cLabel_wposZ.Text = GRBLFramework.WPos.Z.ToString();

            cLabel_wcoX.Text = GRBLFramework.WCO.X.ToString();
            cLabel_wcoY.Text = GRBLFramework.WCO.Y.ToString();
            cLabel_wcoZ.Text = GRBLFramework.WCO.Z.ToString();

            cLabel_fs.Text = GRBLFramework.CurrentFeedRate.ToString();
            cLabelSpindleRPM.Text = GRBLFramework.currentSpindleSpeed.ToString();

            cLabel_machineState.Text = GRBLFramework.MachineState.ToString();

            cLabel_overrideFeed.Text = GRBLFramework.OverrideFeedRate.ToString();
            cLabel_overrideSpindle.Text = GRBLFramework.OverrideSpindle.ToString();
            cLabel_overrideRapid.Text = GRBLFramework.OverrideRapid.ToString();

            if(CurPositioning != GRBLFramework.Positioning)
            {
                CurPositioning = GRBLFramework.Positioning;

                if (!PositioningDropaDownSet)
                {
                    PositioningAutoSet = true;

                    if (CurPositioning == ePositioning.Absolute)
                        cDropDownPositioning.SelectedIndex = 0;
                    else
                        cDropDownPositioning.SelectedIndex = 1;
                }
                else
                    PositioningDropaDownSet = false;
            }

            //If tool has to be changed
            if (GRBLFramework.DoToolChange && GRBLFramework.MachineState == eMachineState.Idle
                && !ToolChangeWindowVisible && !GRBLFramework.CheckInProgress)
            {
                ToolChangeWindow.RouterTool = null;
                ToolChangeWindow.CurrentMachine = Manager.Machines[cDropDown_machineProfiles.SelectedIndex];

                //Loop tools to find the correct tool
                foreach (CNCTool tool in Manager.CNCTools)
                {
                    //Only if tool is known
                    if (cListView_fileTools.Items[ToolChangeIndex].Text != "?")
                    {
                        if (tool.ID == int.Parse(cListView_fileTools.Items[ToolChangeIndex].Text))
                        {
                            ToolChangeWindow.RouterTool = tool;
                            break;
                        }
                    }
                }

                //Show tool change window
                ToolChangeWindowVisible = true;
                ToolChangeWindow.ShowDialog();

                //Tell GRBL Framework to continue machining
                GRBLFramework.ToolChanged();
                ToolChangeWindowVisible = false;

                if (ToolChangeIndex < cListView_fileTools.Items.Count)
                    ToolChangeIndex++;

                UpdateFileToolsList();
            }

            //If file is being sent to GRBL
            if(GRBLFramework.SendingFile)
            {
                //Update progress value
                cLabel_percentage.Text = string.Format("{0}%", GRBLFramework.FileSentPercentage.ToString("F1"));
                cProgressBar1.Value = (int)GRBLFramework.FileSentPercentage;
                //Update time labels
                UpdateTime();
            }
        }

        private void cDropDownPositioning_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PositioningAutoSet)
            {
                PositioningAutoSet = false;
                return;
            }

            if (cDropDownPositioning.SelectedIndex == 0)
            {
                PositioningDropaDownSet = true;
                GRBLFramework.AbsoluteMode();
            }
            else
            {
                PositioningDropaDownSet = true;
                GRBLFramework.IncrementalMode();
            }
        }

        #region File

        private DateTime StartTime, EndTime;
        private TimeSpan TotTime;

        /// <summary>
        /// When file has been sent and pgm end msg received
        /// </summary>
        private void PgmEnd()
        {
            //Set progress to max
            cLabel_percentage.Text = "100%";
            cProgressBar1.Value = cProgressBar1.Maximum;

            //Set end time
            EndTime = DateTime.Now.ToLocalTime();
            //Update time labels
            UpdateTime();

            cButton_openFile.Enabled = true;
            cButton_sendFile.Enabled = true;
            cButton_stopFile.Enabled = false;
            cButtonCheckMode.Enabled = true;

            GRBLFramework.SendingFile = false;
        }

        /// <summary>
        /// Update time labels
        /// </summary>
        private void UpdateTime()
        {
            cLabel_startTime.Text = string.Format("Start: {0}:{1}:{2}", StartTime.Hour, StartTime.Minute, StartTime.Second);
            cLabel_endTime.Text = string.Format("End: {0}:{1}:{2}", EndTime.Hour, EndTime.Minute, EndTime.Second);

            TotTime = DateTime.Now.ToLocalTime() - StartTime;
            cLabel_usedTime.Text = string.Format("Used: {0}", TotTime.ToString("mm\\:ss"));
        }

        private void ProgressVisible(bool visible)
        {
            cProgressBar1.Visible = visible;
            cLabel_percentage.Visible = visible;
        }

        private void cButton_openFile_Click(object sender, EventArgs e)
        {
            //Get file
            string file = PathPicker.GetFilePath("All Files(*.*)|*.*", false);

            //If no file, return
            if (string.IsNullOrEmpty(file))
                return;

            //Prepare the file to be sent
            GRBLFramework.PrepareFile(file);

            //Get all tools ID's in the file
            int toolsCount = 0;
            bool toolFound = false;

            //Clear found tools in list view
            cListView_fileTools.Items.Clear();

            try
            {
                //Loop found tools
                foreach (int i in GRBLFramework.GetToolIDsFromFile())
                {
                    //As default too is unknown
                    toolFound = false;

                    //Try to found tool in saved tools
                    foreach (CNCTool ct in Manager.CNCTools)
                    {
                        //If tool ID is match add it to list view
                        if (ct.ID == i)
                        {
                            ListViewItem item = new ListViewItem(ct.ID.ToString());
                            item.SubItems.Add(ct.Name);
                            item.SubItems.Add(ct.CD.ToString());
                            item.SubItems.Add(ct.SD.ToString());

                            if (toolsCount == 0)
                                item.SubItems.Add("First");
                            else
                                item.SubItems.Add("Queue");

                            cListView_fileTools.Items.Add(item);

                            toolsCount++;
                            toolFound = true;
                        }
                    }

                    //If tool has not been found in saved tools
                    if (!toolFound)
                    {
                        ListViewItem item = new ListViewItem("?");
                        item.SubItems.Add("Unknown Tool");
                        item.SubItems.Add("?");
                        item.SubItems.Add("?");

                        if (toolsCount == 0)
                            item.SubItems.Add("First");
                        else
                            item.SubItems.Add("Queue");

                        toolsCount++;
                        cListView_fileTools.Items.Add(item);
                    }
                }

                if(toolsCount > 0)
                    cListView_fileTools.Invalidate();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error while finding tools from file.", MessageBoxButtons.OK);
            }

            cButton_sendFile.Enabled = true;
            cButtonCheckMode.Enabled = true;

            try
            {
                //Calculate approximate machining time in seconds
                double seconds = MachiningTimeCalculator.GetMachiningTimeInSeconds(GRBLFramework.FileLines,
                    Manager.Machines[cDropDown_machineProfiles.SelectedIndex],
                    GRBLFramework.WPos.X, GRBLFramework.WPos.Y, GRBLFramework.WPos.Z);

                if(seconds != 0)
                {
                    //Adding tool change time
                    seconds += Manager.Machines[cDropDown_machineProfiles.SelectedIndex].ToolChangeTime * (toolsCount + 1);

                    //Set approximate label text
                    TimeSpan ts = TimeSpan.FromSeconds(seconds);
                    cLabel_approximate.Text = string.Format("Approximate machining time: {0}", ts.ToString("mm\\:ss"));
                }
                else
                {
                    cLabel_approximate.Text = "Approximate machining time: Dunno";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Error in machining time calculation.", MessageBoxButtons.OK);
            }
        }

        private void cButton_sendFile_Click(object sender, EventArgs e)
        {
            ToolChangeIndex = 0;

            if (GRBLFramework.MachineState == eMachineState.Check)
                GRBLFramework.StartCheck();
            else
                GRBLFramework.SendFile();

            //Show progress
            ProgressVisible(true);
            cButton_openFile.Enabled = false;
            cButton_sendFile.Enabled = false;
            cButton_stopFile.Enabled = true;
            cButtonCheckMode.Enabled = false;

            //Set start time
            StartTime = DateTime.Now.ToLocalTime();
        }

        private void cButton_stopFile_Click(object sender, EventArgs e)
        {
            //Stop sending file to GRBL
            GRBLFramework.StopFile();
            //Set machine to HOLD state to stop moving
            GRBLFramework.HOLD();
            //Hide progress
            ProgressVisible(false);
            //Tell user to clear HOLD state
            GRBLFramework.LineToConsole("File sending stopped, reset to clear HOLD state.");

            cButton_openFile.Enabled = true;
            cButton_sendFile.Enabled = true;
            cButton_stopFile.Enabled = false;
            cButtonCheckMode.Enabled = true;

            //Set end time
            EndTime = DateTime.Now.ToLocalTime();
            //Update time labels
            UpdateTime();
        }


        private void CheckComplete()
        {
            PgmEnd();

            using (Form_CheckFile cf = new Form_CheckFile())
            {
                cf.ShowDialog();
            }
        }

        private void cButtonCheckMode_Click(object sender, EventArgs e)
        {
            GRBLFramework.CheckMode();
        }


        /// <summary>
        /// Update found tools in list
        /// </summary>
        private void UpdateFileToolsList()
        {
            try
            {
                if (cListView_fileTools.Items.Count <= 0)
                    return;

                for (int i = 0; i < cListView_fileTools.Items.Count; i++)
                {
                    if(i < ToolChangeIndex)
                        cListView_fileTools.Items[i].SubItems[4].Text = "X";
                    else if(i > ToolChangeIndex)
                        cListView_fileTools.Items[i].SubItems[4].Text = "Queue";
                    else if(i == ToolChangeIndex)
                        cListView_fileTools.Items[i].SubItems[4].Text = "Current";
                }

                cListView_fileTools.Invalidate();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in tool list update.", MessageBoxButtons.OK);
            }
        }

        #endregion

        #region Messages

        private void MessageReceivedAction()
        {
            cListViewMessages.Items.Clear();

            foreach (MessageInfo mi in GRBLFramework.MessagesList)
            {
                ListViewItem item = new ListViewItem(mi.Type);
                item.SubItems.Add(mi.ID);
                item.SubItems.Add(mi.Message);
                cListViewMessages.Items.Add(item);
            }

            cListViewMessages.Invalidate();
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cListViewMessages.SelectedItem == null)
                return;

            MessageBox.Show(cListViewMessages.Items[cListViewMessages.SelectedItem.Y_Index].SubItems[2].Text,
                cListViewMessages.Items[cListViewMessages.SelectedItem.Y_Index].SubItems[0].Text + " " +
                cListViewMessages.Items[cListViewMessages.SelectedItem.Y_Index].SubItems[1].Text);
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cListViewMessages.SelectedItem == null)
                return;

            cListViewMessages.Items.RemoveAt(cListViewMessages.SelectedItem.Y_Index);
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cListViewMessages.Items.Clear();
            GRBLFramework.MessagesList.Clear();
        }

        #endregion

        #region Spindle Controls

        private void cSliderRouterRPM_ValueChanged(object sender, EventArgs e)
        {
            cLabelSliderSpindleRPM.Text = cSliderRouterRPM.Value.ToString();
        }

        private void cButtonSetRPM_Click(object sender, EventArgs e)
        {
            GRBLFramework.SetSpindleRPM((int)cSliderRouterRPM.Value);
        }



        private void cButton_showLaserArea_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nope");
        }

        private void cSwitch_enableStrongLaser_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nope");
        }

        private void cSwitch_enableWeakLaser_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nope");
        }

        #endregion

        #region G-Code Generator

        private void cButtonGCodeGenerator_Click(object sender, EventArgs e)
        {
            //Not yet
            //Form_Generator generator = new Form_Generator();
            //generator.Show();
        }

        #endregion
    }
}
