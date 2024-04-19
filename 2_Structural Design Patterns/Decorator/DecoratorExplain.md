
# Decorator Pattern :art:

## What is the Decorator Pattern? :thinking:
The Decorator Pattern allows you to attach additional responsibilities to an object dynamically. Decorators provide a flexible alternative to subclassing for extending functionality. :wrench:

## Why Use the Decorator Pattern? :bulb:
- To add functionalities to objects without altering the class itself. :heavy_plus_sign:
- When subclassing becomes impractical due to the number of subclasses that would be required for all combinations. :no_entry:

## How Does it Work? :mag_right:
- You start with your basic object, like a simple notification service. :bell:
- You create a series of decorator classes that wrap the basic object and add new functionalities, like SMS or Facebook notifications. :iphone::speech_balloon:
- These decorators can be "stacked" on the basic object to combine multiple functionalities. :stack:

## Example :email:
```csharp
public interface INotifier {
    void Send(string message);
}

public class EmailNotifier : INotifier {
    public void Send(string message) {
        // Code to send email
    }
}

public class SmsNotifier : INotifier {
    private INotifier _wrappedNotifier;

    public SmsNotifier(INotifier notifier) {
        _wrappedNotifier = notifier;
    }

    public void Send(string message) {
        // Code to send SMS
        _wrappedNotifier.Send(message);
    }
}
```
In this C# example, `SmsNotifier` decorates `EmailNotifier`, so when you send a message, it sends both an SMS and an email. :mailbox_with_mail:

## Benefits :tada:
- Flexibility: Objects can be decorated at runtime with new behaviors. :dancers:
- Reusability: You can mix and match different decorators for various combinations of behavior. :recycle:
- Simplicity: Avoids complex inheritance structures and keeps the class definition simple. :white_check_mark:

## Conclusion :bookmark_tabs:
The Decorator Pattern is a powerful tool for extending the functionality of objects without the need for complex subclass hierarchies. :rocket:

Feel free to contribute to this project by adding more decorators or examples! :octocat:

## License :scroll:
This project is licensed under the MIT License - see the LICENSE.md file for details :memo:
