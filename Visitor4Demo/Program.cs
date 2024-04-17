using Visitor4Demo._1_Visitor_Interface;
using Visitor4Demo._2_Create_Concrete_Visitors;
using Visitor4Demo._3_Define_the_Element_Interface;
using Visitor4Demo._4__Implement_Concrete_Elements;

List<IProduct> products = new List<IProduct>
{
    new Book(1.2),
    new Electronics(3.5),
    new Clothing()
};

IShippingVisitor shippingVisitor = new StandardShippingVisitor();

double totalShippingCost = 0;
foreach (var product in products)
{
    totalShippingCost += product.Accept(shippingVisitor);
}

Console.WriteLine($"Total Shipping Cost: {totalShippingCost}");


Console.WriteLine();
// we can write a code for each one separately
IProduct book1 = new Book(10);
IProduct book2 = new Book(20);
IShippingVisitor shippingVisitor2 = new StandardShippingVisitor();
double totalShippingCost2 = 0;

totalShippingCost2 += book1.Accept(shippingVisitor2);
Console.WriteLine($"Total Shipping Cost: {totalShippingCost2}");

totalShippingCost2 += book2.Accept(shippingVisitor2);
Console.WriteLine($"Total Shipping Cost: {totalShippingCost2}");
