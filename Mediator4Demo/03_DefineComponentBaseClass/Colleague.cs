using Mediator4Demo._01_DefineMediatorInterface;

namespace Mediator4Demo._03_DefineComponentBaseClass
{
    public abstract class Colleague()
    {
        protected Mediator? Mediator;

        //public Colleague(Mediator mediator)
        //{
        //    this.mediator = mediator;
        //}

        public void SetMediator(Mediator mediator)
        {
            Mediator = mediator;
        }

        public void SendTo(string message)
        {
            Mediator.Send(message, this);
        }

        public abstract void HandleNotification(string message);



    }
}
