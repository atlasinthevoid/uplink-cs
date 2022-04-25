namespace Uplink.Capability.Core
{
    public class EncryptedReadOnlyObject : Capability
    {

        public EncryptedReadOnlyObject()
        {
            StringType = "EncryptedReadOnlyObject";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}