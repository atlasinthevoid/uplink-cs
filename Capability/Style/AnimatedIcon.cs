namespace Uplink.Capability.Style
{
    public class AnimatedIcon : Capability
    {
        public AnimatedIcon()
        {
            StringType = "AnimatedIcon";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}