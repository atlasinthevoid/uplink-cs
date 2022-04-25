namespace Uplink.Capability.Toolbar
{
    public class AppBarButton : Capability
    {
        public AppBarButton()
        {
            StringType = "AppBarButton";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}