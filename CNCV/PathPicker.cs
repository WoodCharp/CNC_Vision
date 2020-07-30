using System;
using System.Windows.Forms;

namespace CNCV
{
    public static class PathPicker
    {
        private static FolderBrowserDialog folder;
        private static OpenFileDialog file;

        private static void Initialize()
        {
            if(folder == null)
            {
                folder = new FolderBrowserDialog();
                folder.Description = "Choose folder";
                folder.ShowNewFolderButton = true;
            }

            if(file == null)
            {
                file = new OpenFileDialog();
                file.Title = "Select file";
            }
        }

        public static string GetFilePath(string filter, bool MultiSelect)
        {
            Initialize();

            if (MultiSelect)
            {
                file.Multiselect = true;
                file.Filter = filter;
                if (file.ShowDialog() == DialogResult.OK)
                {
                    return file.FileName;
                }
            }
            else
            {
                file.Multiselect = false;
                file.Filter = "*.* (All Files)|*.*";
                if (file.ShowDialog() == DialogResult.OK)
                {
                    return file.FileName;
                }
            }

            return string.Empty;
        }

        public static string GetFolder()
        {
            Initialize();

            if (folder.ShowDialog() == DialogResult.OK)
            {
                return folder.SelectedPath + @"\CNC Vision";
            }

            return string.Empty;
        }
    }
}
