namespace Uplink.Capability.Menu
{
    public class Terminal : Capability
    {
        public Terminal()
        {
            StringType = "Terminal";
            Console.CancelKeyPress += new ConsoleCancelEventHandler(ExitHandler);
            Program.Systems.Register(this);
        }

        public override void Update()
        {
            ThreadPool.QueueUserWorkItem(ThreadProc);
        }

        void ThreadProc(Object? state)
        {
            string? cmd = Console.ReadLine();
            if (cmd == null)
            {
                return;
            } else if (cmd == "test")
            {
                Console.WriteLine("hellwo world");
            }
            else
            {
                Console.WriteLine("Invaild command");
            }
        }

        void ExitHandler(object? sender, ConsoleCancelEventArgs args)
        {
            Command.Log l = new();
            l.Message = "CANCEL command received! Cleaning up. please wait...";
            l.Level = "Info";
            l.Execute();

            Environment.Exit(0);
        }
    }
}