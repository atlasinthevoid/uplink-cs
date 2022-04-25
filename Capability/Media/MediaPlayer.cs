namespace Uplink.Capability.Media
{
    public class MediaPlayer : Capability
    {

        public MediaPlayer()
        {
            StringType = "MediaPlayer";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}