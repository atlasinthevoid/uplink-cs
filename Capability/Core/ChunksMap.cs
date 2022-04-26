namespace Uplink.Capability.Core
{
    public class ChunksMap : Capability
    {
        public Dictionary<Core.Pose, World.Chunk> Chunks;
        public string BootstrapServer = "universe.void.contact";

        public ChunksMap()
        {
            StringType = "ChunksMap";
            Chunks = new();
            Program.Systems.Register(this);
        }

        public override void Update()
        {
            // Hash entities to position chunk table

            // Host Network Node for position chunks
            // Fetch chunks from uplink.void.contact
        }

        public void RegisterChunk(World.Chunk chunk)
        {
            Type.Entity e = chunk.Metadata.Get("Parent").Value;
            Core.Pose p = (Core.Pose)e.Capabilities.ByType("Pose")[0];

            Chunks[p] = chunk;
        }

        public void Register(World.Network network)
        {
            Type.Entity entity = network.Metadata.Get("Parent").Value;
            Core.Pose pose = (Core.Pose)entity.Capabilities.ByType("Pose")[0];
            StereoKit.Vec3 position = pose.Value.position;

            StereoKit.Vec3 chunkPosition = new();
            if (position.x/8 > 0)
            {
                chunkPosition.x = (float)Math.Floor(position.x/8);
            }
            else
            {
                chunkPosition.x = (float)Math.Ceiling(position.x/8);
            }

            // Fix for negitive 0 (-0.0)
            if (chunkPosition.x == 0f)
            {
                chunkPosition.x = 0f;
            }

            if (position.y/8 > 0)
            {
                chunkPosition.x = (float)Math.Floor(position.y/8);
            }
            else
            {
                chunkPosition.x = (float)Math.Ceiling(position.y/8);
            }

            // Fix for negitive 0 (-0.0)
            if (chunkPosition.x == 0f)
            {
                chunkPosition.x = 0f;
            }

            if (position.z/8 > 0)
            {
                chunkPosition.z = (float)Math.Floor(position.z/8);
            }
            else
            {
                chunkPosition.z = (float)Math.Ceiling(position.z/8);
            }

            // Fix for negitive 0 (-0.0)
            if (chunkPosition.z == 0f)
            {
                chunkPosition.z = 0f;
            }

            Command.Log l = new();
            l.Message = position.ToString() + " is in " + chunkPosition.ToString();
            l.Execute();
        }
    }
}