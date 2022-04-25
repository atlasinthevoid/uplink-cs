namespace Uplink.Capability.Menu
{
    public class VersionInfomation : Capability
    {
        public VersionInfomation()
        {
            StringType = "VersionInfomation";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}