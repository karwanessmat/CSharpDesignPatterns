using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor3Demo._1_Visitor_Interface;

namespace Visitor3Demo._3_Define_the_Element_Interface;

public interface IShape
{
    void Accept(IShapeVisitor visitor);
}
