namespace Uplink.Program
{
    public class Systems
    {
        public static Dictionary<string, Type.Capabilities<Capability.Capability>> List = new();

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
            l.Message = capability.StringType + " " + capability.Metadata.Get("Id").ShortGuid() + " capability registered";
            l.Level = "Trace";
            l.Execute();
        }

        public static void Update()
        {
            foreach (Type.Capabilities<Capability.Capability> system in List.Values)
            {
                foreach (Capability.Capability capability in system.Get())
                {
                    capability.Update();
                }
            }
        }
    }
}