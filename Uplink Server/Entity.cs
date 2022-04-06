using System;
using System.Collections;

public class Entity : IEnumerable<KeyValuePair<string, Component>>
{
    public Guid Id;
    public Dictionary<string, Component> Components;

    public Entity()
    {
        Id = Guid.NewGuid();
        Components = new();
    }

    public Entity(Entity entity)
    {
        Id = entity.Id;
        Components = entity.Components;
    }

    public void Add(Component comp)
    {
        Components[comp.Name] = comp;
        comp.EntityId = Id;
    }

    public IEnumerator<KeyValuePair<string, Component>> GetEnumerator()
    {
        return Components.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}