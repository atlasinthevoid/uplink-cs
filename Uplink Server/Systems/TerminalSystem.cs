namespace Uplink
{
    public class TerminalSystem : SystemComponent
    {
        public TerminalSystem()
        {

        }

        public TerminalSystem(string name, State state) : base(name, state)
        {
            Console.CancelKeyPress += new ConsoleCancelEventHandler(ExitHandler);

            Entity terminal = new();
            terminal.Add(new TerminalComponent(LocalState.Id, "terminal 0"));
            state.Entities.Add(terminal);
        }

        public void Update()
        {
            foreach (Entity e in LocalState.Entities)
            {
                foreach (dynamic c in e.Components)
                {
                    if (c is TerminalComponent)
                    {

                    }
                }
            }
        }

        void ExitHandler(object? sender, ConsoleCancelEventArgs args)
        {
            Console.WriteLine("CANCEL command received! Cleaning up. please wait...");
            
            List<Component> searchComponents = new();
            searchComponents.Add(new TerminalComponent(LocalState.Id, "terminal 0"));
            Entity terminal = new();//LocalState.GetEntity(searchComponents)[0];
            terminal.Add(new TextComponent(LocalState.Id, LocalState.Id.ToString(), "cancelled"));
            terminal.Add(new SaveComponent(LocalState.Id, "save on close", true));
            LocalState.Entities.Add(terminal);
        }
    }
}