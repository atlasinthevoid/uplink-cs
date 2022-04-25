namespace Uplink.Capability.World
{
    public class TeleportApp : Capability
    {
        public TeleportApp()
        {
            StringType = "TeleportApp";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}