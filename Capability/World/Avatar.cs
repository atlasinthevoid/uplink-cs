namespace Uplink.Capability.World
{
    public class Avatar : Capability
    {

        public Avatar()
        {
            StringType = "Avatar";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}