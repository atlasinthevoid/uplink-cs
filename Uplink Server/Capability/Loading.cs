using System.Xml.Serialization;

namespace Uplink.Capability
{
    public class Loading : Capability
    {
        public Loading()
        {

        }

        public override void Update()
        {
            
        }

        void LoadUniverseFromFile(string directory)
        {
            Console.WriteLine("Loading universe from file...");
            if (!System.IO.File.Exists(directory + "State.xml"))
            {
                new Text() { Name = "error", Value = "universe save file not found" };
                return;
            }

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(State));

            using (FileStream fileStream = new FileStream(directory + "State.xml", FileMode.Open))
            {/*
                Object? newState = xmlSerializer.Deserialize(fileStream);
                if (newState != null)
                {
                    StateComponent s = (StateComponent)newState;
                    StateComponent sOld = Parent.ByName<StateComponent>()[0];
                    Console.WriteLine("Applying loaded state " + "(old " + sOld.Count().ToString() + ") (new " + s.Count().ToString() + ")");
                    sOld = s;
                }*/
            }
        }
    }
}