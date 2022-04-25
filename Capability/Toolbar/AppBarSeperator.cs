namespace Uplink.Capability.Toolbar
{
    public class AppBarSeperator : Capability
    {
        public AppBarSeperator()
        {
            StringType = "AppBarSeperator";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}