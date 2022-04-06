public class NetworkEventSystem : SystemComponent
{
    public NetworkEventSystem(string name, State state) : base(name, state)
    {
        CreateSocket();
    }

    public void Update()
    {
        Console.WriteLine("update");
        EventLoop();
    }

    bool EventLoop()
    {
        bool cancelled = false;
        // Process events loop (1 event per frame to limit lag)
        // This function must run first in Update() otherwise game will stall
        if (LocalState.EventsToProcess.Count >= 1)
        {
            List<Guid> events = LocalState.EventsToProcess.ToList();
            int numberOfEvents = 0;
            foreach (Guid id in events)
            {
                ProcessEvent(id);
                if (LocalState.Events[id].Object.Tags.Contains(new UplinkTag(broadcaster.Id.ToString())) && broadcaster.Events[id].Object.Tags.Contains(new Component("cancelled")))
                {
                    cancelled = true;
                }
                numberOfEvents++;
            }
            if (numberOfEvents > 0)
            {
                LocalState.EventsToProcess.RemoveRange(0, numberOfEvents);
            }
        }
        return cancelled;
    }

    static void CreateSocket()
    {

    }

    static void OnAcceptConnection()
    {

    }

    // Create EventObject and add to the local queue
    async Task<dynamic> CreateEvent(string type, dynamic newObject)
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
        else
        {
            eventPrint += " does not exist";
        }
        Console.WriteLine(eventPrint);
        eventObject.Task.SetResult(value);
    }
}