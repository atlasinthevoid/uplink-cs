using System.Collections.Immutable;

namespace Uplink
{
    public class File : Component
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

        public File()
        {
            Bytes = new();
            FilePath = "";
        }

        public override void Update()
        {
            
        }
    }
}