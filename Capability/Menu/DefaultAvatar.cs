namespace Uplink.Capability.Menu
{
    public class DefaultAvatar : Capability
    {

        public DefaultAvatar()
        {
            StringType = "DefaultAvatar";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}