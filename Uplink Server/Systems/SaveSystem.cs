using System.Xml.Serialization;

namespace Uplink
{
    public class SaveSystem : SystemComponent
    {
        public SaveSystem()
        {

        }

        public SaveSystem(string name, State state) : base(name, state)
        {

            
        }

        public void Update()
        {
            foreach (Entity e in LocalState.Entities.ToList())
            {
                foreach (Component c in e.Components)
                {
                    if (c.Name != "")
                    {
                        Console.WriteLine(c.Name);
                    }
                    if (c is SaveComponent)
                    {
                        SaveComponent saveComponent = (SaveComponent)c;
                        Environment.Exit(0);
                        if (saveComponent.SaveToFile)
                        {
                            saveComponent.SaveToFile = false;
                            SaveUniverseToFile(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\Uplink\");
                            Environment.Exit(0);
                        }
                    }
                }
            }
        }

        // Saves global state
        public void SaveUniverseToFile(string directory)
        {
            Console.WriteLine("Saving universe to file... (" + LocalState.Entities.Count.ToString() + " objects)");
            System.IO.Directory.CreateDirectory(directory);

            string serialisedState = Utility.SerializeObject<State>(LocalState);
            File.WriteAllText(directory + "State.xml", serialisedState);

            XmlSerializer xmlSerializer = new XmlSerializer(LocalState.GetType());

            if (LocalState != null)
            {
                using (FileStream fileStream = new FileStream(directory + "State.xml", FileMode.Create))
                {
                    xmlSerializer.Serialize(fileStream, LocalState);
                }
            }
        }
    }

}