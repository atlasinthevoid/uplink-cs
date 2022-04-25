namespace Uplink.Capability.Menu
{
    public class VideoPlayer : Capability
    {
        public VideoPlayer()
        {
            StringType = "VideoPlayer";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}