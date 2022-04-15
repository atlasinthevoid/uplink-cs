namespace Uplink.Capability
{
    public class Text : Capability
    {
        public string Value
        {
            get;
            init;
        }

        public Text()
        {
            Value = "";
        }

        public override void Update()
        {
            
        }
    }
}