namespace Uplink.Capability.Navigation
{
    public class TabView : Capability
    {
        public TabView()
        {
            StringType = "TabView";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}