using Decorator2Demo._1.Component;

namespace Decorator2Demo._2.ConcreteComponents
{

    /// <summary>
    /// Concrete Component
    /// </summary>
    public class DeluxCar:ICar
    {
        public string GetDescription()
        {
            return "Delux Car";
        }

        public double GetCost()
        {
            return 750000.0;
        }
    }
}
