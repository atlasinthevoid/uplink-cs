using System.Collections.Immutable;

namespace Uplink.Component
{
    public class Audio : Component
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