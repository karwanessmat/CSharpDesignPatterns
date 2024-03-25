using System;
using Decorate2Demo.Component;
using Decorate2Demo.ConcreteComponent;
using Decorate2Demo.ConcreteDecorate;
using Decorate2Demo.Decorate;

namespace Decorate2Demo
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
