namespace Uplink.Capability.Menu
{
    public class Window : Capability
    {

        public Window()
        {
            StringType = "Window";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}