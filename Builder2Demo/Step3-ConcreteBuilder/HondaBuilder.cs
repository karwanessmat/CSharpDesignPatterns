using System.Collections.Generic;
using Builder2Demo.step1_Product;
using Builder2Demo.step2_Builder;

namespace Builder2Demo.Step3_ConcreteBuilder
{
    internal class HondaBuilder:IVehicleBuilder
    {
        private readonly Vehicle _vehicle = new Vehicle();
        public void SetModel()
        {
            _vehicle.Model = "Honda Mode";
        }

        public void SetEngine()
        {
            _vehicle.Engine = "Honda Engine";
        }

        public void SetBody()
        {
            _vehicle.Body = "Honda Body";
        }

        public void SetAccessories()
        {
            var accessorList = new List<string>() { "2 Wheels", "just one keys", "Radio","Red Color","double full light" };
            _vehicle.Accessors = accessorList;
        }

        public Vehicle Vehicle()
        {
            return _vehicle;
        }
    }
}
