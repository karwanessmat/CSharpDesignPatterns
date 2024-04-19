using Mediator2Demo._03_DefineComponentBaseClass;

namespace Mediator2Demo._01_DefineMediatorInterface
{

    public interface ICharRoom
    {
        public  void Register(Participant participant);
        public  void Send(string from, string to, string message);
    }

    //internal abstract class IChatRoom
    //{
    //    /// <summary>
    //    /// Participant is abstract Colleague
    //    /// </summary>
    //    /// <param name="participant"></param>
    //    public abstract void Register(Participant participant);
    //    public abstract void SendTo(string from, string to, string message);
    //}
}
