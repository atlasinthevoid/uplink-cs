namespace Uplink.Capability.Menu
{
    public class GalaxyMap : Capability
    {

        public GalaxyMap()
        {
            StringType = "GalaxyMap";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}