namespace Uplink
{
    public class BoolComponent : Component
    {
        public bool? Flag;

        public BoolComponent()
        {
            Flag = false;
        }

        public BoolComponent(Guid author, string name, bool flag) : base(author, name)
        {
            Flag = flag;
        }
    }
}