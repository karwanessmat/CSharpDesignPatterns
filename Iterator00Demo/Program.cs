using Iterator00Demo;
using Iterator00Demo.step4_Concrete_Collection;

var listOfValues = new List<int>()
{
    8, 19, 25, 2, 4, 7, 32, 90, 3, 1
};

var listAggregate = new ListAggregate();

foreach (var value in listOfValues)
{
    listAggregate.Insert(value);
}

var listIterator = listAggregate.CreateIterator();

Console.WriteLine("Values from List Iterator:");

while (listIterator.MoveNext())
{
    Console.Write($"{listIterator.GetCurrent()}, ");
}

Console.WriteLine();
Console.WriteLine("________________");

var treeAggregate = new SortedBinaryTreeCollection();

foreach (var value in listOfValues)
{
    treeAggregate.Insert(value);
}

var treeIterator = treeAggregate.CreateIterator();

Console.WriteLine("");
Console.WriteLine("Values from Binary Tree Iterator:");

while (treeIterator.MoveNext())
{
    Console.Write($"{treeIterator.GetCurrent()}, ");
}

Console.ReadKey();

return;