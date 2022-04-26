namespace Uplink.Program
{
    public class Systems
    {
        public static Dictionary<string, Type.Capabilities<Capability.Capability>> List = new();
        private static int count;

        public Systems()
        {

        }

        public static void Register(Capability.Capability capability)
        {
            if (!List.ContainsKey(capability.StringType))
            {
                List[capability.StringType] = new();
            }
            List[capability.StringType].Add(capability);

            Command.Log l = new();
            l.Message = capability.StringType + " " + capability.Metadata.Get("Id").ShortGuid() + " registered";
            l.Level = "Trace";
            l.Execute();
            count++;
        }

        public static int GetNumberOfCapabilities()
        {
            return count;
        }

        public static void Update()
        {
            foreach (Type.Capabilities<Capability.Capability> system in List.Values.ToList())
            {
                foreach (Capability.Capability capability in system.Get().ToList())
                {
                    capability.Update();
                }
            }
        }
        
        public static void EndUpdate()
        {
            foreach (Type.Capabilities<Capability.Capability> system in List.Values.ToList())
            {
                foreach (Capability.Capability capability in system.Get().ToList())
                {
                    capability.EndUpdate();
                }
            }
        }
    }
}