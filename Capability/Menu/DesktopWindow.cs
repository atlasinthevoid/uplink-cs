namespace Uplink.Capability.Menu
{
    public class DesktopWindow : Capability
    {

        public DesktopWindow()
        {
            StringType = "DesktopWindow";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}