namespace Uplink.Capability.Core
{
    public class Quest2Streamer : Capability
    {

        public Quest2Streamer()
        {
            StringType = "Quest2Streamer";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}