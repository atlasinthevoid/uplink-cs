namespace Uplink.Capability.Menu
{
    public class Profile : Capability
    {

        public Profile()
        {
            StringType = "Profile";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}