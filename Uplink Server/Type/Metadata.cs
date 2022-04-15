using System.Collections;

namespace Uplink.Type
{
    public class Metadata : Type, IEnumerable<System.Type>
    {
        private readonly Dictionary<System.Type, dynamic> data;

        public Metadata()
        {
            data = new();
        }

        public void Add(Type d)
        {
            data.Add(data.GetType(), data);
        }

        public bool ContainsKey(System.Type key)
        {
            return data.ContainsKey(key);
        }

        public IEnumerator<System.Type> GetEnumerator()
        {
            return GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return data.GetEnumerator();
        }
    }
}
