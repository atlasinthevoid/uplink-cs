public class State
{
    public Guid Id;
    public GuidList<Entity> Entities;
    public GuidList<Event> Events;
    public Dictionary<Component, List<Guid>> Index;

    public State()
    {
        Id = Guid.NewGuid();
        Entities = new();
        Events = new();
        Index = new();
    }
}
