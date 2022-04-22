namespace Uplink.Command
{
    public class LoadUniverseFromFile : Command
    {
        public string Directory;
        public LoadUniverseFromFile()
        {
            Directory = "";
            StringType = "LoadUniverseFromFile";
        }

        internal override void Exec()
        {
            Log l = new();
            l.Message = "Loading universe from file...";
            l.Execute();

            if (!System.IO.File.Exists(Directory + "State.xml"))
            {
                //new Text() { Name = "error", Value = "universe save file not found" };
                return;
            }
            /*
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(State));

            using (FileStream fileStream = new FileStream(directory + "State.xml", FileMode.Open))
            {
                Object? newState = xmlSerializer.Deserialize(fileStream);
                if (newState != null)
                {
                    StateComponent s = (StateComponent)newState;
                    StateComponent sOld = Parent.ByName<StateComponent>()[0];
                    Console.WriteLine("Applying loaded state " + "(old " + sOld.Count().ToString() + ") (new " + s.Count().ToString() + ")");
                    sOld = s;
                }
            }*/
        }

        public override void Undo()
        {

        }
    }
}
