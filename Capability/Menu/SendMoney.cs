namespace Uplink.Capability.Menu
{
    public class SendMoney : Capability
    {
        public SendMoney()
        {
            StringType = "SendMoney";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}