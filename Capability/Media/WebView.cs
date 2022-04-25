namespace Uplink.Capability.Media
{
    public class WebView : Capability
    {

        public WebView()
        {
            StringType = "WebView";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}