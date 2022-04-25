namespace Uplink.Capability.World
{
    public class RoomSetup : Capability
    {
        public RoomSetup()
        {
            StringType = "RoomSetup";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}