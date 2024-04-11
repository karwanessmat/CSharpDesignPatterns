using Iterator3Demo.Step1_Iterator_Interface.IteratorDesignPattern;
using Iterator3Demo.Step2_Concrete_Iterator;

namespace Iterator3Demo.Step3_Collection_Interface
{
   public interface IAbstractCollection
    {
        IAbstractIterator CreateIterator();
    }
}
