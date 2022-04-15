namespace Uplink.Capability
{
    public class Bool : Capability
    {
        public bool Flag
        {
            get;
            init;
        }

        public Bool()
        {
            Flag = false;
        }

        public override void Update()
        {
            
        }
    }
}