namespace Uplink.Capability.Menu
{
    public class SleepButton : Capability
    {
        public SleepButton()
        {
            StringType = "SleepButton";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}