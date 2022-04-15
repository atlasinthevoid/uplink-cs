namespace Uplink.Capability
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
            Number = 0.0f;
        }

        public override void Update()
        {
            
        }
    }
}