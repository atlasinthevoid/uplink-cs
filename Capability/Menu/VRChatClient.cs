namespace Uplink.Capability.Menu
{
    public class VRChatClient : Capability
    {
        public VRChatClient()
        {
            StringType = "VRChatClient";
            Program.Systems.Register(this);
        }

        public override void Update()
        {
            
        }
    }
}