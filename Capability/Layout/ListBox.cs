namespace Uplink.Capability.Layout
{
    public class ListBox : Capability
    {

        public ListBox()
        {
            StringType = "ListBox";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}