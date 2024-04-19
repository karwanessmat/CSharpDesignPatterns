using Visitor6Demo._1_Visitor_Interface;

namespace Visitor6Demo._3_Define_the_Element_Interface;

public abstract class Control(string name)
{     
    public string Name { get; set; } = name;
    public abstract void Execute(IOperation operation);
}