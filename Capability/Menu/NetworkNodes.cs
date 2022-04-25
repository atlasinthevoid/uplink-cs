namespace Uplink.Capability.Menu
{
    public class NetworkNodes : Capability
    {

        public NetworkNodes()
        {
            StringType = "NetworkNodes";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}