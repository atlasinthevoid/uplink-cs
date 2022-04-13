using System.Collections.Immutable;

namespace Uplink
{
    public class FileComponent : Component
    {
        public ImmutableArray<byte> Bytes
        {
            get;
            init;
        }

        public string FilePath
        {
            get;
            init;
        }

        public FileComponent()
        {
            Bytes = new();
            FilePath = "";
        }

        public override void Update()
        {
            
        }
    }
}