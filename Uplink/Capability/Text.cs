namespace Uplink.Capability
{
    public class Text : Capability
    {
        public string Value;

        public Text()
        {
            Value = "";
            Program.TextSystem.Register(this);
        }

        public override void Update()
        {
            
        }
    }
}