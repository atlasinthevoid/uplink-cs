namespace Uplink.Capability.Input
{
    public class Button : Capability
    {
        public string Title;

        public Button()
        {
            StringType = "Button";
            Title = "";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }

        public override void WindowUpdate()
        {
            if (StereoKit.UI.Button(Title))
            {
                StereoKit.Log.Info("Button was pressed.");
            }
        }
    }
}