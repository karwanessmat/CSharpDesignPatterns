using System.Collections.Generic;
using Flyweight2Demo.ConcreteFlyweight;
using Flyweight2Demo.Flyweight_Interface;

namespace Flyweight2Demo.FlyweightFactory
{

    /// <summary>
    /// Flyweight Factory
    /// </summary>
    internal class ShapeObjectFactory
    {
        private readonly Dictionary<string,IShape> _shapes=new Dictionary<string, IShape>();

        public int TotalObjectsCreated => _shapes.Count;

        public IShape GetShape(string shapeName)
        {
            shapeName = shapeName.ToLower().Trim();
            IShape shape = null;
            if (_shapes.ContainsKey(shapeName))
            {
                shape = _shapes[shapeName];
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
