using System.Collections;

namespace Uplink.Type
{
    public class Entities
    {
        private readonly List<Entity> data;
        private readonly Dictionary<Id, Entity> byId;
        private readonly Dictionary<Name, List<Entity>> byName;

        public Entities()
        {
            data = new();
            byId = new();
            byName = new();
        }

        public void Add(Entity entity)
        {
            data.Add(entity);
            byId[entity.Metadata.Get("Id")] = entity;

            if (entity.Metadata.ContainsKey("Name"))
            {
                Name n = entity.Metadata.Get("Name");
                if (!byName.ContainsKey(n))
                {
                    byName[n] = new();
                }
                byName[n].Add(entity);
            }
        }

        public Entity ById(Id id)
        {
            return byId[id];
        }

        public bool ContainsId(Id id)
        {
            return byId.ContainsKey(id);
        }

        public List<Entity> ByName(Name n)
        {
            return byName[n];
        }

        public bool ContainsName(Name n)
        {
            return byName.ContainsKey(n);
        }

        public List<Entity> Get()
        {
            return data.ToList();
        }
    }
}
