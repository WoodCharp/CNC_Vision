using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CCL.Controls;
using CNCV.Machines;
using CNCV.Tools;

using Newtonsoft.Json;

namespace CNCV
{
    public class Manager
    {
        private static Manager _instance;
        public static Manager Instance => _instance ?? (_instance = new Manager());

        public FileManager FileManager;

        public AppSetting CurrentSettings { get; set; }
        public List<CNCTool> CNCTools { get; set; }

        public List<Machine> Machines { get; set; }

        public Manager()
        {
            FileManager = new FileManager();

            LoadAppSettings();
        }

        #region App settings

        /// <summary>
        /// Load settings from file
        /// </summary>
        public void LoadAppSettings()
        {
           // MessageBox.Show("Loading");
            if(FileManager.AppSettingsExist())
            {
                using(TextReader tr = File.OpenText(FileManager.AppSettingsFile))
                {
                    CurrentSettings = JsonConvert.DeserializeObject<AppSetting>(tr.ReadToEnd());
                    //Refresh stuff
                    Properties.Settings.Default.DataFolder = CurrentSettings.DataFolderPath;
                    Properties.Settings.Default.Save();
                    Properties.Settings.Default.Reload();
                }
            }
        }

        //Save new setting file
        public void SaveNewSettings(AppSetting setting)
        {
            FileManager.Save(setting, FileManager.AppSettingsFile);
            CurrentSettings = setting;
        }

        /// <summary>
        /// Get data folder path
        /// </summary>
        /// <returns>path</returns>
        public string GetDataFolderPath()
        {
            if (CurrentSettings != null)
                return CurrentSettings.DataFolderPath;

            return string.Empty;
        }

        #endregion

        #region Tools

        /// <summary>
        /// Get all router tool types
        /// </summary>
        /// <returns>Array of tool types</returns>
        public string[] GetToolTypes()
        {
            return Enum.GetValues(typeof(eTool)).Cast<eTool>().Select(v => v.ToString()).ToArray();
        }

