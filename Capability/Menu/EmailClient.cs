namespace Uplink.Capability.Menu
{
    public class EmailClient : Capability
    {

        public EmailClient()
        {
            StringType = "EmailClient";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}