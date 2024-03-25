namespace Mediator1Demo.Mediator
{

    /// <summary>
    /// The 'Mediator' abstract class
    /// </summary>
    public abstract class Mediator
    {
        public abstract void Send(string message, Colleague.Colleague colleague);
    }

}
