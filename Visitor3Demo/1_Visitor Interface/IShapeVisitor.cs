using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor3Demo._4__Implement_Concrete_Elements;

namespace Visitor3Demo._1_Visitor_Interface;
public interface IShapeVisitor
{
    void VisitCircle(Circle circle);
    void VisitRectangle(Rectangle rectangle);
    void VisitLine(Line line);
}
