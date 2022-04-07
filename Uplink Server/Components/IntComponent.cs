namespace Uplink
{
    public class IntComponent : Component
    {
        public int? Number;

        public IntComponent()
        {
            Number = 0;
        }

        public IntComponent(Guid author, string name, int number) : base(author, name)
        {
            Number = number;
        }
    }
}