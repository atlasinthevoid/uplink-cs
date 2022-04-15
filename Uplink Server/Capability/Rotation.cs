using System.Numerics;

namespace Uplink.Capability
{
    public class Rotation : Capability
    {
        public Vector3 Number
        {
            get;
            init;
        }

        public Rotation()
        {
            Number = Vector3.Zero;
        }

        public override void Update()
        {
            
        }
    }
}