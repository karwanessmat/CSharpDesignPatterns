using State4Demo._1_CreateStateInterface;

namespace State4Demo._2_ImplementConcreteStates;

internal class LockedScreenState : IMobilePhoneState
{
    public void PressHomeButton()
    {
        Console.WriteLine("Please enter screen unlock PIN.");
    }
}