namespace Uplink.Capability.Input
{
    public class CalendarDatePicker : Capability
    {

        public CalendarDatePicker()
        {
            StringType = "CalendarDatePicker";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}