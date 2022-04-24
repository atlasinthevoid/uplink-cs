namespace Uplink.Capability
{
    public class Button : Capability
    {

        public Button()
        {
            StringType = "Button";
            Program.ButtonSystem.Register(this);
        }

        public override void Update()
        {

        }
    }
}