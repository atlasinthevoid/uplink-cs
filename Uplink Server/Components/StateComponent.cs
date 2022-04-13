using System.Xml.Serialization;

namespace Uplink
{
    public class StateComponent : Component
    {
        [XmlIgnore]
        private readonly List<Entity> entities;

        [XmlIgnore]
        private readonly Dictionary<Guid, Entity> entityById;

        [XmlIgnore]
        private readonly Dictionary<Guid, Component> byId;

        [XmlIgnore]
        private readonly Dictionary<Type, List<Guid>> byType;

        [XmlIgnore]
        private readonly Dictionary<string, List<Guid>> byName;

        public StateComponent()
        {
            Id = Guid.NewGuid();
            entities = new();
            entityById = new();
            byId = new();
            byType = new();
            byName = new();
        }

        public void Add(Entity entity)
        {
            entities.Add(entity);
            entityById.Add(entity.Id, entity);
            foreach (Component component in entity.Components)
            {
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
        }

        public Entity EntityById(Guid id)
        {
            return entityById[id];
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

        public int Count()
        {
            return entities.Count;
        }

        public List<Entity> GetEntities()
        {
            return entities.ToList<Entity>();
        }

        public override void Update()
        {
            
        }
    }
}