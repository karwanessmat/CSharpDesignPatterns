using System.Collections;

namespace Flyweight1Demo
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
