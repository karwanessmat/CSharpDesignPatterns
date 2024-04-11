using Mediator1Demo._01_DefineMediatorInterface;
using Mediator1Demo._03_DefineComponentBaseClass;
using Mediator1Demo._04_CreateConcreteComponents;

namespace Mediator1Demo._02_CreateConcreteMediator
{
    /// <summary>
    /// The 'ConcreteMediator' class
    /// </summary>
    internal class ConcreteMediator : Mediator

    {
        private ConcreteColleague1 _colleague1;
        private ConcreteColleague2 _colleague2;

        public ConcreteColleague1 Colleague1
        {
            set => _colleague1 = value;
        }

        public ConcreteColleague2 Colleague2
        {
            set => _colleague2 = value;
        }

        public override void Send(string message, Colleague colleague)
        {
            if (colleague == _colleague1)
            {
                _colleague2.Notify(message);
            }
            else

            {
                _colleague1.Notify(message);
            }
        }
    }
}
