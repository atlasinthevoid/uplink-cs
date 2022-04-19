using System.Xml.Serialization;

namespace Uplink.Program
{
    public static class Program
    {
        static void Main()
        {
            Command.Init i = new();
            i.Execute();

            Command.StartGameLoop s = new();
            s.Execute();
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