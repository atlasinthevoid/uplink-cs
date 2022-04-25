namespace Uplink.Capability.Input
{
    public class RepeatButton : Capability
    {

        public RepeatButton()
        {
            StringType = "RepeatButton";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}