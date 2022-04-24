namespace Uplink.Capability
{
    public class Id : Capability
    {
        public Guid Value;

        public Id()
        {
            StringType = "Id";
            Value = Guid.Empty;
            Program.IdSystem.Register(this);
        }

        public override void Update()
        {
            
        }
    }
}