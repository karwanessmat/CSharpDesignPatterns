using Memento6Demo.Step1__Create_the_Memento_class;

namespace Memento6Demo.Step2__Define_the_Originator_class;

public class Editor
{

    public string Text { get; set; }
    public string Font { get; set; }
    public int FontSize { get; set; }

    public void ShowEditor()
    {
        Console.WriteLine($"Text: {Text} " +
                          $"with Font Size: {FontSize} " +
                          $"and Font: {Font}");
    }

    public void Undo(EditorState memento)
    {
        Text = memento.Text;
        Font = memento.Font;
        FontSize = memento.FontSize;
    }

    public EditorState CreateEditorState()
    {
        return new EditorState(Text, Font, FontSize);
    }

}