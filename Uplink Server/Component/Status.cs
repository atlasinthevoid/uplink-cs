﻿using System.Numerics;

namespace Uplink
{
    public class StatusComponent : Component
    {
        public StatusComponent()
        {

        }

        public override void Update()
        {

        }

        void CheckVars()
        {
            PositionComponent position = new() { Name = "universe position", Number = new Vector3(0, 0, 0) };

            Entity clientId = new();
            AddEntity(this, clientId);
            AddComponent(this, (clientId, new IdComponent() { Name = "local client id", Value = Parent.}));

            Entity universe = new();
            universe.Add(position);
            universe.Add(new IntComponent() { Name = "revision", Number = 0 });
            universe.Add(new TextComponent() { Name = "server", Text = "192.168.0.1:4545" });
            universe.Add(new BoolComponent() { Name = "started", Flag = false });
            universe.Add(new BoolComponent() { Name = "ready", Flag = true });
            state.Add(universe);

            Entity filesystem = new();
            string appData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string documents = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            filesystem.Add(new TextComponent() { Name = "uplink data", Text = appData + @"\Uplink\" });
            filesystem.Add(new TextComponent() { Name = "uplink ingest", Text = documents + @"\Uplink Ingest\" });
            filesystem.Add(new TextComponent() { Name = "uplink export", Text = documents + @"\Uplink Export\" });
            state.Add(filesystem);
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