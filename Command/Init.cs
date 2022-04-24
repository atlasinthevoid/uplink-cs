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

            Entity.Client client = new();

            Capability.Time t = new()
            {
                Timer = true,
                Clock = true,
                SecondsToUpdate = 10
            };
            t.Metadata.Add(new Type.Name() { Value = "Clock" });
            client.Add(t);

            Capability.Time tt = new()
            {
                Timer = true,
                SecondsToUpdate = 10
            };
            tt.Metadata.Add(new Type.Name() { Value = "Status message" });
            client.Add(tt);

            InitEnvironment();
        }

        static void InitEnvironment()
        {
            // Initialize StereoKit
            StereoKit.SKSettings settings = new()
            {
                appName = "Uplink",
                assetsFolder = "Assets",
            };
            if (!StereoKit.SK.Initialize(settings))
                Environment.Exit(1);


            Entity.Entity cube = new();

            Capability.Pose cubePose = new();
            cubePose.Value = new(0, 0, -0.5f, StereoKit.Quat.Identity);

            Capability.Mesh cubeMesh = new();
            cubeMesh.Model = StereoKit.Model.FromMesh(
                StereoKit.Mesh.GenerateRoundedCube(StereoKit.Vec3.One * 0.1f, 0.02f),
                StereoKit.Default.MaterialUI
            );
            
            cube.Add(cubePose);
            cube.Add(cubeMesh);

            if (StereoKit.SK.System.displayType == StereoKit.Display.Opaque)
            {
                Entity.Entity floor = new();
                
                Capability.Matrix floorTransform = new();
                floorTransform.Value = StereoKit.Matrix.TS(0, -1.5f, 0, new StereoKit.Vec3(30, 0.1f, 30));

                StereoKit.Material floorMaterial = new(StereoKit.Shader.FromFile(@"C:\Users\atlas\Documents\Uplink\bin\Debug\net6.0\Assets\floor.hlsl"));
                floorMaterial.Transparency = StereoKit.Transparency.Blend;

                Capability.Mesh floorMesh = new();
                floorMesh.Model = StereoKit.Model.FromMesh(
                    StereoKit.Mesh.GenerateCube(StereoKit.Vec3.One),
                    floorMaterial
                );
                
                floor.Add(floorTransform);
                floor.Add(floorMesh);
            }
        }

        public override void Undo()
        {

        }
    }
}
