namespace Uplink
{
    public class TextComponent : Component
    {
        public string? Text;

        public TextComponent()
        {
            Text = "";
        }

        public TextComponent(Guid author, string name, string text) : base(author, name)
        {
            Text = text;
        }
    }
}