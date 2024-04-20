using Visitor6Demo._1_Visitor_Interface;
using Visitor6Demo._3_Define_the_Element_Interface;

namespace Visitor6Demo;

public class Form
{
    private readonly List<Control> _items = [];

    public void AddItem(Control item)
    {
        _items.Add(item);
    }

    public void Execute(IOperation operation)
    {
        foreach(var item in _items)
        {
            item.Execute(operation);
        }
    }
}