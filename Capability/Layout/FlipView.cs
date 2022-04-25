namespace Uplink.Capability.Layout
{
    public class FlipView : Capability
    {

        public FlipView()
        {
            StringType = "FlipView";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}