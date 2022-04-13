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
    [XmlInclude(typeof(TimeComponent))]
    [XmlInclude(typeof(StateComponent))]

    // Immutable class
    public abstract class Component
    {
        public event EventHandler<Entity>? AddEntityEvent;
        public event EventHandler<(Entity, Component)>? AddComponentEvent;
        public event EventHandler<Guid>? GetEntityByIdEvent;
        public event EventHandler<(Guid)>? GetComponentByIdEvent;
        public event EventHandler<(string)>? GetComponentByNameEvent;


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