namespace Uplink.Capability.Menu
{
    public class ObjectBrowser : Capability
    {
        public ObjectBrowser()
        {
            StringType = "ObjectBrowser";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}