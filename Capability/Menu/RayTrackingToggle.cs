namespace Uplink.Capability.Menu
{
    public class RayTrackingToggle : Capability
    {
        public RayTrackingToggle()
        {
            StringType = "RayTrackingToggle";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}