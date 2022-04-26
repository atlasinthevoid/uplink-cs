namespace Uplink.Program
{
    public class Systems
    {
        private static Dictionary<string, Type.Capabilities<Capability.Capability>> list = new();
        private static int count;

        public Systems()
        {

        }

        public static void Register(Capability.Capability capability)
        {
            if (!list.ContainsKey(capability.StringType))
            {
                list[capability.StringType] = new();
            }
            list[capability.StringType].Add(capability);

            Command.Log l = new();
            l.Message = capability.StringType + " " + capability.Metadata.Get("Id").ShortGuid() + " registered";
            l.Level = "Trace";
            l.Execute();
            count++;
        }

        public static bool Contains(string type)
        {
            return list.ContainsKey(type);
        }

        public static Type.Capabilities<Capability.Capability> Get(string type)
        {
            return list[type];
        }

        public static int GetNumberOfCapabilities()
        {
            return count;
        }

        public static void Update()
        {
            foreach (Type.Capabilities<Capability.Capability> system in list.Values.ToList())
            {
                foreach (Capability.Capability capability in system.Get().ToList())
                {
                    capability.Update();
                }
            }
        }
        
        public static void EndUpdate()
        {
            foreach (Type.Capabilities<Capability.Capability> system in list.Values.ToList())
            {
                foreach (Capability.Capability capability in system.Get().ToList())
                {
                    capability.EndUpdate();
                }
            }
        }
    }
}