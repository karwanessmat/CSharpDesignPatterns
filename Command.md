
# Command Pattern

## Overview
The Command pattern is about turning requests or simple operations into objects. This allows you to control the details of how requests are made, including when and how they are executed. For example, in a text editor, instead of having different subclasses for each type of button (like Copy, Paste), you can have a single type of button that executes different "command" objects when clicked. This makes it easier to manage the actions and reduces the complexity of the code.
## Intent
The intent of the Command design pattern is to separate the object that initiates a request from the object that executes the request. This separation is achieved by encapsulating the request as an object, known as a command. This command contains all the information about the request and is then passed to an invoker object, which finds the appropriate object to execute the command.

## Applicability
The Command pattern is useful for:
- Implementing callback mechanisms.
- Queuing tasks and managing their execution.
- Tracking the history of operations and implementing undo/redo functionalities.
- Implementing retry mechanisms, particularly in scenarios where a service may be temporarily unavailable.
- Message queuing applications that require robustness against data loss.

## Participants
1. **Command**: An interface for executing an operation.
2. **ConcreteCommand**: Implements the Command interface and the Execute method.
3. **Client**: Creates and configures ConcreteCommand instances.
4. **Invoker**: Requests the command to carry out the operation.
5. **Receiver**: Contains the business logic to perform the operation.

## Implementation in C#
1. **Command Interface**: Defines an execution method.
   ```csharp
   public interface ICommand
   {
       void Execute();
   }
   ```

2. **Concrete Command**: Implements the Command interface.
   ```csharp
   public class TurnOnLightCommand : ICommand
   {
       private Light _light;

       public TurnOnLightCommand(Light light)
       {
           _light = light;
       }

       public void Execute()
       {
           _light.TurnOn();
       }
   }
   ```

3. **Receiver**: The actual performer of the action.
   ```csharp
   public class Light
   {
       public void TurnOn()
       {
           Console.WriteLine("Light is turned on");
       }
   }
   ```

4. **Invoker**: Triggers the execution of the command.
   ```csharp
   public class RemoteControl
   {
       private ICommand _command;

       public void SetCommand(ICommand command)
       {
           _command = command;
       }

       public void PressButton()
       {
           _command.Execute();
       }
   }
   ```

5. **Client**: Sets up the command and its execution context.
   ```csharp
   class Program
   {
       static void Main(string[] args)
       {
           Light light = new Light();
           ICommand turnOnLightCommand = new TurnOnLightCommand(light);
           RemoteControl remoteControl = new RemoteControl();

           remoteControl.SetCommand(turnOnLightCommand);
           remoteControl.PressButton();
       }
   }
   ```

## Benefits
- Decouples the sender of a request from its performer.
- Simplifies system architecture by separating execution and request logic.
- Enhances flexibility and reusability of code.

## Drawbacks
- Can lead to more complex code due to additional layers and objects.

In summary, the Command pattern provides a robust framework for managing operations, requests, and execution, allowing for more organized and flexible software design.

