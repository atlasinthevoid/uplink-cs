namespace Uplink.Command
{
    public class SaveUniverseToFile : Command
    {
        // Saves global state
        public SaveUniverseToFile(string directory)
        {
            //Console.WriteLine("Saving universe to file... (" + Parent.ByName<State>()[0].Count().ToString() + " objects)");
            System.IO.Directory.CreateDirectory(directory);
            /*
            string serialisedState = Parent.ByName<State>()[0].SerializeObject<State>();
            System.IO.File.WriteAllText(directory + "State.xml", serialisedState);

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(State));

            if (Parent.ByName<State>()[0] != null)
            {
                using (FileStream fileStream = new FileStream(directory + "State.xml", FileMode.Create))
                {
                    xmlSerializer.Serialize(fileStream, Parent.ByName<State>()[0]);
                }
            }*/
        }
    }
}
