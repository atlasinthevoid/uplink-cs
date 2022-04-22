using System.Collections;

namespace Uplink.Type
{
    public class Capabilities<T> where T : Capability.Capability
    {
        private readonly List<T> data;
        private readonly Dictionary<Id, T> byId;
        private readonly Dictionary<System.Type, List<T>> byType;
        private readonly Dictionary<Name, List<T>> byName;

        public Capabilities()
        {
            data = new();
            byId = new();
            byType = new();
            byName = new();
        }

        public void Add(T capability)
        {
            if (capability == null)
            {
                return;
            }

            data.Add(capability);

            if (!byType.ContainsKey(capability.GetType()))
            {
                byType[capability.GetType()] = new();
            }
            byType[capability.GetType()].Add(capability);

            if (capability.Metadata.ContainsKey("Name"))
            {
                Name n = capability.Metadata.Get("Name");
                if (!byName.ContainsKey(n))
                {
                    byName[n] = new();
                }
                byName[n].Add(capability);
            }
        }

        public T ById(Id id)
        {
            return byId[id];
        }

        public List<T> ByType(System.Type t)
        {
            return byType[t];
        }

        public List<T> ByName(Name n)
        {
            return byName[n];
        }

        public List<T> Get()
        {
            return data.ToList();
        }
    }
}
