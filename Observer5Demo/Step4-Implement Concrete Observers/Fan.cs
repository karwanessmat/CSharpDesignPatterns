using Observer5Demo.Step1_Define_Observer_Interface;
using Observer5Demo.Step2_Define_Subject_Interface;

namespace Observer5Demo.Step4_Implement_Concrete_Observers;


public class Fan : IFan
{
    public void Update(ICelebrity celebrity)
    {
        Console.WriteLine($"Fan notified. Tweet of {celebrity.FullName}: " +
                          $"{celebrity.Tweet}");
    }
}