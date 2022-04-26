namespace Uplink.Capability.World
{
    public class Floor : Capability
    {
        bool Setup;

        public Floor()
        {
            StringType = "Floor";
            Setup = false;
            Program.Systems.Register(this);
        }

        public override void Update()
        {
            if (Metadata.ContainsKey("Parent") && !Setup)
            {
                Type.Entity p = Metadata.Get("Parent").Value;
                
                Core.Matrix floorTransform = new();
                floorTransform.Value = StereoKit.Matrix.TS(0, -1.5f, 0, new StereoKit.Vec3(30, 0.1f, 30));
                p.Add(floorTransform);

                StereoKit.Material floorMaterial = new(StereoKit.Shader.FromFile(@"C:\Users\atlas\Documents\Uplink\bin\Debug\net6.0\Assets\floor.hlsl"));
                floorMaterial.Transparency = StereoKit.Transparency.Blend;

                World.Mesh floorMesh = new();
                floorMesh.Model = StereoKit.Model.FromMesh(
                    StereoKit.Mesh.GenerateCube(StereoKit.Vec3.One),
                    floorMaterial
                );
                p.Add(floorMesh);
                Setup = true;
            }
        }
    }
}