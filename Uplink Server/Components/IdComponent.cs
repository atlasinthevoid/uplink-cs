namespace Uplink
{
    public class IdComponent : Component
    {
        public Guid Value
        {
            get;
            init;
        }

        public IdComponent()
        {
            Value = Guid.Empty;
        }

        public override void Update()
        {
            
        }
    }
}