namespace CNCV
{
    public interface IManager
    {
        Manager Manager { get; }
    }

    public enum eTool
    {
        Flat,
        Ball,
        Carving,
        Drill,
        Chamfer,
        Rounding,
        Laser
    }

    public enum eMachine
    {
        Router,
        Laser
    }
}
