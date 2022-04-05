using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text.Json;

Console.WriteLine("Atlas' Uplink universe server");
UniverseServer program = new();
await program.Start();

[Serializable]
class UplinkTag
{
    public string Name;
    public bool IsSpecial;

    public UplinkTag(string name, bool isSpecial = false)
    {
        Name = name;
        IsSpecial = isSpecial;
    }
    
    public override string ToString()
    {
        if (IsSpecial)
        {
            return "(special) " + Name;
        } else
        {
            return Name;
        }
    }
}

[Serializable]
class UplinkObject
{
    public Guid Id;
    public List<UplinkTag> Tags;
    public dynamic? Value;

    public UplinkObject(List<UplinkTag> tags, dynamic value)
    {
        Id = Guid.NewGuid();
        Tags = tags;
        Value = value;
    }
}

class Universe
{
    public Dictionary<Guid, UplinkObject> Objects;
    public Dictionary<UplinkTag, List<Guid>> Index;

    public Universe()
    {
        Objects = new();
        Index = new();
    }
}

[Serializable]
class UplinkEvent
{
    public Guid Id;
    public DateTime Time;
    public Guid Author;
    public string Type;
    public UplinkObject Object;
    public TaskCompletionSource<dynamic> Task;

    public UplinkEvent(Guid author, string type, UplinkObject newObject)
    {
        Id = Guid.NewGuid();
        Time = DateTime.UtcNow;
        Author = author;
        Type = type;
        Object = newObject;
        Task = new();
    }
}

class Broadcaster
{
    public Guid Id;

    // Local event data
    public Dictionary<Guid, UplinkEvent> Events;

    // We will broadcast events that we have processed so that other nodes can find them
    public List<Guid> EventsToBroadcast;

    // Events recieved by localhost or external nodes that havent been added to the database yet
    public List<Guid> EventsToProcess;

    public Broadcaster()
    {
        Events = new();
        EventsToBroadcast = new();
        EventsToProcess = new();
        Id = Guid.NewGuid();
    }
}

class UniverseServer
{
    // cancelled: Used for determining if a cancel has been requested
    bool cancelled = false;
    readonly string directory = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\Uplink\";

    readonly Universe universe = new();
    readonly Broadcaster broadcaster = new();

    public async Task<dynamic> Start()
    {
        Console.CancelKeyPress += new ConsoleCancelEventHandler(MyHandler);

        if (LoadUniverseFromFile() == "file not found")
        {
            CheckVars();
        }

        CreateSocket();
        while (!cancelled)
        {
            EventLoop();
        }

        // Exit code handling
        TaskCompletionSource<string> exitCode = new();

        exitCode.SetResult("exit");
        await exitCode.Task;
        return exitCode.Task.Result;
    }

    async void MyHandler(object? sender, ConsoleCancelEventArgs args)
    {
        Console.WriteLine("CANCEL command received! Cleaning up. please wait...");
        SaveUniverseToFile(await CreateEvent("request", new() { new(broadcaster.Id.ToString()), new("uplink data") }, null));
        args.Cancel = true;
        cancelled = true;
    }

