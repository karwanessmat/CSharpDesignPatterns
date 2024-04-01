using Factory2Demo.Concretes;
using Factory2Demo.Creator;

namespace Factory2Demo.ConcreteCreator
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
