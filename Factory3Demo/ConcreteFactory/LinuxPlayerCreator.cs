using Factory3Demo.Concretes;
using Factory3Demo.Creator;

namespace Factory3Demo.ConcreteFactory
{
    internal class LinuxPlayerCreator:PlayerCreator
    {
        public override Player CreatePlayer()
        {
            return new LinuxPlayer();
        }
    }
}
