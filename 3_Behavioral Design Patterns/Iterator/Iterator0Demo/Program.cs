using Iterator0Demo.Step1_Iterator_Interface;
using Iterator0Demo.step4_Concrete_Collection;

ConcreteAggregate aggregate = new ConcreteAggregate();
aggregate[0] = "Item A";
aggregate[1] = "Item B";
aggregate[2] = "Item C";

IIterator iterator = aggregate.CreateIterator();

while (iterator.HasNext())
{
    object? item = iterator.Next();
    Console.WriteLine(item);
}