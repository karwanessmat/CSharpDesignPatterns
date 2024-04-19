using Factory2Demo.Step1_Product_Interface;
using Factory2Demo.Step2_Product_Concretes;
using Factory2Demo.Step3_Creator;

namespace Factory2Demo.step4_Concrete_Creator
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
