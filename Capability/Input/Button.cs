namespace Uplink.Capability.Input
{
    public class Button : Capability
    {

        public Button()
        {
            StringType = "Button";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}