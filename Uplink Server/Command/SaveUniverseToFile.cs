namespace Uplink.Command
{
    public class SaveUniverseToFile : Command
    {
        public string Directory;
        // Saves global state
        public SaveUniverseToFile()
        {
            Directory = "";
            StringType = "SaveUniverseToFile";
        }

        internal override void Exec()
        {
            //("Saving universe to file... (" + Parent.ByName<State>()[0].Count().ToString() + " objects)");
            System.IO.Directory.CreateDirectory(Directory);
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

        public override void Undo()
        {

        }
    }
}
