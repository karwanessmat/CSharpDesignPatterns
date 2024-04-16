using Composite5Demo._1._Component;

namespace Composite5Demo._3.Composite;


internal class Folder(string name) : IComponent
{
    private readonly List<IComponent> _children = [];

    public string Name { get; } = name;

    public void Display(string currentPath)
    {
        Console.WriteLine(currentPath + Name +
                          Path.DirectorySeparatorChar);
    }

    public void Add(IComponent child)
    {
        _children.Add(child);
    }

    public void Remove(string name)
    {
        var childToRemove = _children.FirstOrDefault(c => c.Name == name);

        if (childToRemove is not null)
            _children.Remove(childToRemove);
    }

    public void DisplayChildren(string path)
    {
        foreach (var item in _children)
        {
            item.Display(path + Name +
                         Path.DirectorySeparatorChar);

            if (item is Folder folder)
            {
                folder.DisplayChildren(path + Name +
                                       Path.DirectorySeparatorChar);
            }
        }
    }
}