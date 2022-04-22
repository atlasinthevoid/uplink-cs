using System.Numerics;

namespace Uplink.Entity
{
    public class Universe : Entity
    {
        public Universe()
        {
            Capability.Position pos = new();
            pos.Metadata.Add(new Type.Name() { Value = "universe position" });
            pos.Number = new Vector3(0, 0, 0);
            Add(pos);

            Capability.Int rev = new();
            rev.Metadata.Add(new Type.Name() { Value = "revision" });
            rev.Number = 0;
            Add(rev);

            Capability.Text server = new();
            server.Metadata.Add(new Type.Name() { Value = "server" });
            server.Value = "192.168.0.1:4545";
            Add(server);

            Capability.Bool started = new();
            started.Metadata.Add(new Type.Name() { Value = "started" });
            started.Flag = false;
            Add(server);

            Capability.Bool ready = new();
            started.Metadata.Add(new Type.Name() { Value = "ready" });
            started.Flag = true;
            Add(server);
        }
    }
}
