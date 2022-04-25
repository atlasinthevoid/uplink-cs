namespace Uplink.Capability.Layout
{
    public class RelativePanel : Capability
    {

        public RelativePanel()
        {
            StringType = "RelativePanel";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}