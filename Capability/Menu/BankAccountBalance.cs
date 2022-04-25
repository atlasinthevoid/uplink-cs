namespace Uplink.Capability.Menu
{
    public class BankAccountBalance : Capability
    {
        public BankAccountBalance()
        {
            StringType = "BankAccountBalance";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}