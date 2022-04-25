namespace Uplink.Capability.Core
{
    public class Position : Capability
    {
        public System.Numerics.Vector3 Number;

        public Position()
        {
            StringType = "Position";
            Number = System.Numerics.Vector3.Zero;
            Program.Systems.Register(this);
        }

        public override void Update()
        {
            
        }
    }
}