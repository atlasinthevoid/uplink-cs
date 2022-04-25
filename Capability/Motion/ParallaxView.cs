namespace Uplink.Capability.Motion
{
    public class ParallaxView : Capability
    {
        public ParallaxView()
        {
            StringType = "ParallaxView";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}