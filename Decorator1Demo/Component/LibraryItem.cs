namespace Decorator1Demo.Component
{
    /// <summary>
    /// The 'Component' abstract class
    /// </summary>
  public  abstract class LibraryItem
    {
        public int NumCopies { get; set; }


        public abstract void Display();
    }
}
