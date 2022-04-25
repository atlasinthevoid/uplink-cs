namespace Uplink.Capability.Style
{
    public class ColorPalette : Capability
    {
        public ColorPalette()
        {
            StringType = "ColorPalette";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}