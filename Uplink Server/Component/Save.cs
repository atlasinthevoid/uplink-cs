using System.Xml.Serialization;

namespace Uplink.Component
{
    public class Save : Component
    {
        public bool SaveToFile
        {
            get;
            init;
        }

        public Save()
        {
            
        }

        public override void Update()
        {
            Environment.Exit(0);
            if (SaveToFile)
            {
                //SaveToFile = false;
                SaveUniverseToFile(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\Uplink\");
                Environment.Exit(0);
            }
        }

        // Saves global state
        public void SaveUniverseToFile(string directory)
        {
            Console.WriteLine("Saving universe to file... (" + Parent.ByName<State>()[0].Count().ToString() + " objects)");
            System.IO.Directory.CreateDirectory(directory);

            string serialisedState = Utility.SerializeObject<State>(Parent.ByName<State>()[0]);
            System.IO.File.WriteAllText(directory + "State.xml", serialisedState);

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(State));

            if (Parent.ByName<State>()[0] != null)
            {
                using (FileStream fileStream = new FileStream(directory + "State.xml", FileMode.Create))
                {
                    xmlSerializer.Serialize(fileStream, Parent.ByName<State>()[0]);
                }
            }
        }
    }
}