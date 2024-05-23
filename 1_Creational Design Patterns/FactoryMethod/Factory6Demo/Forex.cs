using Factory6Demo.Models;
using Factory6Demo.Step3_Creator;

namespace Factory6Demo;

public class Forex(Exchange exchange, ProcessFactory processFactory)
{
    public List<double> GetForecastData()
    {
        var processor = processFactory.GetProcessor(exchange.Name, exchange.Volume_1day_usd);

        return processor.Predict();
    }
}