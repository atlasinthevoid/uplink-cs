using System;
using System.Collections;

public class EventList : IEnumerable<KeyValuePair<Guid, Event>>
{
    public Dictionary<Guid, Event> Dictionary;

    public EventList()
    {
        Dictionary = new();
    }

    public void Add(Event item)
    {
        Dictionary[item.Id] = item;
    }

    public Dictionary<Guid, Event>.ValueCollection Values()
    {
        return Dictionary.Values;
    }

    public IEnumerator<KeyValuePair<Guid, Event>> GetEnumerator()
    {
        return Dictionary.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
