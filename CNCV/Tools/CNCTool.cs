namespace CNCV.Tools
{
    public class CNCTool
    {
        //Common
        public int ID { get; set; } = 0;
        public eTool ToolType { get; set; } = eTool.Flat;
        public string Name { get; set; } = "New Tool";
        //Router
        public float CD { get; set; } = 0;
        public float SD { get; set; } = 0;
        public float FL { get; set; } = 0;
        public float A { get; set; } = 0;
        public float R { get; set; } = 0;
        public int F { get; set; } = 0;
        //Laser
        public int W { get; set; } = 0;
        public int CuttingPower { get; set; } = 0;
        public int EngravingPower { get; set; } = 0;
        public int AimPower { get; set; } = 0;

        public CNCTool() { }
    }
}
