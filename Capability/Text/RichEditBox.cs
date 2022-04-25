namespace Uplink.Capability.Text
{
    public class RichEditBox : Capability
    {
        public RichEditBox()
        {
            StringType = "RichEditBox";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}