
# Memento Design Pattern

## 1. Definition
The Memento Pattern is a software design pattern that allows an object to save its state at a particular moment (called a "memento") and restore it later. This can be useful in applications where you might need to rollback or undo changes to an object's state.

## 2. Scenario
Imagine you're writing a text editor that supports undoing changes. Each time a user makes a change in the text editor, such as typing or deleting text, the state of the document before the change needs to be saved so that the user can revert back to it if they choose to undo the changes.

## 3. What is a problem?
The problem arises when the internal details of the objects to be saved and restored are exposed outside of the object itself, which can lead to a violation of the object's encapsulation. Moreover, managing the previous states can become cumbersome as the application grows.

## 4. Solution to the problem
The Memento Pattern solves these issues by keeping a separate object (the memento) that stores the internal state of the original object (the originator) without exposing its internal structure. The originator creates a memento object to capture its internal state and can use another memento to restore itself to a previous state. This operation is managed by another object called the caretaker, which handles the lifecycle and storage of mementos without knowing the contents of the memento.

## 5. Implementation Steps
1. **Create the Memento class**: This class will store the internal state of the Originator object.
2. **Define the Originator class**: This class generates a memento for its current state and can also use the memento to revert to its previous state.
3. **Implement the Caretaker class**: This class manages the mementos but doesn't modify or examine the contents of the mementos.

## 6. C# Code Implementation
```csharp
// Memento class
public class Memento
{
    private string state;

    public Memento(string state)
    {
        this.state = state;
    }

    public string GetState()
    {
        return state;
    }
}

// Originator class
public class Originator
{
    private string state;

    public void SetState(string state)
    {
        this.state = state;
    }

    public string GetState()
    {
        return state;
    }

    public Memento SaveStateToMemento()
    {
        return new Memento(state);
    }

    public void GetStateFromMemento(Memento memento)
    {
        state = memento.GetState();
    }
}

// Caretaker class
public class Caretaker
{
    private List<Memento> mementoList = new List<Memento>();

    public void Add(Memento state)
    {
        mementoList.Add(state);
    }

    public Memento Get(int index)
    {
        return mementoList[index];
    }
}
```
Each step in the code corresponds to one of the implementation steps described earlier.

## 7. Summary
The Memento Pattern is very useful for implementing undo mechanisms in applications such as text editors, graphic editors, and more. It helps in saving and restoring the state of an object without breaking its encapsulation.

## 8. Documentation Image
For a more visual representation of how the Memento Pattern works, consider including a diagram that outlines the interactions between the Originator, Memento, and Caretaker classes. Unfortunately, I cannot generate or upload images directly here. You can create a diagram using tools like Lucidchart, Microsoft Visio, or simply sketch it on paper and scan it into your documentation.

---

This README provides a comprehensive yet straightforward explanation of the Memento Design Pattern, designed to be accessible to a wide audience.