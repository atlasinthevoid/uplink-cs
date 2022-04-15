namespace Uplink.Capability
{
    public class Id : Capability
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