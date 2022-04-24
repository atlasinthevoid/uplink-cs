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
    [XmlInclude(typeof(Save))]
    [XmlInclude(typeof(Socket))]
    [XmlInclude(typeof(Status))]
    [XmlInclude(typeof(Terminal))]
    [XmlInclude(typeof(Text))]
    [XmlInclude(typeof(Time))]
    [XmlInclude(typeof(Pose))]
    [XmlInclude(typeof(Matrix))]
    [XmlInclude(typeof(Task))]
    [XmlInclude(typeof(Inventory))]
    [XmlInclude(typeof(Avatar))]
    [XmlInclude(typeof(Button))]
    [XmlInclude(typeof(Controller))]
    [XmlInclude(typeof(Hand))]
    [XmlInclude(typeof(Handle))]
    [XmlInclude(typeof(Profile))]
    [XmlInclude(typeof(Window))]

    public class Capability : Type.Type
    {
        public Type.Metadata Metadata;

        public Capability()
        {
            StringType = "Capability";
            Metadata = new();
            Metadata.Add(new Type.Id());
            Metadata.Add(new Type.CreationTime());
        }

        public virtual void Update()
        {

        }
    }
}