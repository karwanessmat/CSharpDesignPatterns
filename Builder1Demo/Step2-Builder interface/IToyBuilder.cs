using Builder1Demo.step1_Product;

namespace Builder1Demo.Step2_Builder
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
