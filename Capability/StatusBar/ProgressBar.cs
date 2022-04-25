namespace Uplink.Capability.StatusBar
{
    public class ProgressBar : Capability
    {
        public ProgressBar()
        {
            StringType = "ProgressBar";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}