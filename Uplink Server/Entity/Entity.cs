namespace Uplink.Entity
{
    public abstract class Entity
    {
        public Type.Id Id;

        public Entity()
        {
            Id = new();
            Components = new();
        }

        public List<Component.Component> GetComponents()
        {
            // Call event
            return new();
        }

        public List<Component.Component> GetComponentByName()
        {
            // Call event
            return new();
        }
    }
}
