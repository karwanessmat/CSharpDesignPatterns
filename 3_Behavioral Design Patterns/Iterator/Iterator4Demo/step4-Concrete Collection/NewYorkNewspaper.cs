using Iterator4Demo.Step1_Iterator_Interface;
using Iterator4Demo.Step2_Concrete_Iterator;
using Iterator4Demo.Step3_Collection_Interface;

namespace Iterator4Demo.step4_Concrete_Collection;

// concrete aggregate
public class NewYorkNewspaper:INewspaper
{
    private readonly string[] _reporters =
    [
        "Sahand - NY",
        "Derin - NY",
        "Asa - NY",
        "Lisa - NY"
    ];
    public IIterator CreateIterator()
    {
        return new NewYorkNewspaperIterator(_reporters);
    }
}