    async void CheckVars()
    {
        await CreateEvent("update", new() { new("private", true), new("local client id") }, broadcaster.Id);
        Vector3 position = new(0, 0, 0);
        await CreateEvent("update", new() { new("private", true), new("position") }, position);

        await CreateEvent("update", new() { new(position.ToString()), new("revision") }, 0);
        await CreateEvent("update", new() { new(position.ToString()), new("server") }, "192.168.0.1:4545");

        await CreateEvent("update", new() { new(broadcaster.Id.ToString()), new("started") }, false);

        await CreateEvent("update", new() { new("universe"), new("ready") }, true);

        await CreateEvent("update", new() { new(broadcaster.Id.ToString()), new("uplink data") },
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)
                    + @"\Uplink\");

        await CreateEvent("update", new() { new(broadcaster.Id.ToString()), new("uplink ingest") },
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
                    + @"\Uplink Ingest\");

        await CreateEvent("update", new() { new(broadcaster.Id.ToString()), new("uplink export") },
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
                    + @"\Uplink Export\");
    }

    void EventLoop()
    {
        // Process events loop (1 event per frame to limit lag)
        // This function must run first in Update() otherwise game will stall
        if (broadcaster.EventsToProcess.Count >= 1)
        {
            List<Guid> events = broadcaster.EventsToProcess.ToList();
            int numberOfEvents = 0;
            foreach (Guid id in events)
            {
                ProcessEvent(id);
                numberOfEvents++;
            }
            if (numberOfEvents > 0)
            {
                broadcaster.EventsToProcess.RemoveRange(0, numberOfEvents);
            }
        }
        //Console.WriteLine(JsonSerializer.Serialize(ObjectsDatabase));
    }

    static void CreateSocket()
    {

    }

    static void OnAcceptConnection()
    {

    }


    dynamic FindID(List<UplinkTag> listTags)
    {
        // Prevent modifications to the list passed in
        List<UplinkTag> searchTags = listTags.ToList();

        if (!universe.Index.ContainsKey(searchTags.First()))
        {
            return "object not found";
        }
        List<Guid> ids = new();

        foreach (Guid objectId in universe.Index[searchTags.First()])
        {
            ids.Add(objectId);
        }
        searchTags.RemoveAt(0);

        foreach (UplinkTag tag in searchTags)
        {
            if (!universe.Index.ContainsKey(tag))
            {
                return "object not found";
            }
            foreach (Guid id in ids.ToList())
            {
                if (!universe.Index[tag].Contains(id))
                {
                    ids.Remove(id);
                }
            }
        }
        if (universe.Objects.Count > 0 && ids.Count > 0 && universe.Objects.ContainsKey(ids.First()))
        {
            Console.WriteLine("Objects found");
            return ids.First();
        }
        else
        {
            Console.WriteLine("Object not found");
            return "object not found";
        }

    }

    async Task<dynamic> CreateEvent(string type, List<UplinkTag> tags, dynamic? value)
    {
        if (!(type == "update" || type == "request" || type == "provide" || type == "clearCache"))
        {
            return "invaild event type";
        }

        UplinkEvent eventObject = new(broadcaster.Id, type, new(tags, value));
        broadcaster.Events[eventObject.Id] = eventObject;

        string eventPrint = "[" + PrettyGuid(eventObject.Id) + "] " + type + " ";
        eventPrint += string.Join(",", eventObject.Object.Tags);
        if (eventObject.Object.Value != null)
        {
            eventPrint += " to " + eventObject.Object.Value.ToString();
        }
        Console.WriteLine(eventPrint);

        broadcaster.EventsToProcess.Add(eventObject.Id);
        await eventObject.Task.Task;
        if (type == "request")
        {
            return eventObject.Task.Task.Result;
        }
        else
        {
            return eventObject;
        }
    }

    // Create EventObject and add to the local queue
    async Task<dynamic> CreateEvent(string type, UplinkObject newObject)
    {

        if (!(type == "update" || type == "request" || type == "provide" || type == "clearCache"))
        {
            return "invaild event type";
        }

        UplinkEvent eventObject = new(broadcaster.Id, type, newObject);
        broadcaster.Events[eventObject.Id] = eventObject;

        string eventPrint = "[" + PrettyGuid(eventObject.Id) + "] " + type + " ";
        eventPrint += string.Join(",", eventObject.Object.Tags);
        if (eventObject.Object.Value != null)
        {
            eventPrint += " to " + eventObject.Object.Value.ToString();
        }
        Console.WriteLine(eventPrint);

        broadcaster.EventsToProcess.Add(eventObject.Id);
        await eventObject.Task.Task;
        if (type == "request")
        {
            return eventObject.Task.Task.Result;
        }
        else
        {
            return eventObject;
        }
    }

    void ProcessEvent(Guid eventId)
    {
        dynamic? value = false;
        UplinkEvent eventObject = broadcaster.Events[eventId];
        dynamic? tags = eventObject.Object.Tags;

        if (tags != null)
        {
            if (eventObject.Type == "update")
            {
                dynamic id = FindID(tags);
                if (id is Guid)
                {
                    universe.Objects[id] = eventObject.Object;
                }
                else
                {
                    id = Guid.NewGuid();

                    universe.Objects[id] = eventObject.Object;

                    foreach (dynamic tag in tags)
                    {
                        if (!universe.Index.ContainsKey(tag))
                        {
                            universe.Index[tag] = new List<Guid>();
                        }
                        universe.Index[tag].Add(id);
                    }
                }

                value = eventObject.Object;
            }
            else if (eventObject.Type == "request")
            {
                dynamic id = FindID(tags);
                if (id is Guid)
                {
                    value = universe.Objects[FindID(tags)];
                }

            }
            else if (eventObject.Type == "provide")
            {

            }
            else if (eventObject.Type == "clearCache")
            {

            }
        }

        string eventPrint = string.Join(",", eventObject.Object.Tags);
        if (eventObject.Object.Value != null)
        {
            eventPrint += " is " + eventObject.Object.Value.ToString();
        }
        Console.WriteLine(eventPrint);
        Console.WriteLine(eventPrint);
        eventObject.Task.SetResult(value);
    }
    /*
    string UniverseToString()
    {
        string state = "<color=#ffffff>Cached objects: " + System.Environment.NewLine;
        foreach (KeyValuePair<Guid, dynamic> id in ObjectsDatabase)
        {
            string stringTags = "";

            if (TagsDatabase.ContainsKey(id.Key))
            {
                stringTags = "";
                bool first = true;

                foreach (dynamic tag in TagsDatabase[id.Key])
                {
                    if (first == true)
                    {
                        stringTags += tag.ToString();
                    }
                    else
                    {
                        stringTags += ", " + tag.ToString();
                    }
                    first = false;
                }
            }
            else
            {
                stringTags = "no tags found";
            }


            state += "<color=#4c86a888>" + stringTags;
            state += ": <color=#edf060FF>" + id.Value.ToString() + "</color>" + System.Environment.NewLine;
        }
        state += System.Environment.NewLine;
        state += "<color=#ffffff>Tags index: " + System.Environment.NewLine;
        foreach (KeyValuePair<Guid, List<Guid>> tag in TagsIndex)
        {
            state += "<color=#4c86a888>" + tag.Key.ToString();
            state += ": <color=#edf060FF>" + tag.Value.Count.ToString() + " objects</color>" + System.Environment.NewLine;
        }
        state += System.Environment.NewLine;
        state += "<color=#ffffff>Events to process: " + EventsToProcess.Count + System.Environment.NewLine;

        return state;
    }*/

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

        File.WriteAllText(directory + "Objects.json",
            JsonSerializer.Serialize(universe.Objects));

        File.WriteAllText(directory + "Index.json",
            JsonSerializer.Serialize(universe.Index));

        File.WriteAllText(directory + "Events.json",
            JsonSerializer.Serialize(broadcaster.Events));

        File.WriteAllText(directory + "EventsToBroadcast.json",
            JsonSerializer.Serialize(broadcaster.EventsToBroadcast));

        File.WriteAllText(directory + "EventsToProcess.json",
        JsonSerializer.Serialize(broadcaster.EventsToProcess));

        File.WriteAllText(directory + "Id.json",
            JsonSerializer.Serialize(broadcaster.Id));
    }

    string LoadUniverseFromFile()
    {
        Console.WriteLine("Loading universe from file...");
        if (!File.Exists(directory + "ObjectsDatabase.json") || !File.Exists(directory + "TagsDatabase.json") || !File.Exists(directory + "EventDatabase.json") || !File.Exists(directory + "TagsIndex.json") || !File.Exists(directory + "EventsToBroadcast.json") || !File.Exists(directory + "EventsToProcess.json") || !File.Exists(directory + "EventTasks.json") || !File.Exists(directory + "LocalClientId.json") || !File.Exists(directory + "Position.json"))
        {
            Console.WriteLine("Universe save file not found");
            return "file not found";
        }

        var objects = JsonSerializer.Deserialize<Dictionary <Guid, UplinkObject>> (File.ReadAllText(directory + "Objects.json"));

        if (objects != null)
        {
            universe.Objects = objects;
        }

        var index = JsonSerializer.Deserialize<Dictionary<UplinkTag, List<Guid>>>(File.ReadAllText(directory + "Index.json"));

        if (index != null)
        {
            universe.Index = index;
        }

        var events = JsonSerializer.Deserialize<Dictionary<Guid, UplinkEvent>>(File.ReadAllText(directory + "Events.json"));

        if (events != null)
        {
            broadcaster.Events = events;
        }

        var newEventsToBroadcast = JsonSerializer.Deserialize<List<Guid>>(File.ReadAllText(directory + "EventsToBroadcast.json"));

        if (newEventsToBroadcast != null)
        {
            broadcaster.EventsToBroadcast = newEventsToBroadcast;
        }

        var newEventsToProcess = JsonSerializer.Deserialize<List<Guid>>(File.ReadAllText(directory + "EventsToProcess.json"));

        if (newEventsToProcess != null)
        {
            broadcaster.EventsToProcess = newEventsToProcess;
        }

        // Guid LocalClientId
        var id = JsonSerializer.Deserialize<Guid>(File.ReadAllText(directory + "Id.json"));

        if (id != Guid.Empty)
        {
            broadcaster.Id = id;
        }

        return "universe loaded";
    }

    static string PrettyGuid(Guid id)
    {
        return id.ToString().Split("-")[0];
    }
}