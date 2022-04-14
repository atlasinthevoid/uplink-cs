using System.Xml.Serialization;

namespace Uplink.Component
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

    // Immutable class
    public abstract class Component
    {
        // Can be added like this: AddEntity += new AddEntityHandler(RaiseAddEntity);
        public event EventHandler? CreateComponentEvent;
        public event EventHandler<(Type.Id, Entity.Entity)>? GetEntityByIdEvent;
        public event EventHandler<(Type.Id, Component)>? GetComponentByIdEvent;
        public event EventHandler<(string, Component)>? GetComponentByNameEvent;

        public Type.Id Entity
        {
            get;
            init;
        }

        public Type.Id Id
        {
            get;
            init;
        }

        public string Name
        {
            get;
            init;
        }

        public DateTime Time
        {
            get;
            init;
        }

        public Type.Id Author
        {
            get;
            init;
        }

        public bool Active
        {
            get;
            init;
        }

        public Component()
        {
            Entity = new();
            Id = new();
            Name = "";
            Time = DateTime.Now;
            Author = new(true);
            Active = true;
        }

        protected virtual void AddComponent(object sender)
        {
            // Raise the event in a thread-safe manner using the ?. operator.
            CreateComponentEvent?.Invoke(sender, new EventArgs());
        }

        public abstract void Update();
    }
}