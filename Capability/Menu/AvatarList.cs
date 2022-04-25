namespace Uplink.Capability.Menu
{
    public class AvatarList : Capability
    {
        public AvatarList()
        {
            StringType = "AvatarList";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}