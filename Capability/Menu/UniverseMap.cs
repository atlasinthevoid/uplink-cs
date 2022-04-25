namespace Uplink.Capability.Menu
{
    public class UniverseMap : Capability
    {
        public UniverseMap()
        {
            StringType = "UniverseMap";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}