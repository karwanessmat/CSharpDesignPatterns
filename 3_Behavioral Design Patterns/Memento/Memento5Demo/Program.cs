using Memento5Demo.Step2__Define_the_Originator_class;
using Memento5Demo.Step3__Implement_the_Caretaker_Class;

var editor = new Editor();
var history = new History();

editor.Type("This is the first sentence.");
history.Save(editor);

editor.Type("This is the second sentence.");
history.Save(editor);

editor.Type("This is the third sentence.");

// User decides to undo the last action
history.Undo(editor);
Console.WriteLine(editor.GetContent());

// Undo again
history.Undo(editor);
Console.WriteLine(editor.GetContent());