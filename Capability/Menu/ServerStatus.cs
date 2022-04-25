namespace Uplink.Capability.Menu
{
    public class ServerStatus : Capability
    {
        public ServerStatus()
        {
            StringType = "ServerStatus";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}