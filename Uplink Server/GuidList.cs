using System;
using System.Collections;

public class GuidList<T> : IEnumerable<KeyValuePair<Guid, T>>
{
	public Dictionary<Guid, T> Dictionary;

	public GuidList()
    {
        Dictionary = new();
    }

    public void Add(dynamic entity)
    {
        Dictionary[entity.Id] = entity;
    }

    public IEnumerator<KeyValuePair<Guid, T>> GetEnumerator()
    {
        return Dictionary.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
