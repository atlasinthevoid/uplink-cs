namespace Uplink.Capability.Core
{
    public class EncryptedPrivateObject : Capability
    {

        public EncryptedPrivateObject()
        {
            StringType = "EncryptedPrivateObject";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}