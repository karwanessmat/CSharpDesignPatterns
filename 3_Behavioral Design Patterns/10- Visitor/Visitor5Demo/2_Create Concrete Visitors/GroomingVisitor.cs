using Visitor5Demo._1_Visitor_Interface;
using Visitor5Demo._4__Implement_Concrete_Elements;

namespace Visitor5Demo._2_Create_Concrete_Visitors;

public class GroomingVisitor : IAnimalVisitor
{
    public void VisitDog(Dog dog)
    {
        Console.WriteLine($"Grooming the dog {dog.Name}.");
    }

    public void VisitCat(Cat cat)
    {
        Console.WriteLine($"Grooming the cat {cat.Name}.");
    }
}