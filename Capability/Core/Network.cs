namespace Uplink.Capability.Core
{
    public class Network : Capability
    {
        public Dictionary<StereoKit.Vec3, Type.Entities<Type.Entity>> Chunks;
        public string BootstrapServer = "universe.void.contact";

        public Network()
        {
            StringType = "Network";
            Chunks = new();
            Program.Systems.Register(this);
        }

        public override void Update()
        {
            // Hash entities to position chunk table
            // Host Network Node for position chunks
            // Fetch chunks from uplink.void.contact
        }
    }
}