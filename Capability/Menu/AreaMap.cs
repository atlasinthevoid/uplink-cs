namespace Uplink.Capability.Menu
{
    public class AreaMap : Capability
    {
        public AreaMap()
        {
            StringType = "AreaMap";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}