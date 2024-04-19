using Composite5Demo._1._Component;

namespace Composite5Demo._2._Leaf;

internal class FileItem(string name) : IComponent
{
    public string Name { get; } = name;

    public void Display(string currentPath)
    {
        Console.WriteLine(currentPath + Name);
    }
}
