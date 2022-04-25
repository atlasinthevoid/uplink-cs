namespace Uplink.Capability.Toolbar
{
    public class CommandBarFlyout : Capability
    {
        public CommandBarFlyout()
        {
            StringType = "CommandBarFlyout";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}