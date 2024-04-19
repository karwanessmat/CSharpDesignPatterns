namespace Iterator3Demo.Step1_Iterator_Interface
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
