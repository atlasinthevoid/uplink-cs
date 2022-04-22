using System.Numerics;

namespace Uplink.Capability
{
    public class Position : Capability
    {
        public Vector3 Number;

        public Position()
        {
            Number = Vector3.Zero;
            Program.PositionSystem.Register(this);
        }

        public override void Update()
        {
            
        }
    }
}