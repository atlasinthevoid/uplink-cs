namespace Uplink.Command
{
    public class Log : Command
    {
        public string Message;
        public string Level = "Log";

        public Log()
        {
            Message = "";
            StringType = "Log";
        }

        internal override void Exec()
        {
            if (Level == "Trace")
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
            } else if (Level == "Log")
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
            } else if (Level == "Debug")
            {
                Console.ForegroundColor = ConsoleColor.Green;
            } else if (Level == "Info")
            {
                Console.ForegroundColor = ConsoleColor.White;
            } else if (Level == "Warn")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            } else if (Level == "Error")
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }

            Console.WriteLine("[ " + Level + " ] " + Message);
            Console.ResetColor();
        }

        public override void Undo()
        {

        }
    }
}
