using Factory6Demo.Models;

namespace Factory6Demo.Product
{
    public interface IProcessor
    {
        List<double> Predict();
        Risk Risk { get; set; }

    }
}
