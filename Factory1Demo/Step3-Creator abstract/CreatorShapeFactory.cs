using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory1Demo.Step1_Product_Interface;

namespace Factory1Demo.Step3_Creator_abstract
{
    public abstract class CreatorShapeFactory
    {
        public abstract IShape GetShape(string shapeType);
    }

}
