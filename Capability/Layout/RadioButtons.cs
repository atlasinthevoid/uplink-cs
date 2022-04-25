namespace Uplink.Capability.Layout
{
    public class RadioButtons : Capability
    {

        public RadioButtons()
        {
            StringType = "RadioButtons";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}