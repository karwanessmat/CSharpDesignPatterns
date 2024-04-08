namespace Facade4Demo.Entities
{
    public class City
    {
        public City GetCityForZipCode(string zipCode)
        {
            // service or db lookup would go here
            return new City();
        }

        public string Name => "Redmond";
    }
}