using CCL;
using CCL.Controls;
using CNCV.Machines;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNCV.Pages
{
    public partial class Form_Machines : CForm, IManager
    {
        public Manager Manager => Manager.Instance;

        public Form_Machines()
        {
            InitializeComponent();

            var skinmanager = CSkinManager.Instance;
            skinmanager.AddFormToManage(this);

            LoadMachines();
        }

        private void LoadMachines()
        {
            //Clear machines list view
            machineList.Items.Clear();

            //If no machines in manager machines list, nothing to show
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

                machineList.Items.Add(item);
            }

            //Update list view paint
            machineList.Invalidate();
        }

        private void cButton_saveMachines_Click(object sender, EventArgs e)
        {
            Manager.SaveMachinesList();

            Close();
        }

        private void cButton_cancelMachineSave_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void cContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if(machineList.SelectedItem == null)
            {
                duplicateToolStripMenuItem.Enabled = false;
                //exportToolStripMenuItem.Enabled = false;
                deleteToolStripMenuItem.Enabled = false;
            }
            else
            {
                duplicateToolStripMenuItem.Enabled = true;
                //exportToolStripMenuItem.Enabled = true;
                deleteToolStripMenuItem.Enabled = true;
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Get machine index
            int index = machineList.SelectedItem.Y_Index;
            //Show machine editing window and pass down index
            using (Form_Machine fm = new Form_Machine(index))
            {
                fm.ShowDialog();
            }

            //Load machines, reload not needed
            LoadMachines();
        }

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Manager.AddEmptyMachine(machineList);
        }

        private void duplicateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Manager.DuplicateMachine(machineList.SelectedItem.Y_Index);
            LoadMachines();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Manager.DeleteMachine(machineList);
            LoadMachines();
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void reloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadMachines();
        }
    }
}
