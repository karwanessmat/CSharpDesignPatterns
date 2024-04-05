using Builder2Demo.step1_Product;
using Builder2Demo.step2_Builder;

namespace Builder2Demo.step4_Director
{
   public class VehicleCreator(IVehicleBuilder vehicleBuilder)
   {


       public void BuildVehicle()
       {
           vehicleBuilder.SetModel();
           vehicleBuilder.SetEngine();
           vehicleBuilder.SetBody();
           vehicleBuilder.SetAccessories();
       }

       public Vehicle GetVehicle()
       {
           return vehicleBuilder.Vehicle();
       }
   }
}
