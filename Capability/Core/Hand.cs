namespace Uplink.Capability.Core
{
    public class Hand : Capability
    {

        public Hand()
        {
            StringType = "Hand";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}