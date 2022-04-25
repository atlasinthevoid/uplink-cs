namespace Uplink.Capability.Text
{
    public class PasswordBox : Capability
    {
        public PasswordBox()
        {
            StringType = "PasswordBox";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}