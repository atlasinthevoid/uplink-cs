namespace Uplink.Entity
{
    public class Client : Entity
    {
        public Client()
        {
            Add(new Capability.Audio());
            Add(new Capability.Bool());
            Add(new Capability.Broadcast());
            Add(new Capability.File());
            Add(new Capability.Float());
            Add(new Capability.Id());
            Add(new Capability.Image());
            Add(new Capability.Int());
            Add(new Capability.Loading());
            Add(new Capability.Mesh());
            Add(new Capability.Position());
            Add(new Capability.Save());
            Add(new Capability.Socket());
            Add(new Capability.Status());
            Add(new Capability.Terminal());
            Add(new Capability.Text());
            Add(new Capability.Time());
        }
    }
}
