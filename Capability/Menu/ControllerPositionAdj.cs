namespace Uplink.Capability.Menu
{
    public class ControllerPositionAdj : Capability
    {

        public ControllerPositionAdj()
        {
            StringType = "ControllerPositionAdj";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}