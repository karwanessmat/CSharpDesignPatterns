using Decorator3Demo._1_Component_Interface;

namespace Decorator3Demo._3__Create_an_Abstract_Decorator
{

    /// <summary>
    /// The 'Decorator' abstract class
    /// </summary>
    public class LibraryDecorator(LibraryItem libraryItem) : LibraryItem
    {
        protected LibraryItem LibraryItem = libraryItem;

        public override void Display()
        {
           LibraryItem.Display();
        }
    }
}
