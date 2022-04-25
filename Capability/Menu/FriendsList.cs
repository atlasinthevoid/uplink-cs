namespace Uplink.Capability.Menu
{
    public class FriendsList : Capability
    {

        public FriendsList()
        {
            StringType = "FriendsList";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}