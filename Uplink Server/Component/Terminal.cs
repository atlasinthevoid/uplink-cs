namespace Uplink.Component
{
    public class Terminal : Component
    {
        public Terminal()
        {
            Console.CancelKeyPress += new ConsoleCancelEventHandler(ExitHandler);

            Entity terminal = new();
            terminal.Add(new Terminal() { Name = "terminal 0" });
            Parent.ByName<State>()[0].Add(terminal);
        }

        public override void Update()
        {
            
        }

        void ExitHandler(object? sender, ConsoleCancelEventArgs args)
        {
            Console.WriteLine("CANCEL command received! Cleaning up. please wait...");

            List<Component> searchComponents = new();
            searchComponents.Add(new Terminal() { Name = "terminal 0" });
            Entity terminal = new();//LocalState.GetEntity(searchComponents)[0];
            terminal.Add(new Text() { Name = Parent.Id.ToString(), Text = "cancelled" });
            terminal.Add(new Save() { Name = "save on close", SaveToFile = true });
            Parent.ByName<State>()[0].Add(terminal);
        }
    }
}