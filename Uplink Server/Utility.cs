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

        public static Entity CreateClient()
        {
            Entity client = new();
            client.Add(new StateComponent());
            client.Add(new AudioComponent());
            client.Add(new BoolComponent());
            client.Add(new BroadcastComponent());
            client.Add(new FileComponent());
            client.Add(new FloatComponent());
            client.Add(new IdComponent());
            client.Add(new ImageComponent());
            client.Add(new IntComponent());
            client.Add(new LoadingComponent());
            client.Add(new MeshComponent());
            client.Add(new PositionComponent());
            client.Add(new RotationComponent());
            client.Add(new SaveComponent());
            client.Add(new SocketComponent());
            client.Add(new StatusComponent());
            client.Add(new TerminalComponent());
            client.Add(new TextComponent());
            client.Add(new TimeComponent());
            client.Add(new IdComponent() { Name = "client"});
            client.Add(new StateComponent());
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
