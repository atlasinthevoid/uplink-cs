namespace Uplink
{
    public class BroadcastComponent : Component
    {
        public Guid EventId;
        public bool Broadcasted;

        public BroadcastComponent()
        {
            EventId = Guid.Empty;
        }

        public BroadcastComponent(Guid author, string name, Guid eventId) : base(author, name)
        {
            EventId = eventId;
            Broadcasted = false;
        }
    }
}