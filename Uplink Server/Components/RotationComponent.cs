using System.Numerics;

namespace Uplink
{
    public class RotationComponent : Component
    {
        public Vector3 Number
        {
            get;
            init;
        }

        public RotationComponent()
        {
            Number = Vector3.Zero;
        }

        public override void Update()
        {
            
        }
    }
}