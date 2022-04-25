namespace Uplink.Capability.Input
{
    public class DatePicker : Capability
    {

        public DatePicker()
        {
            StringType = "DatePicker";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}