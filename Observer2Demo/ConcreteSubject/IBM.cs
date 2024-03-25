
using Observer2Demo.Subject;

namespace Observer2Demo.ConcreteSubject
{
    public class IBM : Stock
    {

        public IBM(string symbol, double price)
            : base(symbol, price)
        {
        }
    }
}
