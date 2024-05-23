namespace Decorator3Demo._1_Component_Interface;

/// <summary>
/// The 'Component' abstract class
/// </summary>
public  abstract class LibraryItem
{
    public int NumCopies { get; set; }


    public abstract void Display();
}