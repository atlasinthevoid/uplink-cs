namespace Uplink.Capability.Core
{
    public class JoystickMovement : Capability
    {
        public string MovementType;
        public float MovementSpeedMultiplier;
        public float RotationSpeedMultiplier;

        public JoystickMovement()
        {
            StringType = "JoystickMovement";
            MovementType = "Position";
            MovementSpeedMultiplier = 0.03f;
            RotationSpeedMultiplier = 1.7f;
            Program.Systems.Register(this);
        }

        public override void Update()
        {
            if (Metadata.ContainsKey("Parent"))
            {
                Type.Entity p = Metadata.Get("Parent").Value;
                if (p.Capabilities.ContainsType("Controller"))
                {
                    World.Controller c = (World.Controller)p.Capabilities.ByType("Controller")[0];
                    Core.Client client = (Core.Client)Program.Systems.Get("Client").Get()[0];
                    if (MovementType == "Position")
                    {
                        StereoKit.Vec3 lookAt = StereoKit.Input.Head.Forward;
                        lookAt.Normalize();
                        StereoKit.Vec3 forward = (lookAt * MovementSpeedMultiplier) * c.StickRotation.y;

                        StereoKit.Vec3 lookAtRight = -StereoKit.Input.Head.Right;
                        lookAtRight.Normalize();
                        forward += (lookAtRight * MovementSpeedMultiplier) * c.StickRotation.x;

                        forward.y = 0;
                        client.Position += forward;
                    }
                    else if (MovementType == "Rotation")
                    {
                        //float speed = c.StickRotation.y;

                        StereoKit.Vec3 rotateBy = new StereoKit.Vec3(0, c.StickRotation.x * RotationSpeedMultiplier, 0);
                        client.Rotation += rotateBy;
                        //rotation.Normalize();
                        //rotation.z = 0;
                        //Console.WriteLine(currentRotation.ToString());
                        //StereoKit.Renderer.CameraRoot = StereoKit.Matrix.R(rotation);
                        //Console.WriteLine(StereoKit.Renderer.CameraRoot.Pose.position.ToString());
                    }
                }
            }
        }
    }
}