using System.Xml.Serialization;

namespace Uplink.Capability
{
    public class Loading : Capability
    {
        public Loading()
        {
            Program.LoadingSystem.Register(this);
        }

        public override void Update()
        {
            
        }
    }
}