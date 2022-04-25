namespace Uplink.Capability.Input
{
    public class Slider : Capability
    {

        public Slider()
        {
            StringType = "Slider";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}