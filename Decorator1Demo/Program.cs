using Decorator1Demo._1_Component_Interface;
using Decorator1Demo._2_Create_a_Concrete_Component;
using Decorator1Demo._4_Create_Concrete_Decorator;

IComponent component = new ConcreteComponent();
Console.WriteLine(component.Operation());

IComponent decoratedComponentA = new ConcreteDecoratorA(component);
Console.WriteLine(decoratedComponentA.Operation());

IComponent decoratedComponentB = new ConcreteDecoratorB(decoratedComponentA);
Console.WriteLine(decoratedComponentB.Operation());