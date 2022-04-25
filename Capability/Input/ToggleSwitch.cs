namespace Uplink.Capability.Input
{
    public class ToggleSwitch : Capability
    {

        public ToggleSwitch()
        {
            StringType = "ToggleSwitch";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}