using Mediator5Demo._03_DefineComponentBaseClass;

namespace Mediator5Demo._04_CreateConcreteComponents
{
    public class Tester(string name) :TeamMember(name)
    {
        public override void Receive(string from, string message)
        {
            Console.Write($"{this.Name} ({nameof(Tester)}) has received: ");
            base.Receive(from, message);
        }
    }
}
