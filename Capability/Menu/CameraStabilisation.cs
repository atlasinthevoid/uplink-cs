namespace Uplink.Capability.Menu
{
    public class CameraStabilisation : Capability
    {

        public CameraStabilisation()
        {
            StringType = "CameraStabilisation";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}