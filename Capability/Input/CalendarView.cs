namespace Uplink.Capability.Input
{
    public class CalendarView : Capability
    {

        public CalendarView()
        {
            StringType = "CalendarView";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}