namespace Uplink.Capability.Menu
{
    public class DebugStats : Capability
    {

        public DebugStats()
        {
            StringType = "DebugStats";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}