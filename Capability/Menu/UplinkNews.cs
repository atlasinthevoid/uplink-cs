namespace Uplink.Capability.Menu
{
    public class UplinkNews : Capability
    {
        public UplinkNews()
        {
            StringType = "UplinkNews";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}