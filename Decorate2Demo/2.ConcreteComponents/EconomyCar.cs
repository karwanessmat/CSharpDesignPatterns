using Decorator2Demo._1.Component;

namespace Decorator2Demo._2.ConcreteComponents
{

    /// <summary>
    /// Concrete Component
    /// </summary>
  public  class EconomyCar:ICar
    {
        public string GetDescription()
        {
            return "Economy Car";
        }

        public double GetCost()
        {
            return 450000.0;
        }
    }
}
