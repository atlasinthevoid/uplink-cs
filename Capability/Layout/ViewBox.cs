namespace Uplink.Capability.Layout
{
    public class ViewBox : Capability
    {

        public ViewBox()
        {
            StringType = "ViewBox";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}