namespace Uplink.Capability.Input
{
    public class ColorPicker : Capability
    {

        public ColorPicker()
        {
            StringType = "ColorPicker";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}