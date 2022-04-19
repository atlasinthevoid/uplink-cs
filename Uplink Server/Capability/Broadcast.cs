﻿namespace Uplink.Capability
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
            EventId = new(true);
            Program.BroadcastSystem.Register(this);
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