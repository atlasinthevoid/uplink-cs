namespace Uplink.Capability.Text
{
    public class TextBox : Capability
    {
        public TextBox()
        {
            StringType = "TextBox";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}