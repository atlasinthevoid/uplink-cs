using System.Collections.Immutable;

namespace Uplink
{
    public class ImageComponent : Component
    {
        public ImmutableArray<byte> Bytes
        {
            get;
            init;
        }

        public ImageComponent()
        {
            Bytes = new();
        }

        public override void Update()
        {
            
        }
    }
}