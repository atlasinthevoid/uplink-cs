namespace Uplink.Capability
{
    public class Terminal : Capability
    {
        public Terminal()
        {
            Console.CancelKeyPress += new ConsoleCancelEventHandler(ExitHandler);
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
            /*
            Terminal terminal = Program.TerminalSystem.Capabilities.ByName(new Type.Name() { Value = "terminal 0" })[0];
            Entity.Entity e = terminal.Metadata.Get(Type.Parent.StringType)];
            e.Add(new Text() { 
                Metadata = new() { new Type.Name() { Parent.Id.ToString() } },
                Value = "cancelled"
            });

            e.Add(new Save() {
                Metadata = new() { new Type.Name() { Value = "save on close" } },
                SaveToFile = true
            });*/
        }
    }
}