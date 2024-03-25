using System;

namespace Memento1Demo
{
    class Program
    {
        static void Main(string[] args)
        {

            var calculator = new Calculator();
            calculator.Add(15);
            calculator.Add(5);
            calculator.Subtract(8);

            var checkPoint = calculator.CreateMemento();
            calculator.Add(88);
            Console.WriteLine("he value of the result variable is: "+calculator.GetResult());

            // return value before the checkpoint
            calculator.SaveState(checkPoint);
            Console.WriteLine("The value of the result variable at first checkpoint is: " 
                               +calculator.GetResult());

            Console.ReadLine();
        }
    }
}
