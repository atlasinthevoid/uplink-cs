namespace Uplink.Capability.World
{
    public class Controller : Capability
    {
        public StereoKit.Handed Hand;
        public StereoKit.Pose PointerPosition;
        public float GripPress;
        public float TriggerPress;
        public StereoKit.Pose Position;
        public StereoKit.Vec2 StickRotation;
        public StereoKit.BtnState StickClick;
        public StereoKit.BtnState Connected;
        public StereoKit.TrackState PositionTrackingStatus;
        public StereoKit.TrackState RotationTrackingStatus;
        public StereoKit.BtnState PrimaryButton;
        public StereoKit.BtnState SecondaryButton;


        public Controller()
        {
            StringType = "Controller";
            Hand = StereoKit.Handed.Right;
            Program.Systems.Register(this);
        }

        public override void Update()
        {
            StereoKit.Controller c = StereoKit.Input.Controller(Hand);
            PointerPosition = c.aim;
            GripPress = c.grip;
            TriggerPress = c.trigger;
            Position = c.pose;
            StickRotation = c.stick;
            StickClick = c.stickClick;
            Connected = c.tracked;
            PositionTrackingStatus = c.trackedPos;
            RotationTrackingStatus = c.trackedRot;
            PrimaryButton = c.x1;
            SecondaryButton = c.x2;
        }
    }
}