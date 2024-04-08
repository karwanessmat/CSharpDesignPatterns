using System;
using Decorator2Demo._1.Component;
using Decorator2Demo._2.ConcreteComponents;
using Decorator2Demo._3.Decorate;
using Decorator2Demo._4.ConcreteDecorate;

namespace Decorator2Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Create Economy Car Instance
            ICar objCar = new EconomyCar();


            //Wrp Economy Car instance with Basic Accessories
            CarAccessoriesDecorator objAccessoriesDecorator=new BasicAccessories(objCar);


            //Wrap EconomyCar instance with AdvancedAccessories instance.   
            objAccessoriesDecorator = new AdvancedAccessories(objAccessoriesDecorator);



            Console.Write("Car Detials: " + objAccessoriesDecorator.GetDescription());
            Console.WriteLine("\n\n");
            Console.Write("Total Price: " + objAccessoriesDecorator.GetCost());

            Console.Read();
        }
    }
}
