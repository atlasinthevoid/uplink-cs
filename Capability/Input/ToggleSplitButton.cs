namespace Uplink.Capability.Input
{
    public class ToggleSplitButton : Capability
    {

        public ToggleSplitButton()
        {
            StringType = "ToggleSplitButton";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}