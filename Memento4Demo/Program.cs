using Memento4Demo.Step2__Define_the_Originator_class;
using Memento4Demo.Step3__Implement_the_Caretaker_Class;

Editor editor = new Editor();
Caretaker caretaker = new Caretaker(editor);

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
foreach (var memento in caretaker.UndoMementos())
{
    Console.WriteLine($"removed: {memento.GetText()}");
}