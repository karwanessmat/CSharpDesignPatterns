using Visitor5Demo._4__Implement_Concrete_Elements;

namespace Visitor5Demo._1_Visitor_Interface;
public interface IAnimalVisitor
{
    void VisitDog(Dog dog);
    void VisitCat(Cat cat);
}