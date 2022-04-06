public class State
{
    public Guid Id;
    public EntityList Entities;
    public EventList Events;

    public State()
    {
        Id = Guid.NewGuid();
        Entities = new();
        Events = new();
    }

    // Create EventObject and add to the local queue
    public async Task<dynamic> CreateEvent(string type, Entity newObject)
    {
        if (!(type == "update" || type == "request" || type == "provide" || type == "clearCache"))
        {
            return "invaild event type";
        }

        Event eventObject = new(Id, type, newObject);
        Events.Add(eventObject);

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
}
