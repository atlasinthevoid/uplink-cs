namespace Uplink.Capability.Menu
{
    public class Status : Capability
    {
        public Status()
        {
            StringType = "Status";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }

        void CheckVars()
        {
            Type.Entity u = new();
            u.Add(new Universe());

            Type.Entity fs = new();
            fs.Add(new FileSystem());
        }


        /*
        string UniverseToString()
        {
            string state = "<color=#ffffff>Cached objects: " + System.Environment.NewLine;
            foreach (KeyValuePair<Guid, dynamic> id in ObjectsDatabase)
            {
                string stringTags = "";

                if (TagsDatabase.ContainsKey(id.Key))
                {
                    stringTags = "";
                    bool first = true;

                    foreach (dynamic tag in TagsDatabase[id.Key])
                    {
                        if (first == true)
                        {
                            stringTags += tag.ToString();
                        }
                        else
                        {
                            stringTags += ", " + tag.ToString();
                        }
                        first = false;
                    }
                }
                else
                {
                    stringTags = "no tags found";
                }


                state += "<color=#4c86a888>" + stringTags;
                state += ": <color=#edf060FF>" + id.Value.ToString() + "</color>" + System.Environment.NewLine;
            }
            state += System.Environment.NewLine;
            state += "<color=#ffffff>Tags index: " + System.Environment.NewLine;
            foreach (KeyValuePair<Guid, List<Guid>> tag in TagsIndex)
            {
                state += "<color=#4c86a888>" + tag.Key.ToString();
                state += ": <color=#edf060FF>" + tag.Value.Count.ToString() + " objects</color>" + System.Environment.NewLine;
            }
            state += System.Environment.NewLine;
            state += "<color=#ffffff>Events to process: " + EventsToProcess.Count + System.Environment.NewLine;

            return state;
        }*/
    }
}