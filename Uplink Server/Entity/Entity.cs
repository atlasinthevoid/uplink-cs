namespace Uplink.Entity
{
    public class Entity
    {
        public Type.Metadata Metadata;
        public Type.Capabilities<Capability.Capability> Capabilities;

        public Entity() 
        {
            Capabilities = new();
            Metadata = new();
        }

        public void Add(Capability.Capability capability)
        {
            Capabilities.Add(capability);
            capability.Metadata.Add(new Type.Parent() { Value = this });
        }
    }
}
