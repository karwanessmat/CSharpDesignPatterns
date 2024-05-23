namespace Memento6Demo.Step1__Create_the_Memento_class;

public class EditorState(
    string text,
    string font,
    int fontSize)
{
    public readonly string Text = text;
    public readonly string Font = font;
    public readonly int FontSize = fontSize;
}