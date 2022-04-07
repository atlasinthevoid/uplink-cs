using System.Numerics;

namespace Uplink
{
    public class PositionComponent : Component
    {
        public Vector3? Number;

        public PositionComponent()
        {
            Number = Vector3.Zero;
        }

        public PositionComponent(Guid author, string name, Vector3 number) : base(author, name)
        {
            Number = number;
        }
    }
}