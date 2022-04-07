using System.Xml.Serialization;

namespace Uplink
{
    public abstract class SystemComponent : Component
    {
        [XmlIgnore]
        public State LocalState;

        public SystemComponent()
        {
            LocalState = new();
        }

        public SystemComponent(string name, State state) : base(state.Id, name)
        {
            LocalState = state;
        }
    }
}