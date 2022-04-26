namespace Uplink.Capability.Menu
{
    public class WindowButton : Capability
    {
        public string WindowTitle;
        public string ButtonTitle;
        public bool Setup;

        public WindowButton()
        {
            StringType = "WindowButton";
            WindowTitle = "";
            ButtonTitle = "";
            Setup = false;
            Program.Systems.Register(this);
        }

        public override void Update()
        {
            if (Metadata.ContainsKey("Parent") && !Setup)
            {
                Type.Entity window = Metadata.Get("Parent").Value;
                Core.Pose windowPose = new();
                windowPose.Value = new(0, 1, -0.5f, StereoKit.Quat.FromAngles(0, 180, 0));
                window.Add(windowPose);

                Menu.Window w = new();
                w.Title = WindowTitle;
                window.Add(w);

                Input.Button b = new();
                b.Title = ButtonTitle;
                window.Add(b);
                Setup = true;
            }
        }
    }
}