using System.Xml.Serialization;

namespace Uplink
{
    public class LoadingComponent : Component
    {
        public LoadingComponent()
        {

        }

        public override void Update()
        {
            
        }

        void LoadUniverseFromFile(string directory)
        {
            Console.WriteLine("Loading universe from file...");
            if (!File.Exists(directory + "State.xml"))
            {
                Entity error = new Entity();
                Add(new TextComponent() { Text = "universe save file not found" });
                RaiseAddEntity(error);
                return;
            }

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(StateComponent));

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