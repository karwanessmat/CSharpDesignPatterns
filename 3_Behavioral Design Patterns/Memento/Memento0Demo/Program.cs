using Memento0Demo.Step1__Create_the_Memento_class;
using Memento0Demo.Step2__Define_the_Originator_class;
using Memento0Demo.Step3__Implement_the_Caretaker_Class;

var originator = new Originator();
var caretaker = new Caretaker();

// Set and save state
originator.SetState("State #1");
Memento? savedMemento = originator.SaveStateToMemento();
caretaker.Add(savedMemento);

// Set another state
originator.SetState("State #2");
savedMemento = originator.SaveStateToMemento();
caretaker.Add(savedMemento);

// Set one more state
originator.SetState("State #3");
savedMemento = originator.SaveStateToMemento();
caretaker.Add(savedMemento);

// Showing current state
Console.WriteLine("Current State: " + originator.GetState());

// Restoring to the first saved state
originator.GetStateFromMemento(caretaker.Get(0));
Console.WriteLine("First saved State: " + originator.GetState());

// Restoring to the second saved state
originator.GetStateFromMemento(caretaker.Get(1));
Console.WriteLine("Second saved State: " + originator.GetState());