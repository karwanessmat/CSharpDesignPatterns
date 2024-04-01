using Factory6Demo.Models;
using Factory6Demo.Product;

namespace Factory6Demo.Creator_Factories
{
    public abstract class ProcessFactory
    {
        public abstract IProcessor CreateProcessor(string exchangeName, float volume);

        public abstract double CalculateInterest();

        public IProcessor GetProcessor(string exchangeName, float volume)
        {
            var processor = CreateProcessor(exchangeName, volume);
            if (CalculateInterest()<199)
            {
                processor.Risk = Risk.Low;
            }


            return processor;
        }
    }
}
