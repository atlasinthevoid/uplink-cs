namespace Uplink.Capability.Menu
{
    public class BatteryLevelTracker : Capability
    {
        public BatteryLevelTracker()
        {
            StringType = "BatteryLevelTracker";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}