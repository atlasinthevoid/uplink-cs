using System.Xml.Serialization;

namespace Uplink.Capability
{
    [XmlRoot(Namespace = "Uplink")]
    [XmlInclude(typeof(Audio))]
    [XmlInclude(typeof(Bool))]
    [XmlInclude(typeof(Broadcast))]
    [XmlInclude(typeof(File))]
    [XmlInclude(typeof(Float))]
    [XmlInclude(typeof(Guid))]
    [XmlInclude(typeof(Image))]
    [XmlInclude(typeof(Int))]
    [XmlInclude(typeof(Loading))]
    [XmlInclude(typeof(Mesh))]
    [XmlInclude(typeof(Position))]
    [XmlInclude(typeof(Rotation))]
    [XmlInclude(typeof(Save))]
    [XmlInclude(typeof(Socket))]
    [XmlInclude(typeof(Status))]
    [XmlInclude(typeof(Terminal))]
    [XmlInclude(typeof(Text))]
    [XmlInclude(typeof(Time))]
    [XmlInclude(typeof(State))]

    public class Capability
    {
        public Type.Metadata Metadata;

        public Capability()
        {
            Metadata = new()
            {
                new Type.Parent(),
                new Type.Id(),
                new Type.Name(),
                new Type.CreationTime(),
                new Type.Author(),
                new Type.Active()
            };
        }

        public virtual void Update()
        {

        }
    }
}