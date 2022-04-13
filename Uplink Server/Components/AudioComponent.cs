using System.Collections.Immutable;

namespace Uplink
{
    public class AudioComponent : Component
    {
        public ImmutableArray<byte> Bytes
        {
            get;
            init;
        }

        public AudioComponent()
        {
            Bytes = new();
        }

        public override void Update()
        {

        }
    }
}