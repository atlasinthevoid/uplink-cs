namespace Uplink.Entity
{
    public class Client : Entity
    {
        public Client()
        {
            Add(new Capability.Loading());
            Add(new Capability.Socket());
            Add(new Capability.Status());
            Add(new Capability.Terminal());

            Capability.Time t = new()
            {
                Timer = true,
                Clock = true,
                SecondsToUpdate = 10
            };
            t.Metadata.Add(new Type.Name() { Value = "Clock" });
            Add(t);

            Capability.Time tt = new()
            {
                Timer = true,
                SecondsToUpdate = 10
            };
            tt.Metadata.Add(new Type.Name() { Value = "Status message" });
            Add(tt);
        }
    }
}
