namespace Uplink.Capability.World
{
    public class RenderScaleOption : Capability
    {
        public RenderScaleOption()
        {
            StringType = "RenderScaleOption";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}