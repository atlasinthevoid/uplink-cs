namespace Uplink.Capability.Navigation
{
    public class BreadcrumbBar : Capability
    {
        public BreadcrumbBar()
        {
            StringType = "BreadcrumbBar";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}