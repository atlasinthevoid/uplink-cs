namespace Uplink.Capability.Core
{
    public class Id : Capability
    {
        public Guid Value;

        public Id()
        {
            StringType = "Id";
            Value = Guid.Empty;
            Program.Systems.Register(this);
        }

        public override void Update()
        {
            
        }
    }
}