namespace Uplink.Capability.Menu
{
    public class FullScreenToggle : Capability
    {

        public FullScreenToggle()
        {
            StringType = "FullScreenToggle";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}