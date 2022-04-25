namespace Uplink.Capability.Motion
{
    public class Animation : Capability
    {
        public Animation()
        {
            StringType = "Animation";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}