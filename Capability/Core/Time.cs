namespace Uplink.Capability.Core
{
    public class Time : Capability
    {
        public DateTime Value;
        public bool Timer;
        public bool Clock;
        public int SecondsToUpdate;
        public bool TimeElapsed;

        public Time()
        {
            StringType = "Time";
            Value = DateTime.Now;
            Program.Systems.Register(this);
        }

        public override void Update()
        {
            if (Timer)
            {
                TimeSpan span = DateTime.Now - Value;
                if (span.TotalSeconds >= SecondsToUpdate)
                {
                    TimeElapsed = true;
                    if (Clock)
                    {
                        string s = "System time is ";
                        Command.Log l = new();
                        l.Message = s + DateTime.Now;
                        l.Execute();

                        TimeElapsed = false;
                    }
                    Value = DateTime.Now;
                }
            }
        }
    }
}