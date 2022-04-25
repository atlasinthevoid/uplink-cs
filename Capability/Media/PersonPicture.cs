namespace Uplink.Capability.Media
{
    public class PersonPicture : Capability
    {

        public PersonPicture()
        {
            StringType = "PersonPicture";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}