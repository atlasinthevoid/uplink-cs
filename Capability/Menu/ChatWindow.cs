namespace Uplink.Capability.Menu
{
    public class ChatWindow : Capability
    {

        public ChatWindow()
        {
            StringType = "ChatWindow";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}