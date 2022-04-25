namespace Uplink.Capability.Menu
{
    public class VRChatMenu : Capability
    {
        public VRChatMenu()
        {
            StringType = "VRChatMenu";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}