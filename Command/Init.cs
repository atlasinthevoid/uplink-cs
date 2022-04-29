namespace Uplink.Command
{
    public class Init : Command
    {
        public Init()
        {
            StringType = "Init";
        }

        internal override void Exec()
        {
            Log l = new();
            l.Message = "Atlas' Uplink server";
            l.Execute();

            Type.Entity client = new();
            client.Add(new Capability.World.Network());
            client.Add(new Capability.Core.Client());

            InitEnvironment();
        }

        private void InitEnvironment()
        {
            // Initialize StereoKit
            StereoKit.SKSettings settings = new()
            {
                appName = "Uplink",
                assetsFolder = "Assets",
            };
            if (!StereoKit.SK.Initialize(settings))
            {
                Environment.Exit(1);
            }
            StereoKit.World.RaycastEnabled = true;
            
            Type.Entity cube = new();
            cube.Add(new Capability.World.Network());
            cube.Add(new Capability.World.Cube());

            if (StereoKit.SK.System.displayType == StereoKit.Display.Opaque)
            {
                Type.Entity floor = new();
                floor.Add(new Capability.World.Network());
                floor.Add(new Capability.World.Floor());
            }

            Type.Entity w = new();
            w.Add(new Capability.World.Network());
            Capability.Menu.WindowButton button = new();
            button.WindowTitle = "Test Button";
            button.ButtonTitle = "Press me! :)";
            w.Add(button);
            Capability.Core.Pose windowPose = new();
            windowPose.Value = new(0, 1, -0.5f, StereoKit.Quat.FromAngles(0, 180, 0));
            w.Add(windowPose);

            Type.Entity w2 = new();
            w2.Add(new Capability.World.Network());
            Capability.Menu.WindowButton button2 = new();
            button2.WindowTitle = "Test Button";
            button2.ButtonTitle = "Press me! :)";
            w2.Add(button2);
            Capability.Core.Pose windowPose2 = new();
            windowPose2.Value = new(0, 1, 16, StereoKit.Quat.FromAngles(0, 180, 0));
            w2.Add(windowPose2);
        }

        public override void Undo()
        {

        }
    }
}
