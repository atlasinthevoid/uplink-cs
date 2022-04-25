namespace Uplink.Capability.Menu
{
    public class ReceiveMoney : Capability
    {
        public ReceiveMoney()
        {
            StringType = "ReceiveMoney";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}