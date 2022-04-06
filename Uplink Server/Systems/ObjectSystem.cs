public class ObjectSystem : SystemComponent
{
    public ObjectSystem(string name, State state) : base(name, state)
    {

    }

    public void Update()
    {
        Console.WriteLine("update");
    }

    dynamic FindID(List<Component> listTags)
    {
        // Prevent modifications to the list passed in
        List<Component> searchTags = listTags.ToList();

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

        foreach (Component tag in searchTags)
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
}
