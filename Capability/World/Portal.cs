namespace Uplink.Capability.World
{
    public class Portal : Capability
    {
        public Portal()
        {
            StringType = "Portal";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}