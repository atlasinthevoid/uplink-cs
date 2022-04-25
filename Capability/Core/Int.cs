namespace Uplink.Capability.Core
{
    public class Int : Capability
    {
        public int Number;

        public Int()
        {
            StringType = "Int";
            Number = 0;
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}