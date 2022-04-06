public class SaveSystem : SystemComponent
{
    public SaveSystem(string name, State state) : base(name, state)
    {

    }

    public void Update()
    {
        Console.WriteLine("update");
    }

    // Saves global state
    void SaveUniverseToFile(string directory)
    {
        /*
        class Universe
        {
            public Dictionary<Guid, UplinkObject> Objects;
            public Dictionary<UplinkTag, List<Guid>> Index;
        }

        class Broadcaster
        {
            public Guid Id;
            public Dictionary<Guid, UplinkEvent> Events;
            public List<Guid> EventsToBroadcast;
            public List<Guid> EventsToProcess;
        }
        */
        Console.WriteLine("Saving universe to file... (" + universe.Objects.Count.ToString() + " objects)");
        System.IO.Directory.CreateDirectory(directory);

        string objects = "universe.objects: " + Environment.NewLine;
        foreach (KeyValuePair<Guid, UplinkObject> obj in universe.Objects)
        {
            objects += obj.Value.Serialize(1);
        }
        File.WriteAllText(directory + "Objects.yaml", objects);

        /*
        File.WriteAllText(directory + "Index.json",
            JsonSerializer.Serialize(universe.Index));

        File.WriteAllText(directory + "Events.json",
            JsonSerializer.Serialize(broadcaster.Events));

        File.WriteAllText(directory + "EventsToBroadcast.json",
            JsonSerializer.Serialize(broadcaster.EventsToBroadcast));

        File.WriteAllText(directory + "EventsToProcess.json",
        JsonSerializer.Serialize(broadcaster.EventsToProcess));

        File.WriteAllText(directory + "Id.json",
            JsonSerializer.Serialize(broadcaster.Id));*/
    }
}
