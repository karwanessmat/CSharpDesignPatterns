using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade3Demo;
    public class LightingControl
    {
        public void TurnOnLights()
        {
            Console.WriteLine("Lights turned on");
        }

        public void TurnOffLights()
        {
            Console.WriteLine("Lights turned off");
        }
    }