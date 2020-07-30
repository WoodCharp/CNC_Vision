using System.Diagnostics;
using System.Reflection;

namespace CNCV
{
    public static class GetVersionInfo
    {
        private static Assembly assembly;
        private static FileVersionInfo fileVersionInfo;

        private static void Update()
        {
            assembly = Assembly.GetExecutingAssembly();
            fileVersionInfo = FileVersionInfo.GetVersionInfo(assembly.Location);
        }

        public static string Version()
        {
            Update();
            return string.Format("v{0}", fileVersionInfo.FileVersion);
        }

        public static string AssemblyName()
        {
            Update();
            return assembly.GetName().Name;
        }
    }
}
