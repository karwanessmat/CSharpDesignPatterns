using Memento4Demo.Step1__Create_the_Memento_class;
using Memento4Demo.Step2__Define_the_Originator_class;
using Memento4Demo.Step3__Implement_the_Caretaker_Class;

var editor = new Editor();
var caretaker = new Caretaker(editor);

// Simulate user typing
editor.SetText("Hello");
caretaker.Save(); // Save state
editor.Display();

editor.SetText("Hello, World!");
caretaker.Save(); // Save state
editor.Display();


// Undo changes
caretaker.Undo();
editor.Display();

caretaker.Undo();
editor.Display();
Console.WriteLine();
foreach (Memento? memento in caretaker.UndoMementos())
{
    Console.WriteLine($"removed: {memento.GetText()}");
}