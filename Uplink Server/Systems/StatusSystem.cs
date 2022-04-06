using System.Numerics;

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
        PositionComponent position = new("universe position", new Vector3(0, 0, 0));

        Entity clientId = new();
        clientId.Add(new Component("local client id"));
        clientId.Add(new IdComponent("id", LocalState.Id));
        await LocalState.CreateEvent("update", clientId);

        Entity universe = new();
        universe.Add(new Component("position"));
        universe.Add(position);
        universe.Add(new IntComponent("revision", 0));
        universe.Add(new TextComponent("server", "192.168.0.1:4545"));
        universe.Add(new BoolComponent("started", false));
        universe.Add(new BoolComponent("ready", true));
        await LocalState.CreateEvent("update", universe);

        Entity filesystem = new();
        string appData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        string documents = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        filesystem.Add(new TextComponent("uplink data", appData + @"\Uplink\"));
        filesystem.Add(new TextComponent("uplink ingest", documents + @"\Uplink Ingest\"));
        filesystem.Add(new TextComponent("uplink export", documents + @"\Uplink Export\"));
        await LocalState.CreateEvent("update", filesystem);
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
}