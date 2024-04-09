namespace Mediator1Demo.Colleague
{
    /// <summary>
    /// The 'Colleague' abstract class
    /// </summary>
    public abstract class Colleague(Mediator.Mediator mediator)
    {
        protected Mediator.Mediator Mediator = mediator;

        // Constructor
    }
}
