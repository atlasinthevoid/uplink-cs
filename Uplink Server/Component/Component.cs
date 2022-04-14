using System.Xml.Serialization;

namespace Uplink
{
    [XmlRoot(Namespace = "Uplink")]
    [XmlInclude(typeof(Audio))]
    [XmlInclude(typeof(Bool))]
    [XmlInclude(typeof(Broadcast))]
    [XmlInclude(typeof(File))]
    [XmlInclude(typeof(Float))]
    [XmlInclude(typeof(Id))]
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
        public event EventHandler<Entity>? AddEntityEvent;
        public event EventHandler<(Entity, Component)>? AddComponentEvent;
        public event EventHandler<Guid>? GetEntityByIdEvent;
        public event EventHandler<(Guid)>? GetComponentByIdEvent;
        public event EventHandler<(string)>? GetComponentByNameEvent;

        public Guid Entity
        {
            get;
            init;
        }

        public Guid Id
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

        public Guid Author
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
            //AddEntity += new AddEntityHandler(RaiseAddEntity);
            Id = Guid.NewGuid();
            Name = "";
            Time = DateTime.Now;
            Author = Guid.Empty;
            Active = true;
        }

        protected virtual void AddEntity(object sender, Entity entity)
        {
            // Raise the event in a thread-safe manner using the ?. operator.
            AddEntityEvent?.Invoke(this, entity);
        }

        protected virtual void AddComponent(object sender, Component component)
        {
            // Raise the event in a thread-safe manner using the ?. operator.
            AddComponentEvent?.Invoke(this, component);
        }

        public abstract void Update();
    }
}