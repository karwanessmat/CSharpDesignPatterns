using Visitor5Demo._1_Visitor_Interface;
using Visitor5Demo._3_Define_the_Element_Interface;

namespace Visitor5Demo._4__Implement_Concrete_Elements;

public class Cat : IAnimal
{
    public string Name { get; set; }

    public void Accept(IAnimalVisitor visitor)
    {
        visitor.VisitCat(this);
    }
}