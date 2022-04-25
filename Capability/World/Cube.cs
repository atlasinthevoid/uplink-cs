namespace Uplink.Capability.World
{
    public class Cube : Capability
    {
        public Cube()
        {

        }

        public override void Update()
        {
            if (Metadata.ContainsKey("Parent"))
            {
                Type.Entity p = Metadata.Get("Parent").Value;
                if (p.Capabilities.ContainsType("Pose"))
                {
                    Pose cubePose = new();
                    cubePose.Value = new(0, 0, -0.5f, StereoKit.Quat.Identity);
                    p.Add(cubePose);
                }

                if (p.Capabilities.ContainsType("Mesh"))
                {
                    Mesh cubeMesh = new();
                    cubeMesh.Model = StereoKit.Model.FromMesh(
                        StereoKit.Mesh.GenerateRoundedCube(StereoKit.Vec3.One * 0.1f, 0.02f),
                        StereoKit.Default.MaterialUI
                    );
                    p.Add(cubeMesh);
                }
            }
        }
    }
}