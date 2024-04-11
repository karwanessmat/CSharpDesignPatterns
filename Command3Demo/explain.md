### These components together demonstrate the Command design pattern, showcasing how actions can be encapsulated as objects, allowing for flexible operation invocation and extension.




This code demonstrates the Command pattern, a behavioral design pattern that encapsulates a request as an object, thereby allowing for parameterization of clients with different requests, queue or log requests, and support undoable operations. The pattern involves four components: Command interface, Concrete Command, Receiver, and Invoker.

- **Command interface (`Command`)**: An abstract class or interface with an `Execute` method.
- **Concrete Command (`AddCommand`, `SubtractCommand`, `MultiplyCommand`, `DivideCommand`)**: Implements the `Command` interface and defines the binding between a Receiver object and an action.
- **Receiver (`SimpleCalculator`)**: Performs the actual work when the command's `Execute` method is called.
- **Invoker (`Invoker`)**: Asks the command to carry out the request.

The `SimpleCalculator` class performs basic arithmetic operations. Concrete commands like `AddCommand`, `SubtractCommand`, `MultiplyCommand`, and `DivideCommand` encapsulate the operations on `SimpleCalculator`. The `Invoker` class sets the command to execute and then executes it.


1. **Command Interface:**
   This is the abstract class or interface defining the `Execute` method that will be implemented by concrete commands.

    ```csharp

        public abstract class Command
        {
            protected SimpleCalculator Receiver;

            public Command(SimpleCalculator receiver)
            {
                Receiver = receiver;
            }

            public abstract int Execute();
        }

    ```

2. **Concrete Command Classes:**
   These classes implement the `Command` interface and define the binding between a `Receiver` object and an action.

    ```csharp
    public class AddCommand : Command
    {
        public AddCommand(SimpleCalculator receiver) : base(receiver) { }

        public override int Execute()
        {
            return Receiver.Add();
        }
    }

    public class SubtractCommand : Command
    {
        public SubtractCommand(SimpleCalculator receiver) : base(receiver) { }

        public override int Execute()
        {
            return Receiver.Subtract();
        }
    }

    public class MultiplyCommand : Command
    {
        public MultiplyCommand(SimpleCalculator receiver) : base(receiver) { }

        public override int Execute()
        {
            return Receiver.Multiply();
        }
    }

    public class DivideCommand : Command
    {
        public DivideCommand(SimpleCalculator receiver) : base(receiver) { }

        public override int Execute()
        {
            return Receiver.Divide();
        }
    }
    ```

3. **Receiver Class:**
   The `Receiver` class contains the actual logic of the operations that the commands will execute.

    ```csharp
    public class SimpleCalculator
    {
        private int a, b;

        public SimpleCalculator(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public int Add() { return a + b; }
        public int Subtract() { return a - b; }
        public int Multiply() { return a * b; }
        public int Divide() { return a / b; }
    }
    ```

4. **Invoker Class:**
   The `Invoker` class is responsible for invoking commands.

    ```csharp
    public class Invoker
    {
        private Command _command;

        public void SetCommand(Command command)
        {
            _command = command;
        }

        public int Execute()
        {
            return _command.Execute();
        }
    }
    ```

5. **Main Program:**
   The entry point of the program demonstrates how the Command pattern is used.

    ```csharp
    public class Program
    {
        private static void Main(string[] args)
        {
            var calculator = new SimpleCalculator(15, 3);

            var addCommand = new AddCommand(calculator);
            var subtractCommand = new SubtractCommand(calculator);
            var multiplyCommand = new MultiplyCommand(calculator);
            var divideCommand = new DivideCommand(calculator);

            var invoker = new Invoker();

            invoker.SetCommand(addCommand);
            Console.WriteLine("Result is {0}", invoker.Execute());

            invoker.SetCommand(subtractCommand);
            Console.WriteLine("Result is {0}", invoker.Execute());

            invoker.SetCommand(multiplyCommand);
            Console.WriteLine("Result is {0}", invoker.Execute());

            invoker.SetCommand(divideCommand);
            Console.WriteLine("Result is {0}", invoker.Execute());

            Console.ReadLine();
        }
    }
    ```

These components together demonstrate the Command design pattern, showcasing how actions can be encapsulated as objects, allowing for flexible operation invocation and extension.