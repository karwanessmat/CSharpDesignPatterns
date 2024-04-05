using Builder1Demo.Product;

namespace Builder1Demo.Step1_Builder
{
    public interface IToyBuilder
    {
        void SetModel();
        void SetHead();
        void Body();
        void Legs();

        Toy Toy();
    }
}
