namespace Builder5Demo.Step1_Production
{
    public class Vehicle
    {
        public string Type { get; set; }
        public int Wheels { get; set; }
        public string Engine { get; set; }
        public string Color { get; set; }


        public override string ToString()
        {
            return $"{Type} with {Wheels} wheels, Engine: {Engine}, Color: {Color}";
        }
    }
}
