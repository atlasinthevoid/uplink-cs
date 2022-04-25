namespace Uplink.Capability.Menu
{
    public class ServerTOS : Capability
    {
        public ServerTOS()
        {
            StringType = "ServerTOS";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}