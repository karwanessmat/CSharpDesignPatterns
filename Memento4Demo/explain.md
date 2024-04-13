
# Memento Design Pattern Example: Text Editor

This project demonstrates the implementation of the Memento design pattern in a simple text editor application using C#. The Memento pattern is used to save and restore the previous state of an object (in this case, the text editor) without revealing the details of its implementation.

## Overview

The Memento pattern involves three main components:

- **Originator**: The object whose state needs to be saved and restored.
- **Memento**: An object that stores the state of the originator.
- **Caretaker**: Manages the mementos without knowing the contents of the state stored in them.

## Implementation Steps

### Step 1: Define the Memento Class

The Memento class is responsible for storing the state of the originator. It is designed to be immutable to ensure that once a state is captured, it cannot be altered.

#### Why
To encapsulate and protect the state of the originator. Making it immutable prevents accidental changes to the stored state.

#### How
By providing a constructor that accepts the state parameters and storing these in private fields. Only getter methods are exposed.

#### Code
```csharp
public class Memento {
    private string text;
    private int curX;
    private int curY;

    public Memento(string text, int curX, int curY) {
        this.text = text;
        this.curX = curX;
        this.curY = curY;
    }

    public string GetText() {
        return text;
    }

    public int GetCursorX() {
        return curX;
    }

    public int GetCursorY() {
        return curY;
    }
}
```

### Step 2: Define the Originator Class

The Originator class (Editor) has methods to alter its state and to save and restore this state from a memento.

#### Why
To manage the actual state and implement the functionality to save and restore this state as needed.

#### How
By implementing methods to create a memento from the current state and another method to restore the state from a memento.

#### Code
```csharp
public class Editor {
    private string text = "";
    private int curX = 0;
    private int curY = 0;

    public void SetText(string newText) {
        text = newText;
    }

    public void SetCursor(int x, int y) {
        curX = x;
        curY = y;
    }

    public Memento CreateMemento() {
        return new Memento(text, curX, curY);
    }

    public void RestoreState(Memento memento) {
        text = memento.GetText();
        curX = memento.GetCursorX();
        curY = memento.GetCursorY();
    }

    public void Display() {
        Console.WriteLine("Current Content: " + text);
        Console.WriteLine("Cursor Position: (" + curX + ", " + curY + ")");
    }
}
```

### Step 3: Define the Caretaker Class

The Caretaker class manages when and how the originator's state is saved and restored using mementos.

#### Why
To decouple the state saving and restoring functionality from the originator, managing the history of state changes.

#### How
By maintaining a stack of mementos and providing methods to save new mementos and restore previous ones.

#### Code
```csharp
public class Caretaker {
    private Stack<Memento> mementos = new Stack<Memento>();
    private Editor editor;

    public Caretaker(Editor editor) {
        this.editor = editor;
    }

    public void Save() {
        mementos.Push(editor.CreateMemento());
    }

    public void Undo() {
        if (mementos.Count > 0) {
            Memento memento = mementos.Pop();
            editor.RestoreState(memento);
        }
    }
}
```

## Usage

The application allows the user to interact with the text editor by changing text and cursor positions. It also supports undoing recent changes by reverting to previous states stored in mementos.

## Conclusion

plication. It explains the purpose of each class and method, and how they contribute to implementing the Memento design pattern in the project.