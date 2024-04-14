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