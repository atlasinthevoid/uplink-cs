namespace Uplink.Capability.World
{
    public class SystemStatus : Capability
    {
        public SystemStatus()
        {
            StringType = "SystemStatus";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}