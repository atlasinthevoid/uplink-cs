namespace Uplink.Capability
{
    public class Avatar : Capability
    {

        public Avatar()
        {
            StringType = "Avatar";
            Program.AvatarSystem.Register(this);
        }

        public override void Update()
        {

        }
    }
}