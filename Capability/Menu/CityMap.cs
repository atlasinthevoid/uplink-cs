namespace Uplink.Capability.Menu
{
    public class Map : Capability
    {

        public Map()
        {
            StringType = "Map";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}