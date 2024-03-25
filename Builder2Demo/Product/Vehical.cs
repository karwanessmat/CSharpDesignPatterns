using System.Collections.Generic;

namespace Builder2Demo.Product
{
    public class Vehicle
    {
        public string Model { get; set; }
        public string Engine { get; set; }
        public string Body { get; set; }

        public List<string> Accessors { get; set; }

        public Vehicle()
        {
            Accessors = new List<string>();
        }


        public override string ToString()
        {
            return $"Model {Model}\n" +
                   $"Engine: {Engine}\n" +
                   $"Body {Body}\n" +
                   $"Accessors: {string.Join(',', Accessors)}";

        }
    }
}
