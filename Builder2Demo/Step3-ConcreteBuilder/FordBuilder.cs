using System.Collections.Generic;
using Builder2Demo.step1_Product;
using Builder2Demo.step2_Builder;

namespace Builder2Demo.Step3_ConcreteBuilder
{
    internal class FordBuilder:IVehicleBuilder
    {
        private readonly Vehicle _vehicle = new Vehicle();
        public void SetModel()
        {
            _vehicle.Model = "Hero Mode";
        }

        public void SetEngine()
        {
            _vehicle.Engine = "Hero Engine";
        }

        public void SetBody()
        {
            _vehicle.Body = "Hero Body";
        }

        public void SetAccessories()
        {
            var accessorList = new List<string>(){"4 Wheels","double keys","TV"};
            _vehicle.Accessors = accessorList;
        }

        public Vehicle Vehicle()
        {
            return _vehicle;
        }
    }
}
