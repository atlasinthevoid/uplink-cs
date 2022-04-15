using System.Collections.Immutable;

namespace Uplink.Capability
{
    public class Audio : Capability
    {
        public ImmutableArray<byte> Bytes
        {
            get;
            init;
        }

        public Audio()
        {
            Bytes = new();
        }

        public override void Update()
        {

        }
    }
}