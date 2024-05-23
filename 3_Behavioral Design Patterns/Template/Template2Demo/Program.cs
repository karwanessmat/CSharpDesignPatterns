using System;
using Template2Demo.AbstractClass;
using Template2Demo.ConcreteClass;

namespace Template2Demo;

class Program
{
    static void Main(string[] args)
    {

        DataAccessor da = new Categories();
        // da.Run(5);

        DataAccessor product = new Products();
        product.Run(1, "Moped");

        Console.ReadKey();
    }
}