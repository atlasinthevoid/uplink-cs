namespace Uplink.Capability.Menu
{
    public class SolarSystemMap : Capability
    {
        public SolarSystemMap()
        {
            StringType = "SolarSystemMap";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}