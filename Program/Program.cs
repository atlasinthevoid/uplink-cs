namespace Uplink.Program
{
    public static class Program
    {
        static void Main()
        {
            Command.Init i = new();
            i.Execute();
            // Display info to user
            // Load universe from file
            // Hash entities to position chunk table
            // Host Network Node for position chunks
            // Fetch chunks from uplink.void.contact
            // Display UI Toolkit
            // Load skybox


            Command.StartGameLoop s = new();
            s.Execute();
        }

        public static string SerializeObject<T>(this T toSerialize)
        {
            if (toSerialize != null)
            {
                System.Xml.Serialization.XmlSerializer xmlSerializer = new(toSerialize.GetType());

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