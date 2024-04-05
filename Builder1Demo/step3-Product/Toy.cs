
namespace Builder1Demo.Product
{
   public class Toy
    {
        public string Model { get; set; }
        public string Head { get; set; }
        public string Body { get; set; }
        public string Legs { get; set; }

        public override string ToString()
        {
            return $"Model {Model} \nHead: {Head}\nBody: {Body}\nLegs: {Legs}";
        }
    }
}
