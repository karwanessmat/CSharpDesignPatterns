using Composite4Demo._1._Component;

namespace Composite4Demo._2._Leaf;

public class FileSystem(string name):FileSystemItem(name)
{
    public override void Display(int depth)
    {
        Console.WriteLine(new string('-', depth) + Name);
    }
}