using System.Collections.Generic;
using Flyweight2Demo._1_Flyweight_Interface;
using Flyweight2Demo._2__Concrete_Flyweight;

namespace Flyweight2Demo._3_Flyweight_Factory
{

    /// <summary>
    /// Flyweight Factory
    /// </summary>
    internal class ShapeObjectFactory
    {
        private readonly Dictionary<string,IShape> _shapes=new();

        public int TotalObjectsCreated => _shapes.Count;

        public IShape GetShape(string shapeName)
        {
            shapeName = shapeName.ToLower().Trim();
            IShape shape = null;
            if (_shapes.TryGetValue(shapeName, out var shapeValue))
            {
                shape = shapeValue;
            }
            else
            {
                switch (shapeName)
                {
                    case "rectangle":
                        shape =new Rectangle();
                        _shapes.Add("rectangle", shape);
                        break;
                    case "circle":
                        shape = new Circle();
                        _shapes.Add("circle", shape);
                        break;
                }
            }
            return shape;
        }

    }
}
