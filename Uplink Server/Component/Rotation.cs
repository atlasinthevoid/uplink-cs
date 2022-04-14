using System.Numerics;

namespace Uplink.Component
{
    public class Rotation : Component
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