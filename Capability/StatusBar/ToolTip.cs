namespace Uplink.Capability.StatusBar
{
    public class ToolTip : Capability
    {
        public ToolTip()
        {
            StringType = "ToolTip";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}