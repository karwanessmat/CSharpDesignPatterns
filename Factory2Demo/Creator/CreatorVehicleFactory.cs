namespace Factory2Demo.Creator
{

    // abstract class creator 
   public abstract class CreatorVehicleFactory
   {
       public abstract IVehicle GetVehicle(VehicleType vehicleType);
   }
}
