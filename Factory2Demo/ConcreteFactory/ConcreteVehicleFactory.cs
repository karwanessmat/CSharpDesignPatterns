using Factory2Demo.Concretes;

namespace Factory2Demo.ConcreteFactory
{
  public  class ConcreteVehicleFactory:CreatorVehicleFactory
    {
        public override IVehicle GetVehicle(VehicleType vehicleType)
        {
            return vehicleType switch
            {
                VehicleType.Bike => new Bike(),
                _ => new Scooter()
            };
        }
    }
}
