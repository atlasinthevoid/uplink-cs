namespace Uplink.Entity
{
    public class Entity
    {
        public Type.Id Id
        {
            get;
            init;
        }
        public Type.Capabilities Capabilities;

        public Entity()
        {
            Id = new();
            Capabilities = new();
        }

        public void Add(Capability.Capability capability)
        {
            Capabilities.Add(capability);
            capability.Metadata.Add(new Type.Parent() { Value = this; })
        }
    }
}
