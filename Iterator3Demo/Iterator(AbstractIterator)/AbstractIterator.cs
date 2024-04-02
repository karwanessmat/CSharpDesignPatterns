namespace Iterator3Demo.Iterator_AbstractIterator_
{
namespace IteratorDesignPattern
{
   public interface IAbstractIterator
    {
        Employee First();
        Employee Next();
        bool IsCompleted { get; }
    }
}
}
