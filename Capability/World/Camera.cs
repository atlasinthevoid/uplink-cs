namespace Uplink.Capability.World
{
    public class Camera : Capability
    {

        public Camera()
        {
            StringType = "Camera";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}