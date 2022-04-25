namespace Uplink.Capability.World
{
    public class MorphIntoAvatar : Capability
    {

        public MorphIntoAvatar()
        {
            StringType = "MorphIntoAvatar";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}