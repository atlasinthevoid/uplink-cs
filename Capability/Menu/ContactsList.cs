namespace Uplink.Capability.Menu
{
    public class ContactsList : Capability
    {

        public ContactsList()
        {
            StringType = "ContactsList";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}