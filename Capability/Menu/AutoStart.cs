namespace Uplink.Capability.Menu
{
    public class AutoStart : Capability
    {
        public AutoStart()
        {
            StringType = "AutoStart";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}