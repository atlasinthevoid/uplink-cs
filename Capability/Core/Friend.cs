namespace Uplink.Capability.Core
{
    public class Friend : Capability
    {

        public Friend()
        {
            StringType = "Friend";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}