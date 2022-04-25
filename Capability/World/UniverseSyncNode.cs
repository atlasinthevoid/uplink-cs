namespace Uplink.Capability.World
{
    public class UniverseSyncNode : Capability
    {
        public UniverseSyncNode()
        {
            StringType = "UniverseSyncNode";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}