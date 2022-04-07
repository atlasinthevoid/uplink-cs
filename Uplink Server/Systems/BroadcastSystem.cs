namespace Uplink
{
    public class BroadcastSystem : SystemComponent
    {
        public BroadcastSystem()
        {

        }

        public BroadcastSystem(string name, State state) : base(name, state)
        {

        }

        public void Update()
        {
            foreach (Entity e in LocalState.Entities)
            {
                foreach (dynamic c in e.Components)
                {
                    if (c is BroadcastComponent)
                    {
                        if (!c.Broadcasted)
                        {
                            BroadcastEvent(c.EntityId);
                            c.Broadcasted = true;
                        }
                    }
                }
            }
        }

        public void BroadcastEvent(Guid Id)
        {

        }
    }
}