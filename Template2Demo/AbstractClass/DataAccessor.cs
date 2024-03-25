namespace Template2Demo.AbstractClass
{
   public abstract class DataAccessor
   {
       public abstract void Connect();
       public abstract void Select();
       public abstract void Process(int top);
       public abstract void Select(string name);
       public abstract void Disconnect();

       // The Template Method();
       public void Run(int top)
       {
           Connect();
           Select();
           Process(top);
           Disconnect();
       }

       public void Run(int top,string name)
       {
           Connect();
           Select();
           Process(top);
           Select(name);
           Disconnect();
       }
    }
}
