public class StatusSystem : SystemComponent
{
    public StatusSystem(string name, State state) : base(name, state)
    {

    }

    public void Update()
    {
        Console.WriteLine("update");
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

    static string PrettyGuid(Guid id)
    {
        return id.ToString().Split("-")[0];
    }
}