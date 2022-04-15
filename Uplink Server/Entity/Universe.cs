using System.Numerics;

namespace Uplink.Entity
{
    public class Universe : Entity
    {
        public Universe()
        {
            Add(new Capability.Position() {
                Metadata = { new Type.Name() { Value = "universe position" } },
                Number = new Vector3(0, 0, 0)
            });

            Add(new Capability.Int() {
                Metadata = { new Type.Name() { Value = "revision" } }, 
                Number = 0 
            });

            Add(new Capability.Text() {
                Metadata = { new Type.Name() { Value = "server" } },
                Value = "192.168.0.1:4545"
            });

            Add(new Capability.Bool()
            {
                Metadata = { new Type.Name() { Value = "started" } },
                Flag = false
            });

            Add(new Capability.Bool()
            {
                Metadata = { new Type.Name() { Value = "ready" } },
                Flag = true
            });
        }
    }
}
