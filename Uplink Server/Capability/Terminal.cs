namespace Uplink.Capability
{
    public class Terminal : Capability
    {
        public Terminal()
        {
            Console.CancelKeyPress += new ConsoleCancelEventHandler(ExitHandler);

            new Terminal() { Name = "terminal 0" };
        }

        public override void Update()
        {
            
        }

        void ExitHandler(object? sender, ConsoleCancelEventArgs args)
        {
            Console.WriteLine("CANCEL command received! Cleaning up. please wait...");

            if (Program.TerminalSystem.Capabilities == null)
            {
                return;
            }
            Terminal terminal = Program.TerminalSystem.Capabilities.ByName(new Type.Name() { Value = "terminal 0" })[0];
            Entity e = terminal.Metadata[typeof(Type.Parent)]
            terminal.Add(new Text() { 
                Metadata = new() { new Type.Name() { Parent.Id.ToString() } },
                Value = "cancelled"
            });

            terminal.Add(new Save() {
                Metadata = new() { new Type.Name() { Value = "save on close" } },
                SaveToFile = true
            });
        }
    }
}