public class NetworkEventSystem : SystemComponent
{
    public NetworkEventSystem(string name, State state) : base(name, state)
    {
        CreateSocket();
    }

    public void Update()
    {
        Console.WriteLine("update");
        foreach (Event e in LocalState.Events.Values())
        {
            ProcessEvent(e.Id);
        }
    }

    static void CreateSocket()
    {

    }

    static void OnAcceptConnection()
    {

    }

    void ProcessEvent(Guid eventId)
    {
        dynamic? value = false;
        Event eventObject = LocalState.Events.Dictionary[eventId];
        dynamic components = eventObject.Object.Components;

        if (components != null)
        {
            if (eventObject.Type == "update")
            {
                List<Guid> ids = Utility.FindID(components, LocalState);
                if (ids.Count > 0)
                {
                    foreach (Guid id in ids)
                    {
                        Entity newEntity = new(eventObject.Object);
                        newEntity.Id = id;
                        LocalState.Entities.Dictionary[id] = newEntity;
                    }
                }
                else
                {
                    LocalState.Entities.Dictionary[eventObject.Id] = eventObject.Object;
                }

                value = eventObject.Object;
            }
            else if (eventObject.Type == "request")
            {
                List<Guid> ids = Utility.FindID(components, LocalState);
                foreach (Guid id in ids)
                {
                    Entity newEntity = new(eventObject.Object);
                    newEntity.Id = id;
                    LocalState.Entities.Dictionary[id] = newEntity;
                }

            }
            else if (eventObject.Type == "provide")
            {

            }
            else if (eventObject.Type == "clearCache")
            {

            }
        }
        eventObject.Task.SetResult(value);
    }
}