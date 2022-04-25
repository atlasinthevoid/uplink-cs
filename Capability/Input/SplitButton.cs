namespace Uplink.Capability.Input
{
    public class SplitButton : Capability
    {

        public SplitButton()
        {
            StringType = "SplitButton";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}