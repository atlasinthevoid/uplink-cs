public class TerminalSystem : SystemComponent
{
    public TerminalSystem(string name, State state) : base(name, state)
    {
        Console.CancelKeyPress += new ConsoleCancelEventHandler(ExitHandler);
    }

    public void Update()
    {
        Console.WriteLine("update");
    }

    void ExitHandler(object? sender, ConsoleCancelEventArgs args)
    {
        Console.WriteLine("CANCEL command received! Cleaning up. please wait...");
        SaveUniverseToFile(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\Uplink\");

        _ = CreateEvent("update", new() { new(broadcaster.Id.ToString()), new("cancelled") }, true);
        Environment.Exit(0);
    }
}