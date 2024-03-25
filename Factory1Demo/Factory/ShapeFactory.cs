using Factory1Demo.Factory.ConcreteClass;

namespace Factory1Demo.Factory
{
  public  class ShapeFactory
    {
        public IShape GetShape(string shapeType)
        {
            if (string.IsNullOrWhiteSpace(shapeType))
            {
                return null;
            }

            return shapeType.ToLower() switch
            {
                "rectangle" => new Rectangle(),
                "circle" => new Circle(),
                "square" => new Square(),
                _ => null
            };
        }
    }
}
