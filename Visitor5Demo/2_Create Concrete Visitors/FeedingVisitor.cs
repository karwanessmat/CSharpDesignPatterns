using Visitor5Demo._1_Visitor_Interface;
using Visitor5Demo._4__Implement_Concrete_Elements;

namespace Visitor5Demo._2_Create_Concrete_Visitors;

public class FeedingVisitor : IAnimalVisitor
{
    public void VisitDog(Dog dog)
    {
        Console.WriteLine($"Feeding the dog {dog.Name} with dog food.");
    }

    public void VisitCat(Cat cat)
    {
        Console.WriteLine($"Feeding the cat {cat.Name} with cat food.");
    }
}