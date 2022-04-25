namespace Uplink.Capability.World
{
    public class SystemInfomation : Capability
    {
        public SystemInfomation()
        {
            StringType = "SystemInfomation";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}