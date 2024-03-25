using Builder2Demo.Builder;
using Builder2Demo.Product;

namespace Builder2Demo.Director
{
   public class VehicleCreator
   {
       private readonly IVehicleBuilder _vehicleBuilder;

       public VehicleCreator(IVehicleBuilder vehicleBuilder)
       {
           _vehicleBuilder = vehicleBuilder;
       }

       public void BuildVehicle()
       {
           _vehicleBuilder.SetModel();
           _vehicleBuilder.SetEngine();
           _vehicleBuilder.SetBody();
           _vehicleBuilder.SetAccessories();
       }

       public Vehicle GetVehicle()
       {
           return _vehicleBuilder.Vehicle();
       }
   }
}
