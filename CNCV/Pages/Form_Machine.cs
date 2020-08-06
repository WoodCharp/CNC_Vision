using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CCL.Controls;
using CNCV.Machines;
using GRBL;
using GRBL.Wiki;

namespace CNCV.Pages
{
    public partial class Form_Machine : CForm, IManager, IGRBL
    {
        public GRBLManager GRBLFramework => GRBLManager.Instance;
        public Manager Manager => Manager.Instance;

        int SelectedMachineIndex = 0;
        Machine CurMachine;

        public Form_Machine(int index)
        {
            InitializeComponent();
            SelectedMachineIndex = index;

            cTextBoxMoveUp.KeyPress += new KeyPressEventHandler(cTextBox_touchPlateHeight_KeyPress);

            Text = string.Format("Editing Machine ID:{0}", Manager.Machines[SelectedMachineIndex].ID);

            GRBLFramework.CurrentForm = this;
            GRBLFramework.SettingsScanFinished = new Action(ReadScannedSettings);
            GRBLFramework.VerOptScanFinished = new Action(ReadScannedVerOpt);
        }

        private void Form_Machine_FormClosing(object sender, FormClosingEventArgs e)
        {
            GRBLFramework.CloseSerialPort();
        }

        private void Form_Machine_Load(object sender, EventArgs e)
        {
            CurMachine = Manager.Machines[SelectedMachineIndex];
            LoadMachineData();
        }

        private void LoadMachineData()
        {
            cTextBox_name.Text = CurMachine.Name;
            cTextBox_baudRate.Text = CurMachine.PortData.BaudRate.ToString();

            cDropDown_type.SelectedIndex = cDropDown_type.Items.IndexOf(CurMachine.MachineType.ToString());

            cDropDown_serialPorts.Items.Clear();
            cDropDown_serialPorts.Items.Add(CurMachine.PortData.PortName);
            cDropDown_serialPorts.SelectedIndex = 0;

            cLabel_opt.Text = "OPT: " + CurMachine.OPT;
            cLabel_version.Text = "VERSION:" + CurMachine.VER;

            cTextBox_toolChangeTime.Text = CurMachine.ToolChangeTime.ToString();
            cTextBox_touchPlateHeight.Text = CurMachine.TouchPlateHeight.ToString();
            cTextBoxMoveUp.Text = CurMachine.MoveUpDistance.ToString();

            GRBLFramework.ScannedOPT = CurMachine.OPT;

            foreach(GRBLSetting setting in CurMachine.GRBLSettings)
            {
                ListViewItem item = new ListViewItem(setting.ID.ToString());
                item.SubItems.Add(setting.Value.ToString());
                item.SubItems.Add(WikiSettings.GetIDDescription(setting.ID));
                cListView_grblSettings.Items.Add(item);
            }
        }


        private void cButton_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cButton_ok_Click(object sender, EventArgs e)
        {
            CurMachine.Name = cTextBox_name.Text;

            CurMachine.PortData.PortName = cDropDown_serialPorts.SelectedItemText;
            CurMachine.PortData.BaudRate = int.Parse(cTextBox_baudRate.Text);
            CurMachine.ToolChangeTime = int.Parse(cTextBox_toolChangeTime.Text);
            CurMachine.TouchPlateHeight = float.Parse(cTextBox_touchPlateHeight.Text);
            CurMachine.MoveUpDistance = float.Parse(cTextBoxMoveUp.Text);

            CurMachine.GRBLSettings.Clear();

            foreach (ListViewItem item in cListView_grblSettings.Items)
            {
                CurMachine.GRBLSettings.Add(new GRBLSetting()
                {
                    ID = int.Parse(item.Text),
                    Value = float.Parse(Converters.DotToFloat(item.SubItems[1].Text))
                });
            }

            switch(cDropDown_type.SelectedIndex)
            {
                case 0:
                    CurMachine.MachineType = eMachine.Router;
                    break;
                case 1:
                    CurMachine.MachineType = eMachine.Laser;
                    break;
            }

            Manager.Machines[SelectedMachineIndex] = CurMachine;

            GRBLFramework.CloseSerialPort();

            Close();
        }


        private void EnableButtons(bool enable)
        {
            cButton_connect.Enabled = !enable;
            cButton_disconnect.Enabled = enable;
            cButton_reset.Enabled = enable;
            cButton_unlock.Enabled = enable;
            cButton_getSettings.Enabled = enable;

            cTextBox_baudRate.Enabled = !enable;
            cDropDown_serialPorts.Enabled = !enable;
            cButton_sendSettings.Enabled = enable;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            cLabel_machineStatus.Text = GRBLFramework.MachineState.ToString();
        }


        private void cButton_refreshSerialPorts_Click(object sender, EventArgs e)
        {
            cDropDown_serialPorts.Items.Clear();
            cDropDown_serialPorts.Items.AddRange(GRBL.PortData.GetPorts());
        }

        private void cButton_connect_Click(object sender, EventArgs e)
        {
            PortData portData = new PortData(cDropDown_serialPorts.SelectedItemText, int.Parse(cTextBox_baudRate.Text));
            GRBLFramework.OpenSerialPort(portData);
            timer1.Start();
            EnableButtons(true);
        }

        private void cButton_disconnect_Click(object sender, EventArgs e)
        {
            GRBLFramework.CloseSerialPort();
            EnableButtons(false);
        }

        private void cButton_unlock_Click(object sender, EventArgs e)
        {
            GRBLFramework.UNLOCK();
        }

        private void cButton_reset_Click(object sender, EventArgs e)
        {
            GRBLFramework.RESET();
        }


        private void cButton_getSettings_Click(object sender, EventArgs e)
        {
            GRBLFramework.ScanGRBLSettings();
            GRBLFramework.ScanVerOpt();
        }

        private void cButton_sendSettings_Click(object sender, EventArgs e)
        {
            List<string> settings = new List<string>();

            foreach(ListViewItem item in cListView_grblSettings.Items)
            {
                settings.Add(string.Format("${0}={1}", item.Text, Converters.DotToFloat(item.SubItems[1].Text)));
            }

            GRBLFramework.SendSettingsToGRBL(settings);
        }

        private void ReadScannedSettings()
        {
            cListView_grblSettings.Items.Clear();

            foreach (GRBLSetting setting in GRBLFramework.ScannedGRBLSettings)
            {
                ListViewItem item = new ListViewItem(setting.ID.ToString());
                item.SubItems.Add(setting.Value.ToString());
                item.SubItems.Add(GRBL.Wiki.WikiSettings.GetIDDescription(setting.ID));

                cListView_grblSettings.Items.Add(item);
            }

            cListView_grblSettings.Invalidate();
        }

        private void ReadScannedVerOpt()
        {
            CurMachine.VER = GRBLFramework.ParseVersionFromScanned();
            CurMachine.OPT = GRBLFramework.ScannedOPT;

            cLabel_version.Text = string.Format("VERSION: {0}", CurMachine.VER);
            cLabel_opt.Text = string.Format("OPT: {0}", CurMachine.OPT);
        }


        private void cTextBox_toolChangeTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void cTextBox_touchPlateHeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
                e.Handled = true;

            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
                e.Handled = true;
        }
    }
}
