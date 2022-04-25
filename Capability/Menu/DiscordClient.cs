namespace Uplink.Capability.Menu
{
    public class DiscordClient : Capability
    {

        public DiscordClient()
        {
            StringType = "DiscordClient";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}