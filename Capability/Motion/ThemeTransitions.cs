namespace Uplink.Capability.Motion
{
    public class ThemeTransitions : Capability
    {
        public ThemeTransitions()
        {
            StringType = "ThemeTransitions";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}