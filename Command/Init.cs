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
            
            Type.Entity cube = new();
            cube.Add(new Capability.World.Cube());

            if (StereoKit.SK.System.displayType == StereoKit.Display.Opaque)
            {
                Type.Entity floor = new();
                floor.Add(new Capability.World.Floor());
            }

            Type.Entity w = new();
            Capability.Menu.WindowButton button = new();
            button.WindowTitle = "Test Button";
            button.ButtonTitle = "Press me! :)";
            w.Add(button);
        }

        public override void Undo()
        {

        }
    }
}
