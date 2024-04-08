using Decorator1Demo.Component;

namespace Decorator1Demo.Decorator
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
