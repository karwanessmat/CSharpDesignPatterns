namespace Iterator3Demo
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
