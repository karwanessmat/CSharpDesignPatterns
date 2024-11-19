namespace Composite4Demo._1._Component;
    public abstract class FileSystemItem(string name)
    {
        public string Name { get; protected set; } = name;
        public abstract void Display(int depth);
    }

