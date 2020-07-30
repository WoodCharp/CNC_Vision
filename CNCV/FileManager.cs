using Newtonsoft.Json;
using System.IO;

namespace CNCV
{
    public class FileManager
    {
        public string DataFolder { get { return Properties.Settings.Default.DataFolder; } }
        public string ToolsFolder { get { return DataFolder + @"\Tools"; } }
        public string MachinesFolder { get { return DataFolder + @"\Machines"; } }

        public string AppSettingsFile { get { return DataFolder + @"\AppSettings.txt"; } }

        #region Exists

        /// <summary>
        /// Check data folder existence
        /// </summary>
        /// <returns></returns>
        public bool DataFolderExist()
        {
            if (Directory.Exists(DataFolder))
                return true;

            return false;
        }

        /// <summary>
        /// Check tools folder existence
        /// </summary>
        /// <returns></returns>
        public bool ToolsFolderExist()
        {
            if (Directory.Exists(ToolsFolder))
                return true;

            return false;
        }

        /// <summary>
        /// Check machines folder existence
        /// </summary>
        /// <returns></returns>
        public bool MachinesFolderExist()
        {
            if (Directory.Exists(MachinesFolder))
                return true;

            return false;
        }

        /// <summary>
        /// Check settings file existence
        /// </summary>
        /// <returns></returns>
        public bool AppSettingsExist()
        {
            if (File.Exists(AppSettingsFile))
                return true;

            return false;
        }

        /// <summary>
        /// Check settings file existence
        /// </summary>
        /// <returns></returns>
        public bool AppSettingsExist(string file)
        {
            if (File.Exists(file))
                return true;

            return false;
        }

        #endregion

        /// <summary>
        /// Get all tool profiles
        /// </summary>
        /// <returns>Tool files array</returns>
        public string[] GetToolFiles()
        {
            if(ToolsFolderExist())
                return Directory.GetFiles(ToolsFolder, "*.txt", SearchOption.TopDirectoryOnly);

            return null;
        }

        /// <summary>
        /// Get all machine profiles
        /// </summary>
        /// <returns>Machine files array</returns>
        public string[] GetMachineFiles()
        {
            if(MachinesFolderExist())
                return Directory.GetFiles(MachinesFolder, "*.txt", SearchOption.TopDirectoryOnly);

            return null;
        }

        /// <summary>
        /// Delete file
        /// </summary>
        /// <param name="file">File path</param>
        public void DeleteFile(string file)
        {
            if (File.Exists(file))
                File.Delete(file);
        }

        /// <summary>
        /// Save object
        /// </summary>
        /// <param name="obj">Object to be saved</param>
        /// <param name="file">File path</param>
        public void Save(object obj, string file)
        {
            //Save
            using(StreamWriter sw = new StreamWriter(file, false))
            {
                sw.Write(JsonConvert.SerializeObject(obj));
            }
        }
    }
}
