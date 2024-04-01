using Factory3Demo.Concretes;
using Factory3Demo.Creator;

namespace Factory3Demo.ConcreteFactory
{
    public class WindowsPlayerCreator:PlayerCreator
    {
        public override Player CreatePlayer()
        {
            return new WindowsPlayer();
        }
    }
}
