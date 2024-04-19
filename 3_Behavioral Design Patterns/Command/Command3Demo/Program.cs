using System;
using Command3Demo._2.Concrete_Commands;
using Command3Demo._3.Receiver;
using Command3Demo._4.Invoker;

namespace Command3Demo
{
    internal class Program
    {
        private static void Main(string[] args)
        {


            var calculator = new SimpleCalculator(15, 3);

            var addCommand = new AddCommand(calculator);
            var abstractCommand = new SubtractCommand(calculator);
            var multiplyCommand = new MultiplyCommand(calculator);
            var divideCommand = new DivideCommand(calculator);

            var invoker = new Invoker();
            invoker.SetCommand(addCommand);
            Console.WriteLine("Result is {0}", invoker.Execute());

            invoker.SetCommand(abstractCommand);
            Console.WriteLine("Result is {0}", invoker.Execute());

            invoker.SetCommand(multiplyCommand);
            Console.WriteLine("Result is {0}", invoker.Execute());

            invoker.SetCommand(divideCommand);
            Console.WriteLine("Result is {0}", invoker.Execute());

            Console.ReadLine();
        }
    }
}
