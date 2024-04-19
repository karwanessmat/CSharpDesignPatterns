using System.Collections;
using Flyweight1Demo._1_Flyweight_Interface;
using Flyweight1Demo._2__Concrete_Flyweight;

namespace Flyweight1Demo._3_Flyweight_Factory
{
   public class FlyweightFactory
    {
        private readonly Hashtable _flyweights=new Hashtable();

        public IFlyweight GetFlyweight(string key)
        {
            if (_flyweights.Contains(key))
            {
                return _flyweights[key] as IFlyweight;
            }

            var newFlyweight = new ConcreteFlyweight();

            // set properties of new flyweight here.
            _flyweights.Add(key,newFlyweight);
            return newFlyweight;
        }
    }
}
