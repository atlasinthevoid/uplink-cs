namespace Uplink.Capability.Input
{
    public class ToggleButton : Capability
    {

        public ToggleButton()
        {
            StringType = "ToggleButton";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}