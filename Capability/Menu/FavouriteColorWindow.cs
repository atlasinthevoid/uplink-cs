namespace Uplink.Capability.Menu
{
    public class FavouriteColorWindow : Capability
    {

        public FavouriteColorWindow()
        {
            StringType = "FavouriteColorWindow";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}