namespace Uplink.Capability.StatusBar
{
    public class ProgressRing : Capability
    {
        public ProgressRing()
        {
            StringType = "ProgressRing";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}