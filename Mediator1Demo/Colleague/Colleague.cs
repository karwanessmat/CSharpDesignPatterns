namespace Mediator1Demo.Colleague
{
    /// <summary>
    /// The 'Colleague' abstract class
    /// </summary>
    public abstract class Colleague

    {
        protected Mediator.Mediator Mediator;

        // Constructor
        protected Colleague(Mediator.Mediator mediator)
        {
            this.Mediator = mediator;
        }
    }
}
