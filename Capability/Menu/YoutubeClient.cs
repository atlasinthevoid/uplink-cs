namespace Uplink.Capability.Menu
{
    public class YoutubeClient : Capability
    {
        public YoutubeClient()
        {
            StringType = "YoutubeClient";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}