using Builder3Demo.Step1_Product;

namespace Builder3Demo.Step2_Builder_Interface
{
    public interface IBuilder
    {
        void BuildPartA();
        void BuildPartB();

        // it can be directly set in concrete builder without definition inside IBuilder
        Product GetProduct();
    }
}
