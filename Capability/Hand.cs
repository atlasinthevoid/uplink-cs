namespace Uplink.Capability
{
    public class Hand : Capability
    {

        public Hand()
        {
            StringType = "Hand";
            Program.HandSystem.Register(this);
        }

        public override void Update()
        {

        }
    }
}