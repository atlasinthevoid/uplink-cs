using System;
using System.Collections;
using System.Xml.Serialization;

namespace Uplink
{
    public class Entity
    {
        public Guid Id
        {
            get;
            init;
        }

        public List<Component> Components
        {
            get;
            init;
        }

        [XmlIgnore]
        private readonly Dictionary<Guid, Component> byId;

        [XmlIgnore]
        private readonly Dictionary<Type, List<Guid>> byType;

        [XmlIgnore]
        private readonly Dictionary<string, List<Guid>> byName;

        public Entity()
        {
            Id = Guid.NewGuid();
            Components = new();
            byId = new();
            byType = new();
            byName = new();
        }

        private void Add(Component component)
        {
            Components.Add(component);
            byId.Add(component.Id, component);
            byId[component.Id] = component;

            if (!byType.ContainsKey(component.GetType()))
            {
                byType[component.GetType()] = new List<Guid>();
            }
            byType[component.GetType()].Add(component.Id);

            if (!byName.ContainsKey(component.Name))
            {
                byName[component.Name] = new List<Guid>();
            }
            byName[component.Name].Add(component.Id);
        }

        public Component ById(Guid id)
        {
            return byId[id];
        }

        public List<T> ByName<T>(string? name = null)
        {
            List<T> components = new();
            if (name == null)
            {
                foreach (Guid id in byType[typeof(T)])
                {
                    components.Add((T)(object)ById(id));
                }
            }
            else
            {
                foreach (Guid id in byName[name])
                {
                    if (ById(id).GetType() == typeof(T))
                    {
                        components.Add((T)(object)ById(id));
                    }
                }
            }
            return components;
        }
    }
}