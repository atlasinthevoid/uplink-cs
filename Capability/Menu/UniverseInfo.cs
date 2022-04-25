namespace Uplink.Capability.Menu
{
    public class UniverseInfo : Capability
    {
        public UniverseInfo()
        {
            StringType = "UniverseInfo";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}