using State4Demo._1_CreateStateInterface;

namespace State4Demo._2_ImplementConcreteStates;

internal class UnlockedScreenState : IMobilePhoneState
{
    public void PressHomeButton()
    {
        Console.WriteLine("Home screen has been opened.");
    }
}