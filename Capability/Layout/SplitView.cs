namespace Uplink.Capability.Layout
{
    public class SplitView : Capability
    {

        public SplitView()
        {
            StringType = "SplitView";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}