namespace Uplink.Capability.World
{
    public class Chunk : Capability
    {
        public Type.Entities Entities;
        public bool Registered;

        public Chunk()
        {
            StringType = "Chunk";
            Entities = new();
            Registered = false;
            Program.Systems.Register(this);
        }

        public override void Update()
        {
            if (!Registered && Metadata.ContainsKey("Parent") && Metadata.Get("Parent").Value.Capabilities.ContainsType("Pose"))
            {
                Core.Client c = (Core.Client)Program.Systems.Get("Client").Get()[0];
                if (c.Metadata.ContainsKey("Parent"))
                {
                    Type.Entity e = c.Metadata.Get("Parent").Value;
                    if (e.Capabilities.ContainsType("ChunksMap"))
                    {
                        Core.ChunksMap n = (Core.ChunksMap)e.Capabilities.ByType("ChunksMap")[0];
                        n.RegisterChunk(this);
                        Registered = true;
                    }
                }
            }
        }

        public void Register(Type.Entity e)
        {
            Entities.Add(e);
        }
    }
}