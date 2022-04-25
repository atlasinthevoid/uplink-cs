namespace Uplink.Capability.Layout
{
    public class TreeView : Capability
    {

        public TreeView()
        {
            StringType = "TreeView";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}