namespace Uplink.Capability.Toolbar
{
    public class CommandBar : Capability
    {
        public CommandBar()
        {
            StringType = "CommandBar";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}