using CCL;
using CCL.Controls;
using System;
using System.IO;
using System.Windows.Forms;

namespace CNCV.Pages
{
    public partial class Form_Settings : CForm, IManager
    {
        public Manager Manager => Manager.Instance;

        public Form_Settings()
        {
            InitializeComponent();

            var skinmanager = CSkinManager.Instance;
            skinmanager.AddFormToManage(this);

            LoadAppSettings();
        }

        private void LoadAppSettings()
        {
            //If app settings are loaded
            if (Manager.LoadAppSettings())
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
                if (res == DialogResult.Yes)
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

            Close();
        }

        private void cButton_cancelAppSettings_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
