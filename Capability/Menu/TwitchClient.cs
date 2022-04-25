namespace Uplink.Capability.Menu
{
    public class TwitchClient : Capability
    {
        public TwitchClient()
        {
            StringType = "TwitchClient";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}