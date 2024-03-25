namespace State1Demo
{
    public class ConcreteStateB:State
    {
        public override void Handler(Context context)
        {
            context.State = new ConcreteStateA();
        }
    }
}
