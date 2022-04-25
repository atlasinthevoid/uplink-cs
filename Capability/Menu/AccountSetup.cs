namespace Uplink.Capability.Menu
{
    public class AccountSetup : Capability
    {
        public AccountSetup()
        {
            StringType = "AccountSetup";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}