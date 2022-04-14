namespace Uplink.Entity
{
    public abstract class Entity
    {
        Type.Id Id;
        List<Component.Component> components;

        public Entity()
        {
            Id = new();
            components = new();
        }
    }
}
