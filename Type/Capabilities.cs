namespace Uplink.Type
{
    public class Capabilities<T> where T : Capability.Capability
    {
        private readonly List<T> data;
        private readonly Dictionary<Id, T> byId;
        private readonly Dictionary<string, List<T>> byType;
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

            if (!byType.ContainsKey(capability.StringType))
            {
                byType[capability.StringType] = new();
            }
            byType[capability.StringType].Add(capability);

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

        public bool ContainsId(Id id)
        {
            return byId.ContainsKey(id);
        }

        public List<T> ByType(string t)
        {
            return byType[t];
        }

        public bool ContainsType(string t)
        {
            return byType.ContainsKey(t);
        }

        public List<T> ByName(Name n)
        {
            return byName[n];
        }

        public bool ContainsName(Name n)
        {
            return byName.ContainsKey(n);
        }

        public List<T> Get()
        {
            return data.ToList();
        }
    }
}
