namespace Uplink.Capability.Input
{
    public class HyperlinkButton : Capability
    {

        public HyperlinkButton()
        {
            StringType = "HyperlinkButton";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}