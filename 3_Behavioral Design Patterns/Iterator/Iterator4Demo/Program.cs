using Iterator4Demo.Step1_Iterator_Interface;
using Iterator4Demo.Step3_Collection_Interface;
using Iterator4Demo.step4_Concrete_Collection;

INewspaper losAngelesNewspaper = new LosAngelesNewspaper();
INewspaper newYorkNewPaper =new NewYorkNewspaper();

IIterator losAngelesNewspaperIterator = losAngelesNewspaper.CreateIterator();
IIterator newYorkNewPaperIterator = newYorkNewPaper.CreateIterator();

Console.WriteLine("New York Reporters");
PrintReporters(losAngelesNewspaperIterator);

Console.WriteLine();
Console.WriteLine("Los Angeles Reporters");
PrintReporters(newYorkNewPaperIterator);

Console.WriteLine();
Console.WriteLine();


return;

static void PrintReporters(IIterator iterator)
{
    iterator.First();
    while (!iterator.IsDone())
    {
        string? item = iterator.Next();
        Console.WriteLine(item);
    }

    // We can also use
    //while (iterator.HasNext())
    //{
    //    var item = iterator.Next();
    //    Console.WriteLine(item);
    //}

}