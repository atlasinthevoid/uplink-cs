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
            Program.IdSystem.Register(this);
        }

        public override void Update()
        {
            
        }
    }
}