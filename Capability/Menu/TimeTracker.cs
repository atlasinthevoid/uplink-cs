namespace Uplink.Capability.Menu
{
    public class TimeTracker : Capability
    {
        public TimeTracker()
        {
            StringType = "TimeTracker";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}