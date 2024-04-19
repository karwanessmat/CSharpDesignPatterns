using State4Demo._1_CreateStateInterface;
using State4Demo._2_ImplementConcreteStates;

namespace State4Demo._3_ContextClass;

internal class MobilePhoneContext
{
    private IMobilePhoneState _state = new LockedScreenState();

    public void ChangeState(IMobilePhoneState state)
    {
        _state = state;
    }

    public void PressHomeButton()
    {
        _state.PressHomeButton();
    }
}