namespace Uplink.Capability.Input
{
    public class TimePicker : Capability
    {

        public TimePicker()
        {
            StringType = "TimePicker";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}