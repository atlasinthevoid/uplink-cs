namespace Uplink.Capability.Core
{
    public class Broadcast : Capability
    {
        public Type.Id EventId
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
            StringType = "Broadcast";
            EventId = new(true);
            Program.Systems.Register(this);
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