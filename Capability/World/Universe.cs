namespace Uplink.Capability.World
{
    public class Universe : Capability
    {
        bool Setup;

        public Universe()
        {
            StringType = "Universe";
            Program.Systems.Register(this);
            Setup = false;
        }

        public override void Update()
        {
            if (Metadata.ContainsKey("Parent") && !Setup)
            {
                Type.Entity p = Metadata.Get("Parent").Value;
                Core.Position pos = new();
                pos.Metadata.Add(new Type.Name() { Value = "universe position" });
                pos.Number = new System.Numerics.Vector3(0, 0, 0);
                p.Add(pos);

                Core.Int rev = new();
                rev.Metadata.Add(new Type.Name() { Value = "revision" });
                rev.Number = 0;
                p.Add(rev);

                Core.Text server = new();
                server.Metadata.Add(new Type.Name() { Value = "server" });
                server.Value = "192.168.0.1:4545";
                p.Add(server);

                Core.Bool started = new();
                started.Metadata.Add(new Type.Name() { Value = "started" });
                started.Flag = false;
                p.Add(server);

                Core.Bool ready = new();
                started.Metadata.Add(new Type.Name() { Value = "ready" });
                started.Flag = true;
                p.Add(server);

                Setup = true;
            }
        }
    }
}
