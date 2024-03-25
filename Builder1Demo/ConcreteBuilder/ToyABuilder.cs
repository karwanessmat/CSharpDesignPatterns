using Builder1Demo.Builder;
using Builder1Demo.Product;

namespace Builder1Demo.ConcreteBuilder
{
   public class ToyABuilder:IToyBuilder
    {
        private readonly Toy _toy = new Toy();
        public void SetModel()
        {
            _toy.Model = "A Model";
        }

        public void SetHead()
        {
            _toy.Head = "A Head";
        }

        public void Body()
        {
            _toy.Body = "A Steel";
        }

        public void Legs()
        {
            _toy.Legs = "4 Legs";
        }

        public Toy Toy()
        {
            return _toy;
        }
    }
}
