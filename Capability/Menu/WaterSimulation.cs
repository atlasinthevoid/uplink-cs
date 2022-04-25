namespace Uplink.Capability.Menu
{
    public class WaterSimulation : Capability
    {
        public WaterSimulation()
        {
            StringType = "WaterSimulation";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}