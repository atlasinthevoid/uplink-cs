namespace Uplink.Entity
{
    public class Cube : Entity
    {
        public Cube()
        {
            Capability.Pose cubePose = new();
            cubePose.Value = new(0, 0, -0.5f, StereoKit.Quat.Identity);
            Add(cubePose);

            Capability.Mesh cubeMesh = new();
            cubeMesh.Model = StereoKit.Model.FromMesh(
                StereoKit.Mesh.GenerateRoundedCube(StereoKit.Vec3.One * 0.1f, 0.02f),
                StereoKit.Default.MaterialUI
            );
            Add(cubeMesh);
        }
    }
}