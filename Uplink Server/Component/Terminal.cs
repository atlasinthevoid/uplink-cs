namespace Uplink
{
    public class TerminalComponent : Component
    {
        public TerminalComponent()
        {
            Console.CancelKeyPress += new ConsoleCancelEventHandler(ExitHandler);

            Entity terminal = new();
            terminal.Add(new TerminalComponent() { Name = "terminal 0" });
            Parent.ByName<State>()[0].Add(terminal);
        }

        public override void Update()
        {
            
        }

        void ExitHandler(object? sender, ConsoleCancelEventArgs args)
        {
            Console.WriteLine("CANCEL command received! Cleaning up. please wait...");

            List<Component> searchComponents = new();
            searchComponents.Add(new TerminalComponent() { Name = "terminal 0" });
            Entity terminal = new();//LocalState.GetEntity(searchComponents)[0];
            terminal.Add(new TextComponent() { Name = Parent.Id.ToString(), Text = "cancelled" });
            terminal.Add(new SaveComponent() { Name = "save on close", SaveToFile = true });
            Parent.ByName<State>()[0].Add(terminal);
        }
    }
}