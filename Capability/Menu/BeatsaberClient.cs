namespace Uplink.Capability.Menu
{
    public class BeatsaberClient : Capability
    {
        public BeatsaberClient()
        {
            StringType = "BeatsaberClient";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}