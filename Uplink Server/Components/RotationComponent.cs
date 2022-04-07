using System.Numerics;

namespace Uplink
{
    public class RotationComponent : Component
    {
        public Vector3? Number;

        public RotationComponent()
        {
            Number = Vector3.Zero;
        }

        public RotationComponent(Guid author, string name, Vector3 number) : base(author, name)
        {
            Number = number;
        }
    }
}