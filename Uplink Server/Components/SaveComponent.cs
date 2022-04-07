namespace Uplink
{
    public class SaveComponent : Component
    {
        public bool SaveToFile;

        public SaveComponent()
        {
            
        }

        public SaveComponent(Guid author, string name, bool saveToFile) : base(author, name)
        {
            SaveToFile = saveToFile;
        }
    }
}