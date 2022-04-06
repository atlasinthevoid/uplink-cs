using System;

public class TextComponent : Component
{
    public string? Text;

    public TextComponent(string name, string text) : base(name)
    {
        Text = text;
    }
}