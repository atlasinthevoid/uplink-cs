using System;

public static class Utility
{
    public static string PrettyGuid(Guid id)
    {
        return id.ToString().Split("-")[0];
    }

    public static List<Guid> FindID(Dictionary<string, Component> componentList, State localState)
    {
        List<Guid> ids = new();

        foreach (Entity e in localState.Entities.Dictionary.Values)
        {
            // Prevent modifications to the list passed in
            List<string> searchTags = componentList.Keys.ToList();
            foreach (Component c in e.Components.Values)
            {
                if (searchTags.Contains(c.Name) && c.GetType() == componentList[c.Name].GetType())
                {
                    searchTags.Remove(c.Name);
                }
            }
            if (searchTags.Count <= 0)
            {
                ids.Add(e.Id);
            }
        }
        return ids;
    }
}
