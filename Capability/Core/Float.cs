namespace Uplink.Capability.Core
{
    public class Float : Capability
    {
        public float Number
        {
            get;
            init;
        }

        public Float()
        {
            StringType = "Float";
            Number = 0.0f;
            Program.Systems.Register(this);
        }

        public override void Update()
        {
            
        }
    }
}