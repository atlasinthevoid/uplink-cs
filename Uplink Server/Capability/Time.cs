namespace Uplink.Capability
{
    public class Time : Capability
    {
        public DateTime Value
        {
            get;
            init;
        }
        public bool Timer
        {
            get;
            init;
        }
        public bool Clock
        {
            get;
            init;
        }
        public int SecondsToUpdate
        {
            get;
            init;
        }
        public bool TimeElapsed
        {
            get;
            init;
        }

        public Time()
        {
            Time = DateTime.Now;
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
                        Console.WriteLine(s + DateTime.Now);
                        TimeElapsed = false;
                    }
                    Value = DateTime.Now;
                }
            }
        }
    }
}