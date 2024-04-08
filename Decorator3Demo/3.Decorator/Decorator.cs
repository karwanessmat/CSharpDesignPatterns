using Decorator3Demo._1.Component;

namespace Decorator3Demo._3.Decorator
{

    /// <summary>
    /// The 'Decorator' abstract class
    /// </summary>
    public class Decorator(LibraryItem libraryItem) : LibraryItem
    {
        protected LibraryItem LibraryItem = libraryItem;

        public override void Display()
        {
           LibraryItem.Display();
        }
    }
}
