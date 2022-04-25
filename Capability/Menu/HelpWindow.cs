namespace Uplink.Capability.Menu
{
    public class HelpWindow : Capability
    {

        public HelpWindow()
        {
            StringType = "HelpWindow";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}