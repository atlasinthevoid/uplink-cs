namespace Uplink.Capability.Menu
{
    public class SocialStatusSetter : Capability
    {
        public SocialStatusSetter()
        {
            StringType = "SocialStatusSetter";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}