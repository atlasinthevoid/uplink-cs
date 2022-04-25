namespace Uplink.Capability.Menu
{
    public class FovSlider : Capability
    {

        public FovSlider()
        {
            StringType = "FovSlider";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}