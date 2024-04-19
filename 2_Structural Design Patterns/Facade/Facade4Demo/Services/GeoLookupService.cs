using Facade4Demo.Entities;

namespace Facade4Demo.Services
{
    public class GeoLookupService
    {
        public City GetCityForZipCode(string zipCode)
        {
            // a lookup would occur here
            return new City();
        }
        
        public State GetStateForZipCode(string zipCode)
        {
            // a lookup would occur here
            return new State();
        }

        public City GetCityForCoordinates(double longitude, double latitude)
        {
            // a lookup would occur here
            return new City();
        }
        
        public City GetStateByCapital(string capital)
        {
            // a lookup would occur here
            return new City();
        }
    }
}