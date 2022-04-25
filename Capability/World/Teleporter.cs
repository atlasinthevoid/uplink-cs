namespace Uplink.Capability.World
{
    public class Teleporter : Capability
    {
        public Teleporter()
        {
            StringType = "Teleporter";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}