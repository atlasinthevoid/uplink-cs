namespace Uplink.Capability.Core
{
    public class Client : Capability
    {
        bool Setup;
        public StereoKit.Vec3 Rotation;
        public StereoKit.Vec3 Position;

        public Client()
        {
            StringType = "Client";
            Setup = false;
            Rotation = new();
            Position = new();
            Program.Systems.Register(this);
        }

        public override void Update()
        {
            if(Metadata.ContainsKey("Parent") && !Setup)
            {
                Type.Entity p = Metadata.Get("Parent").Value;
                p.Add(new Menu.Loading());
                p.Add(new Socket());
                p.Add(new Menu.Status());
                p.Add(new Menu.Terminal());
                p.Add(new Core.FileSystem());
            
                Time t = new()
                {
                    Timer = true,
                    Clock = true,
                    SecondsToUpdate = 10
                };
                t.Metadata.Add(new Type.Name() { Value = "Clock" });
                p.Add(t);

                Time tt = new()
                {
                    Timer = true,
                    SecondsToUpdate = 10
                };
                tt.Metadata.Add(new Type.Name() { Value = "Status message" });
                p.Add(tt);

                // Spawn Controllers
                Type.Entity right = new();
                World.Controller rc = new();
                rc.Hand = StereoKit.Handed.Right;
                right.Add(rc);
                Core.JoystickMovement rm = new();
                rm.MovementType = "Rotation";
                right.Add(rm);

                Type.Entity left = new();
                World.Controller lc = new();
                lc.Hand = StereoKit.Handed.Left;
                left.Add(lc);
                Core.JoystickMovement lm = new();
                lm.MovementType = "Position";
                left.Add(lm);

                // Display info to user
                Command.Log l = new();
                l.Level = "Info";
                l.Message = "Initialization complete.";
                l.Execute();

                Command.Log ll = new();
                ll.Level = "Info";
                string num = Program.Systems.GetNumberOfCapabilities().ToString();
                ll.Message = "Universe contains " + num + " capabilities.";
                ll.Execute();

                // Load universe from file
                Command.LoadUniverseFromFile load = new();
                load.Execute();

                // Hash entities to position chunk table
                // Host Network Node for position chunks
                p.Add(new ChunksMap());

                // Display UI Toolkit
                

                Setup = true;
            }
            StereoKit.Renderer.CameraRoot = StereoKit.Renderer.CameraRoot = StereoKit.Matrix.TR(Position, Rotation);
        }
    }
}
