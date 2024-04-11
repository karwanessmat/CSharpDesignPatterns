The provided code illustrates the implementation of the Command design pattern. Here’s a detailed step-by-step explanation of what was done:

1. **Define ICommand Interface:**
   - An `internal interface ICommand` is declared with a single method `Execute()`. This interface serves as the contract for all command implementations, ensuring they have an `Execute` method.

2. **Create Abstract Command Class:**
   - An abstract class `Command` is created, implementing the `ICommand` interface.
   - It has a protected member `Receiver` of type `DataReceiver`, initialized via the constructor, to be used by derived command classes.
   - It declares an abstract `Execute` method, forcing subclasses to provide their own implementations.

3. **Implement Concrete Commands:**
   - Two concrete command classes, `DeleteCommand` and `UpsertCommand`, are derived from the `Command` class.
   - Each overrides the `Execute` method to perform specific actions on `DataReceiver`:
     - `DeleteCommand.Execute` calls `Receiver.Delete`, passing a key to remove data.
     - `UpsertCommand.Execute` calls `Receiver.Upsert`, passing a key and value to insert or update data.

4. **Create DataReceiver Class:**
   - `DataReceiver` contains a private dictionary `_data` to store key-value pairs.
   - It has methods `Upsert` and `Delete` to modify the data, with `Upsert` either adding or updating an entry and `Delete` removing an entry if it exists.

5. **Implement DataCommandInvoker Class:**
   - This class acts as an invoker in the Command pattern, with a private field `_command` of type `ICommand`.
   - `SetCommand` method allows setting the command to be executed.
   - `ExecuteCommand` checks if `_command` is not null and executes the `Execute` method of the set command.

6. **Execution Flow:**
   - An instance of `DataReceiver` and `DataCommandInvoker` is created.
   - The `SetCommand` method of `invoker` is used to assign different commands (`UpsertCommand` and `DeleteCommand`) with appropriate arguments.
   - `ExecuteCommand` is called to execute the set commands sequentially, affecting the state of `DataReceiver`’s data store.

7. **Design Pattern Utilization:**
   - The Command pattern encapsulates a request as an object, thereby allowing for parameterization of clients with different requests, queuing of requests, and logging of operations.
   - It provides the flexibility to execute commands and undo actions if necessary (though undo functionality is not implemented in this code).

8. **Constructor Injection Comment:**
   - The comment in `DataCommandInvoker` indicates a design choice: constructor injection of the command object was avoided to allow changing the command dynamically at runtime, since there are multiple concrete commands that might be used.

The pattern demonstrated enables operations to be encapsulated within command objects, providing a flexible and extendable structure for executing operations on `DataReceiver`.
1. **Define ICommand Interface:**
   ```csharp
   internal interface ICommand
   {
       void Execute();
   }
   ```
   - This interface defines the contract for command classes.

2. **Create Abstract Command Class:**
   ```csharp
   internal abstract class Command(DataReceiver receiver) : ICommand
   {
       protected DataReceiver Receiver = receiver;
       public abstract void Execute();
   }
   ```
   - This abstract class implements the `ICommand` interface and contains a reference to `DataReceiver`.

3. **Implement Concrete Commands:**
   - `DeleteCommand`:
     ```csharp
     internal class DeleteCommand(string key,DataReceiver receiver) : Command(receiver)
     {
         public override void Execute()
         {
             Receiver.Delete(key);
         }
     }
     ```
   - `UpsertCommand`:
     ```csharp
     internal class UpsertCommand(
         string key,
         string value,
         DataReceiver receiver) : Command(receiver)
     {
         public override void Execute()
         {
             Receiver.Upsert(key, value);
         }
     }
     ```
   - These classes provide specific implementations of the `Execute` method.

4. **Create DataReceiver Class:**
   ```csharp
   internal class DataReceiver
   {
       private readonly Dictionary<string, string> _data = [];

       public void Upsert(string key, string value)
       {
           // Implementation of Upsert method
       }

       public void Delete(string key)
       {
           // Implementation of Delete method
       }
   }
   ```
   - Manages data and provides methods for manipulating it (`Upsert` and `Delete`).

5. **Implement DataCommandInvoker Class:**
   ```csharp
   internal class DataCommandInvoker
   {
       private ICommand? _command;

       public void SetCommand(ICommand command)
       {
           _command = command;
       }

       public void ExecuteCommand()
       {
           _command?.Execute();
       }
   }
   ```
   - Manages the execution of commands.

6. **Execution Flow:**
   ```csharp
   var dataReceiver = new DataReceiver();
   var invoker = new DataCommandInvoker();

   invoker.SetCommand(new UpsertCommand("item1", "value1", dataReceiver));
   invoker.ExecuteCommand();

   // Additional commands are set and executed similarly
   ```

7. **Design Pattern Utilization:**
   - The entire code structure demonstrates how the Command pattern allows operations to be encapsulated in objects and executed by an invoker.

8. **Constructor Injection Comment:**
   - The comment in `DataCommandInvoker` explains the design choice:
     ```csharp
     /// <summary>
     /// we did not inject constructor because we have more than one concrete commands 
     /// </summary>
     ```

Each step corresponds to a specific part of the code, demonstrating how the Command design pattern is implemented in a clear and structured manner.