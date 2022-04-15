namespace Uplink.Program
{
    public class System<T> where T : Capability.Capability
    {
        public static Type.Capabilities<T>? Capabilities = new();

        public System()
        {

        }

        public static void Register(T capability)
        {
            if (Capabilities == null)
            {
                return;
            }
            Capabilities.Add(capability);
        }

        public static void Update()
        {
            if (Capabilities == null)
            {
                return;
            }

            foreach (T capability in Capabilities)
            {
                capability.Update();
            }
        }
    }

    public class TerminalSystem : System<Terminal> { }
    //public class SpriteSystem : System<Sprite> { }
    //public class ColliderSystem : System<Collider> { }
}