using System.Numerics;

namespace Uplink
{
    public class PositionComponent : Component
    {
        public Vector3 Number
        {
            get;
            init;
        }

        public PositionComponent()
        {
            Number = Vector3.Zero;
        }

        public override void Update()
        {
            
        }
    }
}