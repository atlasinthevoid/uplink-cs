using System.Xml.Serialization;

namespace Uplink.Capability
{
    [XmlRoot(Namespace = "Uplink")]

    public class Capability : Type.Type
    {
        public Type.Metadata Metadata;

        public Capability()
        {
            StringType = "Capability";
            Metadata = new();
            Metadata.Add(new Type.Id());
            Metadata.Add(new Type.CreationTime());
        }

        public virtual void Update()
        {

        }
    }
}