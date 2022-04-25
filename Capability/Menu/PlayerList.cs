namespace Uplink.Capability.Menu
{
    public class PlayerList : Capability
    {
        public PlayerList()
        {
            StringType = "PlayerList";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}