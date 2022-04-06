public class SaveSystem : SystemComponent
{
    public SaveSystem(string name, State state) : base(name, state)
    {

    }

    public void Update()
    {
        Console.WriteLine("update");
    }

    // Saves global state
    void SaveUniverseToFile(string directory)
    {
        Console.WriteLine("Saving universe to file... (" + LocalState.Entities.Dictionary.Count.ToString() + " objects)");
        System.IO.Directory.CreateDirectory(directory);

        
        //File.WriteAllText(directory + "Objects.yaml", objects);
    }
}
