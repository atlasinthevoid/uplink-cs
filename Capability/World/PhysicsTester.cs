namespace Uplink.Capability.World
{
    public class PhysicsTester : Capability
    {
        public PhysicsTester()
        {
            StringType = "PhysicsTester";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}