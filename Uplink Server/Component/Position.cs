using System.Numerics;

namespace Uplink.Component
{
    public class Position : Component
    {
        public Vector3 Number
        {
            get;
            init;
        }

        public Position()
        {
            Number = Vector3.Zero;
        }

        public override void Update()
        {
            
        }
    }
}