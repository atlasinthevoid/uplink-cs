using System.Xml.Serialization;

namespace Uplink
{
    public class LoadingSystem : SystemComponent
    {
        public LoadingSystem()
        {

        }

        public LoadingSystem(string name, State state) : base(name, state)
        {
            LoadUniverseFromFile(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\Uplink\");
        }

        public void Update()
        {

        }

        void LoadUniverseFromFile(string directory)
        {
            Console.WriteLine("Loading universe from file...");
            if (!File.Exists(directory + "State.xml"))
            {
                Entity error = new Entity();
                error.Add(new TextComponent(LocalState.Id, "text", "universe save file not found"));
                LocalState.Entities.Add(error);
                return;
            }

            XmlSerializer xmlSerializer = new XmlSerializer(LocalState.GetType());

            using (FileStream fileStream = new FileStream(directory + "State.xml", FileMode.Open))
            {
                Object? newState = xmlSerializer.Deserialize(fileStream);
                if (newState != null)
                {
                    State s = (State)newState;
                    Console.WriteLine("Applying loaded state " + "(old " + LocalState.Entities.Count.ToString() + ") (new " + s.Entities.Count.ToString() + ")");
                    LocalState = s;
                }
            }
        }
    }
}