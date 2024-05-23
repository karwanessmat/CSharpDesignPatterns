using Factory6Demo.Models;
using Factory6Demo.Step1_Product_Interface;
using Factory6Demo.Step3_Creator;

namespace Factory6Demo;

public class Forex(Exchange exchange, ProcessFactory processFactory)
{
    public List<double> GetForecastData()
    {
        IProcessor? processor = processFactory.GetProcessor(exchange.Name, exchange.Volume_1day_usd);

        return processor.Predict();
    }
}