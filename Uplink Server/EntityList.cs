using System;
using System.Collections;

public class EntityList : IEnumerable<KeyValuePair<Guid, Entity>>
{
	public Dictionary<Guid, Entity> Dictionary;

	public EntityList()
    {
        Dictionary = new();
    }

    public void Add(Entity item)
    {
        Dictionary[item.Id] = item;
    }
    public Dictionary<Guid, Entity>.ValueCollection Values()
    {
        return Dictionary.Values;
    }

    public IEnumerator<KeyValuePair<Guid, Entity>> GetEnumerator()
    {
        return Dictionary.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
