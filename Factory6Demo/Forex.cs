using Factory6Demo.Models;
using Factory6Demo.Step3_Creator;

namespace Factory6Demo
{
    public class Forex
    {
        private Exchange _exchange;
        private ProcessFactory _processFactory;
        public Forex(Exchange exchange, ProcessFactory processFactory)
        {
            _exchange = exchange;
            _processFactory = processFactory;
        }

        public List<double> GetForecastData()
        {
            var processor = _processFactory.GetProcessor(_exchange.Name, _exchange.Volume_1day_usd);

            return processor.Predict();
        }
    }
}
