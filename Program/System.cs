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

            Command.Log l = new();
            l.Message = capability.GetType().ToString().Split(".")[2] + " capability registered";
            l.Level = "Trace";
            l.Execute();
        }

        public static void Update()
        {
            if (Capabilities == null)
            {
                return;
            }

            foreach (T capability in Capabilities.Get())
            {
                capability.Update();
            }
        }
    }

    public class AudioSystem : System<Capability.Audio> { }
    public class BoolSystem : System<Capability.Bool> { }
    public class BroadcastSystem : System<Capability.Broadcast> { }
    public class CapabilitySystem : System<Capability.Capability> { }
    public class FileSystem : System<Capability.File> { }
    public class FloatSystem : System<Capability.Float> { }
    public class IdSystem : System<Capability.Id> { }
    public class ImageSystem : System<Capability.Image> { }
    public class IntSystem : System<Capability.Int> { }
    public class LoadingSystem : System<Capability.Loading> { }
    public class MeshSystem : System<Capability.Mesh> { }
    public class PositionSystem : System<Capability.Position> { }
    public class SaveSystem : System<Capability.Save> { }
    public class SocketSystem : System<Capability.Socket> { }
    public class StatusSystem : System<Capability.Status> { }
    public class TerminalSystem : System<Capability.Terminal> { }
    public class TextSystem : System<Capability.Text> { }
    public class TimeSystem : System<Capability.Time> { }
    public class PoseSystem : System<Capability.Pose> { }
    public class MatrixSystem : System<Capability.Matrix> { }
    public class TaskSystem : System<Capability.Task> { }
    public class InventorySystem : System<Capability.Inventory> { }
    public class AvatarSystem : System<Capability.Avatar> { }
    public class ButtonSystem : System<Capability.Button> { }
    public class ControllerSystem : System<Capability.Controller> { }
    public class HandSystem : System<Capability.Hand> { }
    public class HandleSystem : System<Capability.Handle> { }
    public class ProfileSystem : System<Capability.Profile> { }
    public class WindowSystem : System<Capability.Window> { }
}