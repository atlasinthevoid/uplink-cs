namespace Uplink
{
    public class BroadcastComponent : Component
    {
        public Guid EventId
        {
            get;
            init;
        }

        public bool Broadcasted
        {
            get;
            init;
        }

        public BroadcastComponent()
        {
            EventId = Guid.Empty;
        }

        public override void Update()
        {
            if (!Broadcasted)
            {
                BroadcastEvent();
                //Broadcasted = true;
            }
        }

        public void BroadcastEvent()
        {

        }
    }
}