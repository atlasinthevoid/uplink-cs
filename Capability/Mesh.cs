namespace Uplink.Capability
{
    public class Mesh : Capability
    {
        public StereoKit.Model? Model;

        public Mesh()
        {
            StringType = "Mesh";
            Program.MeshSystem.Register(this);
        }

        public override void Update()
        {
            if (Metadata.ContainsKey("Parent") && Model != null)
            {
                if (Metadata.Get("Parent").Value.Capabilities.ContainsType("Pose"))
                {
                    StereoKit.Pose p = Metadata.Get("Parent").Value.Capabilities.ByType("Pose")[0].Value;
                    Model.Draw(p.ToMatrix());
                    StereoKit.UI.Handle("Cube", ref p, Model.Bounds);
                } 
                else if (Metadata.Get("Parent").Value.Capabilities.ContainsType("Matrix"))
                {
                    StereoKit.Matrix m = Metadata.Get("Parent").Value.Capabilities.ByType("Matrix")[0].Value;
                    Model.Draw(m);
                }
            }
        }
    }
}