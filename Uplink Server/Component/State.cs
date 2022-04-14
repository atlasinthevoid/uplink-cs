using System.Xml.Serialization;

namespace Uplink.Component
{
    public class State
    {
        [XmlIgnore]
        private readonly List<Entity> entities;

        [XmlIgnore]
        private readonly Dictionary<System.Guid, Entity> entityById;

        [XmlIgnore]
        private readonly Dictionary<System.Guid, Component> byId;

        [XmlIgnore]
        private readonly Dictionary<Type, List<System.Guid>> byType;

        [XmlIgnore]
        private readonly Dictionary<string, List<System.Guid>> byName;

        public State()
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
                    byType[component.GetType()] = new List<System.Guid>();
                }
                byType[component.GetType()].Add(component.Id);

                if (!byName.ContainsKey(component.Name))
                {
                    byName[component.Name] = new List<System.Guid>();
                }
                byName[component.Name].Add(component.Id);
            }
        }

        public Entity EntityById(System.Guid id)
        {
            return entityById[id];
        }

        public Component ById(System.Guid id)
        {
            return byId[id];
        }

        public List<T> ByName<T>(string? name = null)
        {
            List<T> components = new();
            if (name == null)
            {
                foreach (System.Guid id in byType[typeof(T)])
                {
                    components.Add((T)(object)ById(id));
                }
            }
            else
            {
                foreach (System.Guid id in byName[name])
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

        public string SerializeObject<T>(this T toSerialize)
        {
            if (toSerialize != null)
            {
                XmlSerializer xmlSerializer = new XmlSerializer(toSerialize.GetType());

                using (StringWriter textWriter = new StringWriter())
                {
                    xmlSerializer.Serialize(textWriter, toSerialize);
                    return textWriter.ToString();
                }
            }
            return "";
        }
    }
}