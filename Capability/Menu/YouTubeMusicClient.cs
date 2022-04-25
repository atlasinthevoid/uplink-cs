namespace Uplink.Capability.Menu
{
    public class YouTubeMusicClient : Capability
    {
        public YouTubeMusicClient()
        {
            StringType = "YouTubeMusicClient";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}