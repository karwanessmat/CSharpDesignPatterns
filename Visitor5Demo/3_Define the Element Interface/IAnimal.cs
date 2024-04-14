using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor5Demo._1_Visitor_Interface;

namespace Visitor5Demo._3_Define_the_Element_Interface;

public interface IAnimal
{
    void Accept(IAnimalVisitor visitor);
}
