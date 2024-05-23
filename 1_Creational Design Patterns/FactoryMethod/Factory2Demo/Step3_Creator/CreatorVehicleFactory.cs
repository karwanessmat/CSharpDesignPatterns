using Factory2Demo.Step1_Product_Interface;

namespace Factory2Demo.Step3_Creator;

// abstract class creator 
public abstract class CreatorVehicleFactory
{
    public abstract IVehicle GetVehicle(VehicleType vehicleType);
}