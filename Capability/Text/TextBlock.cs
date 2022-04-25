namespace Uplink.Capability.Text
{
    public class TextBlock : Capability
    {
        public TextBlock()
        {
            StringType = "TextBlock";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}