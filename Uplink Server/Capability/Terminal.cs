namespace Uplink.Capability
{
    public class Terminal : Capability
    {
        public Terminal()
        {
            Console.CancelKeyPress += new ConsoleCancelEventHandler(ExitHandler);
            Program.TerminalSystem.Register(this);
        }

        public override void Update()
        {
            
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