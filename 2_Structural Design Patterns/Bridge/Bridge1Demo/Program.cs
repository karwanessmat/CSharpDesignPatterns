using Bridge1Demo._2_Create_Concrete_Implementations;
using Bridge1Demo._3_Define_Abstraction;
using Bridge1Demo._4_Create_Refined_Abstraction;

namespace Bridge1Demo;

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