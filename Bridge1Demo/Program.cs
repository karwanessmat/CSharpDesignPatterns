using Bridge1Demo.Abstraction;
using Bridge1Demo.ConcreteImplementation;
using Bridge1Demo.RefinedAbstraction;

namespace Bridge1Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape redCircle = new Circle(5,10,10,new RedCircle());
            Shape greenColor = new Circle(20,10,10,new GreenCircle());

            redCircle.Draw();
            greenColor.Draw();
            
        }
    }
}
