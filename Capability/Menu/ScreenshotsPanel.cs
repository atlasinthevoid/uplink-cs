namespace Uplink.Capability.Menu
{
    public class ScreenshotsPanel : Capability
    {
        public ScreenshotsPanel()
        {
            StringType = "ScreenshotsPanel";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}