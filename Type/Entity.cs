namespace Uplink.Type
{
    public class Entity : Type
    {
        public Metadata Metadata;
        public Capabilities<Capability.Capability> Capabilities;

        public Entity() 
        {
            StringType = "Entity";
            Capabilities = new();
            Metadata = new();
        }

        public void Add(Capability.Capability capability)
        {
            Capabilities.Add(capability);
            capability.Metadata.Add(new Parent() { Value = this });
        }
    }
}
