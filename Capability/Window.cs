namespace Uplink.Capability
{
    public class Window : Capability
    {

        public Window()
        {
            StringType = "Window";
            Program.WindowSystem.Register(this);
        }

        public override void Update()
        {

        }
    }
}