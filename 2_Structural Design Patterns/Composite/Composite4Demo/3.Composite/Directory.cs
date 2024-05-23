using Composite4Demo._1._Component;

namespace Composite4Demo._3.Composite;

public class DirectorySys(string name) : FileSystemItem(name)
{
    private readonly List<FileSystemItem> _items = [];

    public void Add(FileSystemItem item)
    {
        _items.Add(item);
    }

    public void Remove(FileSystemItem item)
    {
        _items.Remove(item);
    }

    public override void Display(int depth)
    {
        Console.WriteLine(new string('-', depth) + Name);

        foreach (FileSystemItem? item in _items)
        {
            item.Display(depth + 1);
        }
    }
}
