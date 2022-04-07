using System;
using System.Collections;

namespace Uplink
{
    public class Entity
    {
        public Guid Id;
        public List<Component> Components;

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
            Components.Add(comp);
            //Components[comp.Id] = comp;
            comp.EntityId = Id;
        }
    }
}