namespace Uplink.Capability.Toolbar
{
    public class MenuFlyout : Capability
    {
        public MenuFlyout()
        {
            StringType = "MenuFlyout";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}