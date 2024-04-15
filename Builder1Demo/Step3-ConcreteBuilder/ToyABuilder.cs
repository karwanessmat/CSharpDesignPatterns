using Builder1Demo.step1_Product;
using Builder1Demo.Step2_Builder_interface;

namespace Builder1Demo.Step3_ConcreteBuilder
{
   public class ToyABuilder:IToyBuilder
    {
        private readonly Toy _toy = new();
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