        /// <summary>
        /// Read all tool files
        /// </summary>
        public void ReloadToolsList()
        {
            if (CNCTools == null)
                CNCTools = new List<CNCTool>();

            CNCTools.Clear();

            string[] files = FileManager.GetToolFiles();

            if(files != null)
            {
                foreach (string toolFile in files)
                {
                    if(File.Exists(toolFile))
                    {
                        using (TextReader tr = File.OpenText(toolFile))
                        {
                            CNCTool tool = JsonConvert.DeserializeObject<CNCTool>(tr.ReadToEnd());
                            CNCTools.Add(tool);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Save tools list
        /// </summary>
        public void SaveToolsList(CListView listView)
        {
            if (listView.Items.Count <= 0)
                return;

            CNCTools.Clear();

            foreach (ListViewItem item in listView.Items)
            {
                //MessageBox.Show(t.ToString());

                CNCTool tool = new CNCTool()
                {
                    ID = int.Parse(item.Text),
                    Name = item.SubItems[1].Text,
                    ToolType = (eTool)Enum.Parse(typeof(eTool), item.SubItems[2].Text),
                    CD = float.Parse(item.SubItems[3].Text),
                    SD = float.Parse(item.SubItems[4].Text),
                    FL = float.Parse(item.SubItems[5].Text),
                    F = int.Parse(item.SubItems[6].Text),
                    A = float.Parse(item.SubItems[7].Text),
                    R = float.Parse(item.SubItems[8].Text),
                    W = int.Parse(item.SubItems[9].Text)
                };

                CNCTools.Add(tool);
            }

            foreach(CNCTool tool in CNCTools)
            {
                FileManager.Save(tool,
                    string.Format(@"{0}\{1}_Tool.txt", FileManager.ToolsFolder, tool.ID));
            }
        }

        /// <summary>
        /// Duplicate selected tool on list view
        /// </summary>
        /// <param name="listView">Tool on list view to be duplicated</param>
        public void DuplicateTool(CListView listView)
        {
            ListViewItem item = listView.Items[listView.SelectedItem.Y_Index].Clone() as ListViewItem;
            listView.Items.Add(item);
        }

        /// <summary>
        /// Add new tool to the list
        /// </summary>
        /// <param name="listView">list to be added</param>
        public void AddEmptyTool(CListView listView)
        {
            ListViewItem item = new ListViewItem("999");
            item.SubItems.Add("New Tool");
            item.SubItems.Add("Flat");
            item.SubItems.Add("0");
            item.SubItems.Add("0");
            item.SubItems.Add("0");
            item.SubItems.Add("0");
            item.SubItems.Add("0");
            item.SubItems.Add("0");
            item.SubItems.Add("0");

            listView.Items.Add(item);
            listView.Invalidate();
        }

        /// <summary>
        /// Delete tool
        /// </summary>
        /// <param name="listView">Item from the list to be deleted</param>
        public void DeleteTool(CListView listView)
        {
            if (listView.SelectedItem.Y_Index <= CNCTools.Count - 1)
            {
                string file = string.Format(@"{0}\{1}_Tool.txt", FileManager.ToolsFolder, CNCTools[listView.SelectedItem.Y_Index].ID);
                FileManager.DeleteFile(file);
            }

            listView.Items.RemoveAt(listView.SelectedItem.Y_Index);
        }

        #endregion

        #region Machines

        public string[] GetMachineTypes()
        {
            return Enum.GetValues(typeof(eMachine)).Cast<eMachine>().Select(v => v.ToString()).ToArray();
        }

        public void ReloadMachinesList()
        {
            if (Machines == null)
                Machines = new List<Machine>();

            Machines.Clear();

            string[] files = FileManager.GetMachineFiles();

            if (files != null)
            {
                foreach (string machineFile in files)
                {
                    if (File.Exists(machineFile))
                    {
                        using (TextReader tr = File.OpenText(machineFile))
                        {
                            Machine machine = JsonConvert.DeserializeObject<Machine>(tr.ReadToEnd());
                            Machines.Add(machine);
                        }
                    }
                }
            }
        }

        public void SaveMachinesList()
        {
            if (Machines.Count <= 0)
                return;

            foreach (Machine machine in Machines)
            {
                FileManager.Save(machine,
                    string.Format(@"{0}\{1}_Machine.txt", FileManager.MachinesFolder, machine.ID));
            }
        }

        public void DuplicateMachine(int index)
        {
            Machine douplicate = new Machine(Machines[index]);
            douplicate.ID = GetNewMachineID();
            Machines.Add(douplicate);
        }

        private int GetNewMachineID()
        {
            int newID = 0;

            if (Machines.Count > 0)
                newID = Machines[Machines.Count - 1].ID + 1;

            return newID;
        }

        public void AddEmptyMachine(CListView listView)
        {
            int id = GetNewMachineID();
            Machines.Add(new Machine() { ID = id, Name = "New Machine" });

            ListViewItem item = new ListViewItem(id.ToString());
            item.SubItems.Add("New Machine");
            item.SubItems.Add("Router");
            item.SubItems.Add("100");
            item.SubItems.Add("100");
            item.SubItems.Add("100");
            item.SubItems.Add("VER*");
            item.SubItems.Add("OPT*");
            listView.Items.Add(item);
            listView.Invalidate();
        }

        public void DeleteMachine(CListView listView)
        {
            if (listView.SelectedItem.Y_Index <= Machines.Count - 1)
            {
                string file = string.Format(@"{0}\{1}_Machine.txt", FileManager.MachinesFolder, Machines[listView.SelectedItem.Y_Index].ID);
                FileManager.DeleteFile(file);

                listView.Items.RemoveAt(listView.SelectedItem.Y_Index);
                Machines.RemoveAt(listView.SelectedItem.Y_Index);
            }
        }

        #endregion
    }
}
