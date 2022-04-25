namespace Uplink.Capability.Input
{
    public class RadioButton : Capability
    {

        public RadioButton()
        {
            StringType = "RadioButton";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}