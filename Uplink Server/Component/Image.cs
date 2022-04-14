using System.Collections.Immutable;

namespace Uplink.Component
{
    public class Image : Component
    {
        public ImmutableArray<byte> Bytes
        {
            get;
            init;
        }

        public Image()
        {
            Bytes = new();
        }

        public override void Update()
        {
            
        }
    }
}