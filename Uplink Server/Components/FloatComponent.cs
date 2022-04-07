namespace Uplink
{
    public class FloatComponent : Component
    {
        public float? Number;

        public FloatComponent()
        {
            Number = 0.0f;
        }

        public FloatComponent(Guid author, string name, int number) : base(author, name)
        {
            Number = number;
        }
    }
}