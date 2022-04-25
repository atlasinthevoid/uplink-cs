namespace Uplink.Capability.Menu
{
    public class SettingsWindow : Capability
    {
        public SettingsWindow()
        {
            StringType = "SettingsWindow";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}