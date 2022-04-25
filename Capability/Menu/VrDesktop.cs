namespace Uplink.Capability.Menu
{
    public class VrDesktop : Capability
    {
        public VrDesktop()
        {
            StringType = "VrDesktop";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}