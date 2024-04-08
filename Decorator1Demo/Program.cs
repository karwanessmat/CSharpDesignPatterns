using Decorator1Demo._1.Component;
using Decorator1Demo._2.ConcreteComponent;
using Decorator1Demo._4.ConcreteDecorates;


IComponent component = new ConcreteComponent();
Console.WriteLine(component.Operation());

IComponent decoratedComponentA = new ConcreteDecoratorA(component);
Console.WriteLine(decoratedComponentA.Operation());

IComponent decoratedComponentB = new ConcreteDecoratorB(decoratedComponentA);
Console.WriteLine(decoratedComponentB.Operation());