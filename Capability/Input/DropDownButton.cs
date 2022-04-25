namespace Uplink.Capability.Input
{
    public class DropDownButton : Capability
    {

        public DropDownButton()
        {
            StringType = "DropDownButton";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}