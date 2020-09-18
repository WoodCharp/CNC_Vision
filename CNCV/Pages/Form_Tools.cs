using CCL;
using CCL.Controls;
using CNCV.Tools;
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
    public partial class Form_Tools : CForm, IManager
    {
        public Manager Manager => Manager.Instance;

        public Form_Tools()
        {
            InitializeComponent();

            var skinmanager = CSkinManager.Instance;
            skinmanager.AddFormToManage(this);

            LoadTools();
        }

        private void LoadTools()
        {
            //Clear list view items
            toolsList.Items.Clear();

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

                toolsList.Items.Add(item);
            }
        }

        private void cButton_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cButton_saveTools_Click(object sender, EventArgs e)
        {
            Manager.SaveToolsList(toolsList);

            Close();
        }


        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Manager.AddEmptyTool(toolsList);
        }

        private void duplicateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Manager.DuplicateTool(toolsList);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Manager.DeleteTool(toolsList);
        }

        private void reloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadTools();
        }

        private void cContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if(toolsList.SelectedItem == null)
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
    }
}
