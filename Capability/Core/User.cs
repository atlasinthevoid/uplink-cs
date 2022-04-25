namespace Uplink.Capability.Core
{
    public class User : Capability
    {

        public User()
        {
            StringType = "User";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}