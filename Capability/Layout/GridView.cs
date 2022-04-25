namespace Uplink.Capability.Layout
{
    public class GridView : Capability
    {

        public GridView()
        {
            StringType = "GridView";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}