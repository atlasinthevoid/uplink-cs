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
                
                Capability.Core.Matrix floorTransform = new();
                floorTransform.Value = StereoKit.Matrix.TS(0, -1.5f, 0, new StereoKit.Vec3(30, 0.1f, 30));

                StereoKit.Material floorMaterial = new(StereoKit.Shader.FromFile(@"C:\Users\atlas\Documents\Uplink\bin\Debug\net6.0\Assets\floor.hlsl"));
                floorMaterial.Transparency = StereoKit.Transparency.Blend;

                Capability.World.Mesh floorMesh = new();
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
