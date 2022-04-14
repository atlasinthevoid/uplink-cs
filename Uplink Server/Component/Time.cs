namespace Uplink
{
    public class TimeComponent : Component
    {
        public DateTime Value;
        public bool Timer;
        public bool Clock;
        public int SecondsToUpdate;
        public bool TimeElapsed;

        public TimeComponent()
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