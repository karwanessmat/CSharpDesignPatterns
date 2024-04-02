using Factory6Demo.Models;

namespace Factory6Demo.Step1_Product
{
    public interface IProcessor
    {
        List<double> Predict();
        Risk Risk { get; set; }

    }
}
