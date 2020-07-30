using GRBL;
using System.Collections.Generic;

namespace CNCV.Machines
{
    public class Machine
    {
        public int ID { get; set; } = 0;
        public string VER { get; set; } = "VER*";
        public string OPT { get; set; } = "OPT*";
        public string Name { get; set; } = "NewMachine";
        public eMachine MachineType { get; set; } = eMachine.Router;

        /// <summary>
        /// Tool change time in seconds
        /// </summary>
        public int ToolChangeTime { get; set; } = 30;
        public float TouchPlateHeight { get; set; } = 10.0f;

        public PortData PortData { get; set; } = new PortData();
        public List<GRBLSetting> GRBLSettings { get; set; } = new List<GRBLSetting>();

        public Machine() { }

        public Machine(Machine duplicate)
        {
            ID = duplicate.ID;
            Name = duplicate.Name;
            MachineType = duplicate.MachineType;
            PortData = duplicate.PortData;
            GRBLSettings = duplicate.GRBLSettings;
        }

        public float GetSettingValueByID(int SettingID)
        {
            foreach(GRBLSetting setting in GRBLSettings)
            {
                if (SettingID == setting.ID)
                    return setting.Value;
            }

            return 0;
        }
    }
}
