using System;
using Command1Demo.Invoker;
using Command1Demo.receiver;

namespace Command1Demo
{
    internal class Program
    {
        private static void Main()
        {
            //var modifyPrice = new ModifyPrice();
            //var product = new Product("Phone", 500);

            //Execute(product,
            //    modifyPrice, 
            //    new ProductCommand(product, PriceAction.Increase, 100));

            //Execute(product,
            //    modifyPrice, 
            //    new ProductCommand(product, PriceAction.Increase, 50));

            //Execute(product, 
            //    modifyPrice, 
            //    new ProductCommand(product, PriceAction.Decrease, 25));

            //Console.WriteLine(product);
            //Console.WriteLine();


            var modifyPrice2 = new ModifyPrice();
            var product2 = new Product("Phone", 500);
            Execute(product2, modifyPrice2, 
                new ProductCommand(product2, PriceAction.Increase, 100));
            Execute(product2, modifyPrice2, 
                new ProductCommand(product2, PriceAction.Increase, 50));
            Execute(product2, modifyPrice2, 

                new ProductCommand(product2, PriceAction.Decrease, 70));

            Console.WriteLine(product2);
            Console.WriteLine();
            modifyPrice2.UndoActions();
            Console.WriteLine(product2);

            Console.ReadLine();
        }

        private static void Execute(
            Product product,
            ModifyPrice modifyPrice, 
            ICommand productCommand)
        {
            modifyPrice.SetCommand(productCommand);
            modifyPrice.Invoke();
        }
    }
}
