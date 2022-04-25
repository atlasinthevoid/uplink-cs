namespace Uplink.Capability.Menu
{
    public class UniverseBrowser : Capability
    {
        public UniverseBrowser()
        {
            StringType = "UniverseBrowser";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}