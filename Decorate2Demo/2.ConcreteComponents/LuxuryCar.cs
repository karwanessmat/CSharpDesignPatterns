using Decorator2Demo._1.Component;

namespace Decorator2Demo._2.ConcreteComponents
{
    class LuxuryCar:ICar
    {
        public string GetDescription()
        {
            return "Luxury Car";
        }

        public double GetCost()
        {
            return 1000 - 000.0;
        }
    }
}
