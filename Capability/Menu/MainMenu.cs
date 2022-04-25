namespace Uplink.Capability.Menu
{
    public class MainMenu : Capability
    {

        public MainMenu()
        {
            StringType = "MainMenu";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}