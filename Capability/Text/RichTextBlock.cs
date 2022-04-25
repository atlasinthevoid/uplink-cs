namespace Uplink.Capability.Text
{
    public class RichTextBlock : Capability
    {
        public RichTextBlock()
        {
            StringType = "RichTextBlock";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}