namespace Uplink.Capability
{
    public class Int : Capability
    {
        public int Number;

        public Int()
        {
            StringType = "Int";
            Number = 0;
            Program.IntSystem.Register(this);
        }

        public override void Update()
        {

        }
    }
}