using Factory1Demo.Step1_Product_Interface;
using Factory1Demo.Step2__Create_Concretes;
using Factory1Demo.Step3_Creator_abstract;

namespace Factory1Demo.Factory
{
  public  class ShapeFactory: CreatorShapeFactory
    {
        public override IShape GetShape(string shapeType)
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
