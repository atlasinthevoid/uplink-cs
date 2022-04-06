public class LoadingSystem : SystemComponent
{
    public LoadingSystem(string name, State state) : base(name, state)
    {
        LoadUniverseFromFile(await );
    }

    public void Update()
    {
        Console.WriteLine("update");
    }

    void LoadUniverseFromFile(string directory)
    {
        Console.WriteLine("Loading universe from file...");
        if (!File.Exists(directory + "Id.yaml")
            || !File.Exists(directory + "Entities.yaml")
            || !File.Exists(directory + "Events.yaml")
            || !File.Exists(directory + "Index.yaml"))
        {
            Event checkEvent = new(
                EntityId, "update", new() { 
                    new TextComponent("text", "universe save file not found") });
            LocalState.Events.Add(checkEvent);
            return;
        }

        //File.ReadAllText(directory + "Objects.json")
    }
}