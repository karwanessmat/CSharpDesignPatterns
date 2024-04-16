using System;
using Decorator2Demo._1_Component_Interface;
using Decorator2Demo._2_Create_a_Concrete_Component;
using Decorator2Demo._3__Create_an_Abstract_Decorator;
using Decorator2Demo._4_Create_Concrete_Decorator;

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
