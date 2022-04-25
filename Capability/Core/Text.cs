namespace Uplink.Capability.Core
{
    public class Text : Capability
    {
        public string Value;

        public Text()
        {
            StringType = "Text";
            Value = "";
            Program.Systems.Register(this);
        }

        public override void Update()
        {
            
        }
    }
}