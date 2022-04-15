using System.Xml.Serialization;

namespace Uplink.Program
{
    public static class Program
    {
        static void Main()
        {
            Console.WriteLine("Atlas' Uplink universe server");

            State state = new();
            Entity.Client client = new();

            Time t = new()
            {
                Entity = client.Id,
                Name = "clock",
                Timer = true,
                Clock = true,
                SecondsToUpdate = 10
            };

            Time tt = new()
            {
                Entity = client.Id,
                Name = "status message",
                Timer = true,
                SecondsToUpdate = 10
            };

            Status status = new()
            {
                Entity = client.Id
            };

            bool running = true;
            while (running)
            {
                foreach (Capability.Capability component in state.GetComponents())
                {
                    //Console.WriteLine(component.GetType().FullName);
                    component.Update();
                }
            }
        }

        public static string SerializeObject<T>(this T toSerialize)
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