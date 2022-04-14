namespace Uplink.Component
{
    public class Broadcast : Component
    {
        public System.Guid EventId
        {
            get;
            init;
        }

        public bool Broadcasted
        {
            get;
            init;
        }

        public Broadcast()
        {
            EventId = System.Guid.Empty;
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