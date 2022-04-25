namespace Uplink.Capability.Menu
{
    public class AppLauncher : Capability
    {
        public AppLauncher()
        {
            StringType = "AppLauncher";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}