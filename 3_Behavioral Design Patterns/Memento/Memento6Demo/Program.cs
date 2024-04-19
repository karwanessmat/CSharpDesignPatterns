//Editor Creation

using Memento6Demo.Step2__Define_the_Originator_class;
using Memento6Demo.Step3__Implement_the_Caretaker_Class;

var editor = new Editor()
{
    Text = "First Text",
    Font = "Arial",
    FontSize = 12
};

var history = new History();

editor.ShowEditor();
var createdEditorState = editor.CreateEditorState();
history.Push(createdEditorState);


editor.Text = "Second Text";
editor.FontSize = 25;

editor.ShowEditor();
createdEditorState = editor.CreateEditorState();
history.Push(createdEditorState);


editor.Text = "Third Text";
editor.FontSize = 90;
editor.ShowEditor();


editor.Undo(history.Pop());
editor.ShowEditor();

editor.Undo(history.Pop());
editor.ShowEditor();