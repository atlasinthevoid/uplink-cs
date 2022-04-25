namespace Uplink.Capability.Menu
{
    public class AdvancedOptions : Capability
    {
        public AdvancedOptions()
        {
            StringType = "AdvancedOptions";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}