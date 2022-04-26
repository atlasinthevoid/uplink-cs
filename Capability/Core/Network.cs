namespace Uplink.Capability.Core
{
    public class Network : Capability
    {

        public Network()
        {
            StringType = "Network";
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