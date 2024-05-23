namespace Template2Demo.AbstractClass;

public abstract class DataAccessor
{
    public abstract void Connect();
    public abstract void Select();
    public abstract void Process(int top);
    public abstract void Select(string name);
    public abstract void Disconnect();

    // The Template Methods;
    public void Run(int top)
    {
        // perform 4 methods
        Connect();
        Select();
        Process(top);
        Disconnect();
    }

    public void Run(int top,string name)
    {
        // perform 5 methods
        Connect();
        Select();
        Process(top);
        Select(name); // included
        Disconnect();
    }
}