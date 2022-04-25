namespace Uplink.Capability.Menu
{
    public class SpotifyClient : Capability
    {
        public SpotifyClient()
        {
            StringType = "SpotifyClient";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}