using System.Xml.Serialization;

namespace Uplink
{
    [XmlRoot(Namespace = "Uplink")]
    [XmlInclude(typeof(AudioComponent))]
    [XmlInclude(typeof(BoolComponent))]
    [XmlInclude(typeof(BroadcastComponent))]
    [XmlInclude(typeof(FileComponent))]
    [XmlInclude(typeof(FloatComponent))]
    [XmlInclude(typeof(IdComponent))]
    [XmlInclude(typeof(ImageComponent))]
    [XmlInclude(typeof(IntComponent))]
    [XmlInclude(typeof(LoadingComponent))]
    [XmlInclude(typeof(MeshComponent))]
    [XmlInclude(typeof(PositionComponent))]
    [XmlInclude(typeof(RotationComponent))]
    [XmlInclude(typeof(SaveComponent))]
    [XmlInclude(typeof(SocketComponent))]
    [XmlInclude(typeof(StatusComponent))]
    [XmlInclude(typeof(TerminalComponent))]
    [XmlInclude(typeof(TextComponent))]
    [XmlInclude(typeof(AudioSystem))]
    [XmlInclude(typeof(BoolSystem))]
    [XmlInclude(typeof(BroadcastSystem))]
    [XmlInclude(typeof(ComponentSystem))]
    [XmlInclude(typeof(FileSystem))]
    [XmlInclude(typeof(FloatSystem))]
    [XmlInclude(typeof(IdSystem))]
    [XmlInclude(typeof(ImageSystem))]
    [XmlInclude(typeof(IntSystem))]
    [XmlInclude(typeof(LoadingSystem))]
    [XmlInclude(typeof(MeshSystem))]
    [XmlInclude(typeof(PositionSystem))]
    [XmlInclude(typeof(RotationSystem))]
    [XmlInclude(typeof(SaveSystem))]
    [XmlInclude(typeof(SocketSystem))]
    [XmlInclude(typeof(StatusSystem))]
    [XmlInclude(typeof(TerminalSystem))]
    [XmlInclude(typeof(TextSystem))]
    public abstract class Component
    {
        public Guid Id;
        public Guid EntityId;
        public string Name;
        public DateTime Time;
        public Guid Author;
        public bool Active;

        public Component()
        {
            Id = Guid.NewGuid();
            Name = "";
            Time = DateTime.Now;
            Author = Guid.Empty;
            Active = true;
        }

        public Component(Guid author, string name)
        {
            Id = Guid.NewGuid();
            Name = name;
            Time = DateTime.Now;
            Author = author;
            Active = true;
        }
    }
}