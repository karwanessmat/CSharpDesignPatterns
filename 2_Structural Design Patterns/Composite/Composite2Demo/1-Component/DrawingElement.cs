namespace Composite2Demo._1_Component;

/// <summary>
/// The 'Component' TreeNode
/// </summary>
public abstract class DrawingElement(string name)
{

    protected string Name = name;


    public abstract void Add(DrawingElement d);
    public abstract void Remove(DrawingElement d);
    public abstract void Display(int indent);

}