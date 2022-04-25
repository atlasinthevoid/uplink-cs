namespace Uplink.Capability.Menu
{
    public class PlanetMap : Capability
    {
        public PlanetMap()
        {
            StringType = "PlanetMap";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}