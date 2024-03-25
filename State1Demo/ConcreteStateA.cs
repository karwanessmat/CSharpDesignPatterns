namespace State1Demo
{
    public class ConcreteStateA:State
    {
        public override void Handler(Context context)
        {
            context.State = new ConcreteStateB();
        }
    }
}
