using Iterator4Demo.Step1_Iterator_Interface;
using Iterator4Demo.Step2_Concrete_Iterator;
using Iterator4Demo.Step3_Collection_Interface;

namespace Iterator4Demo.step4_Concrete_Collection;

// concrete aggregate
public class LosAngelesNewspaper:INewspaper
{
    private readonly string[] _reporters =
    [
        "Karwan - LA",
        "Nishtiman - LA",
        "Baran - LA",
        "Lewan - LA",
        "Lelan - LA"
    ];

    public IIterator CreateIterator()
    {
        return new LosAngelesNewspaperIterator(_reporters);
    }
}