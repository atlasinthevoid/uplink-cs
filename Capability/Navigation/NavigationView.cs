namespace Uplink.Capability.Navigation
{
    public class NavigationView : Capability
    {
        public NavigationView()
        {
            StringType = "NavigationView";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}