namespace Uplink.Capability.Menu
{
    public class VolumeControl : Capability
    {
        public VolumeControl()
        {
            StringType = "VolumeControl";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}