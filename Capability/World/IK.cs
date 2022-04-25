namespace Uplink.Capability.World
{
    public class IK : Capability
    {

        public IK()
        {
            StringType = "IK";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}