namespace Uplink.Capability.World
{
    public class PossessObject : Capability
    {
        public PossessObject()
        {
            StringType = "PossessObject";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}