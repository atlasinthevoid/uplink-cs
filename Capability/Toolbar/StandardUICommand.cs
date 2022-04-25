namespace Uplink.Capability.Toolbar
{
    public class StandardUICommand : Capability
    {
        public StandardUICommand()
        {
            StringType = "StandardUICommand";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}