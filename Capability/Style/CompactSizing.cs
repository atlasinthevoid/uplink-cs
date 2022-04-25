namespace Uplink.Capability.Style
{
    public class CompactSizing : Capability
    {
        public CompactSizing()
        {
            StringType = "CompactSizing";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}