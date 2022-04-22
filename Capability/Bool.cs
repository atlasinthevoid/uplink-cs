namespace Uplink.Capability
{
    public class Bool : Capability
    {
        public bool Flag;

        public Bool()
        {
            Flag = false;
            Program.BoolSystem.Register(this);
        }

        public override void Update()
        {
            
        }
    }
}