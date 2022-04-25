namespace Uplink.Capability.World
{
    public class XPLevel : Capability
    {
        public XPLevel()
        {
            StringType = "XPLevel";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}