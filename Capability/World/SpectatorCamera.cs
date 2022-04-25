namespace Uplink.Capability.World
{
    public class SpectatorCamera : Capability
    {
        public SpectatorCamera()
        {
            StringType = "SpectatorCamera";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}