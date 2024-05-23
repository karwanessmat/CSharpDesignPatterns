using State1Demo._1_CreateStateInterface;
using State1Demo._3_ContextClass;

namespace State1Demo._2_ImplementConcreteStates;

public class ConcreteStateA:State
{
    public override void Handler(Context context)
    {
        context.State = new ConcreteStateB();
    }
}