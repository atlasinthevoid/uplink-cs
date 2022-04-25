namespace Uplink.Capability.Core
{
    public class Bool : Capability
    {
        public bool Flag;

        public Bool()
        {
            StringType = "Bool";
            Flag = false;
            Program.Systems.Register(this);
        }

        public override void Update()
        {
            
        }
    }
}