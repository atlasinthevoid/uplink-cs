namespace Uplink.Capability
{
    public class Position : Capability
    {
        public System.Numerics.Vector3 Number;

        public Position()
        {
            StringType = "Position";
            Number = System.Numerics.Vector3.Zero;
            Program.PositionSystem.Register(this);
        }

        public override void Update()
        {
            
        }
    }
}