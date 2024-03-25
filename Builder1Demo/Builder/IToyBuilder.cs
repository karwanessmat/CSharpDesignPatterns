using Builder1Demo.Product;

namespace Builder1Demo.Builder
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
