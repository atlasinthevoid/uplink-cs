namespace Uplink.Capability.Core
{
    public class UniverseCache : Capability
    {

        public UniverseCache()
        {
            StringType = "UniverseCache";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}