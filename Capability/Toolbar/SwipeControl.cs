namespace Uplink.Capability.Toolbar
{
    public class SwipeControl : Capability
    {
        public SwipeControl()
        {
            StringType = "SwipeControl";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}