namespace Uplink.Component
{
    public class Bool : Component
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