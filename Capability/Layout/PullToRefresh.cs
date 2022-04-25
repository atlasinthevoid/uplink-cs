namespace Uplink.Capability.Layout
{
    public class PullToRefresh : Capability
    {

        public PullToRefresh()
        {
            StringType = "PullToRefresh";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}