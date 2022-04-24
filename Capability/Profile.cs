namespace Uplink.Capability
{
    public class Profile : Capability
    {

        public Profile()
        {
            StringType = "Profile";
            Program.ProfileSystem.Register(this);
        }

        public override void Update()
        {

        }
    }
}