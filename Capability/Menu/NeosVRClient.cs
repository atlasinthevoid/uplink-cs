namespace Uplink.Capability.Menu
{
    public class NeosVRClient : Capability
    {

        public NeosVRClient()
        {
            StringType = "NeosVRClient";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}