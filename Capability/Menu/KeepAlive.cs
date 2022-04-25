namespace Uplink.Capability.Menu
{
    public class KeepAlive : Capability
    {

        public KeepAlive()
        {
            StringType = "KeepAlive";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}