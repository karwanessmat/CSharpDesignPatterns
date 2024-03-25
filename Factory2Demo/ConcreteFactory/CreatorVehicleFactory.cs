namespace Factory2Demo.ConcreteFactory
{

    // abstract class creator 
   public abstract class CreatorVehicleFactory
   {
       public abstract IVehicle GetVehicle(VehicleType vehicleType);
   }
}
