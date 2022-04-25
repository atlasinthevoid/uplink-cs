namespace Uplink.Capability.Motion
{
    public class PageTransitions : Capability
    {
        public PageTransitions()
        {
            StringType = "PageTransitions";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}