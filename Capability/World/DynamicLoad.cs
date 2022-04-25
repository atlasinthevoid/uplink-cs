namespace Uplink.Capability.World
{
    public class DynamicLoad : Capability
    {

        public DynamicLoad()
        {
            StringType = "DynamicLoad";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}