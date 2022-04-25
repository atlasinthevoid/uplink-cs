namespace Uplink.Capability.Core
{
    public class Notification : Capability
    {

        public Notification()
        {
            StringType = "Notification";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}