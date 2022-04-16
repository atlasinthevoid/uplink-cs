using System.Collections;

namespace Uplink.Type
{
    public class Metadata : Type
    {
        private readonly List<dynamic> list;
        private readonly Dictionary<string, dynamic> data;

        public Metadata()
        {
            StringType = "Metadata";
            data = new();
            list = new();
        }

        public void Add(Type d)
        {
            data.Add(d.StringType, d);
        }

        public bool ContainsKey(string key)
        {
            return data.ContainsKey(key);
        }

        public dynamic Get(string type)
        {
            return data[type];
        }
    }
}
