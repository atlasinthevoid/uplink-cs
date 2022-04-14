namespace Uplink.Component
{
    public class Id : Component
    {
        public Guid Value
        {
            get;
            init;
        }

        public Id()
        {
            Value = Guid.Empty;
        }

        public override void Update()
        {
            
        }
    }
}