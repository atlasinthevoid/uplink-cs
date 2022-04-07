using System;
using System.Xml.Serialization;

namespace Uplink
{
    public static class Utility
    {
        public static string PrettyGuid(Guid id)
        {
            return id.ToString().Split("-")[0];
        }

        public static Entity CreateClient(State state)
        {
            Entity client = new();
            client.Add(new AudioSystem("", state));
            client.Add(new BoolSystem("", state));
            client.Add(new BroadcastSystem("", state));
            client.Add(new ComponentSystem("", state));
            client.Add(new FileSystem("", state));
            client.Add(new FloatSystem("", state));
            client.Add(new IdSystem("", state));
            client.Add(new ImageSystem("", state));
            client.Add(new IntSystem("", state));
            client.Add(new LoadingSystem("", state));
            client.Add(new MeshSystem("", state));
            client.Add(new PositionSystem("", state));
            client.Add(new RotationSystem("", state));
            client.Add(new SaveSystem("", state));
            client.Add(new SocketSystem("", state));
            client.Add(new StatusSystem("", state));
            client.Add(new TerminalSystem("", state));
            client.Add(new TextSystem("", state));
            client.Add(new IdComponent(state.Id, "client", client.Id));
            return client;
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
