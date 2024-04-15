using Factory6Demo.Models;

namespace Factory6Demo.Step1_Product_Interface
{
    public interface IProcessor
    {
        List<double> Predict();
        Risk Risk { get; set; }

    }
}
