namespace Uplink.Capability.Menu
{
    public class ShutdownButton : Capability
    {
        public ShutdownButton()
        {
            StringType = "ShutdownButton";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}