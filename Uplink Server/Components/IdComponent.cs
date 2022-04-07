namespace Uplink
{
    public class IdComponent : Component
    {
        public Guid? Value;

        public IdComponent()
        {
            Value = Guid.Empty;
        }

        public IdComponent(Guid author, string name, Guid id) : base(author, name)
        {
            Value = id;
        }
    }
}