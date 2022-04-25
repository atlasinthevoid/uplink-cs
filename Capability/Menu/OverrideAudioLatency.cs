namespace Uplink.Capability.Menu
{
    public class OverrideAudioLatency : Capability
    {
        public OverrideAudioLatency()
        {
            StringType = "OverrideAudioLatency";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}