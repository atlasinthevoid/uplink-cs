namespace Uplink.Capability.Toolbar
{
    public class AppBarToggleButton : Capability
    {
        public AppBarToggleButton()
        {
            StringType = "AppBarToggleButton";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}