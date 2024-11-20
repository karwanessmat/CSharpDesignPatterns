using System;
using Command1Demo._1.Command_Interface;
using Command1Demo._2.Concrete_Commands;
using Command1Demo._3.Receiver;
using Command1Demo._4.Invoker;

namespace Command1Demo;

internal class Program
{
    private static void Main()
    {
        var modifyPrice = new ModifyPrice();
        var product = new Product("Phone", 500);

        Execute(product, modifyPrice, new ProductCommand(product, PriceAction.Increase, 100));
        Execute(product, modifyPrice, new ProductCommand(product, PriceAction.Increase, 50));
        Execute(product, modifyPrice, new ProductCommand(product, PriceAction.Decrease, 70));

        Console.WriteLine(product);
        Console.WriteLine();

        modifyPrice.UndoActions();
        Console.WriteLine(product);

        Console.ReadLine();
    }

    private static void Execute(Product product, ModifyPrice modifyPrice, ICommand productCommand)
    {
        modifyPrice.SetCommand(productCommand);
        modifyPrice.Invoke();
    }
}