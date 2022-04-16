using System.Collections;

namespace Uplink.Type
{
    public class Metadata : Type
    {
        private readonly List<dynamic> list;
        private readonly Dictionary<System.Type, dynamic> data;

        public Metadata()
        {
            data = new();
            list = new();
        }

        public void Add(Type d)
        {
            data.Add(data.GetType(), data);
        }

        public bool ContainsKey(System.Type key)
        {
            return data.ContainsKey(key);
        }

        public dynamic Get(System.Type type)
        {
            return data[type.GetType()];
        }
    }
}
