namespace Uplink
{
    public class BoolComponent : Component
    {
        public bool Flag
        {
            get;
            init;
        }

        public BoolComponent()
        {
            Flag = false;
        }

        public override void Update()
        {
            
        }
    }
}