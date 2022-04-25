namespace Uplink.Capability.Menu
{
    public class WebBrowser : Capability
    {
        public WebBrowser()
        {
            StringType = "WebBrowser";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}