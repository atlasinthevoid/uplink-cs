namespace Uplink
{
    public class State
    {
        public Guid Id;
        public List<Entity> Entities;

        public State()
        {
            Id = Guid.NewGuid();
            Entities = new();
        }

        public List<Guid> FindID(List<Component> componentList)
        {
            List<Guid> ids = new();

            foreach (Entity e in Entities)
            {
                // Prevent modifications to the list passed in
                List<Component> searchComponents = componentList.ToList();
                foreach (Component c in e.Components)
                {
                    foreach (Component cs in componentList)
                    {
                        if (cs.Name == c.Name && cs.GetType() == c.GetType())
                        {
                            searchComponents.Remove(cs);
                        }
                    }
                }
                if (searchComponents.Count <= 0)
                {
                    ids.Add(e.Id);
                }
            }
            return ids;
        }

        public List<Entity> GetEntity(List<Component> componentList)
        {
            List<Entity> entities = new();

            List<Guid> list = FindID(componentList);
            if (list.Count <= 0)
            {
                Console.WriteLine("No vaild ids found");
            }

            foreach (Guid id in list)
            {
                foreach (Entity e in Entities)
                {
                    if (e.Id == id)
                    {
                        entities.Add(e);
                    }
                }
            }
            return entities;
        }
    }
}