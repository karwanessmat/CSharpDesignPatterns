using State1Demo._3_ContextClass;

namespace State1Demo._1_CreateStateInterface;

/// <summary>
/// the 'State' abstract class
/// </summary>
public abstract class State
{
    public abstract void Handler(Context context);
}