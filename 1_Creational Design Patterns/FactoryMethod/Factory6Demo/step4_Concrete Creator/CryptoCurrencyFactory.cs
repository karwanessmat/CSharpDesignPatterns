using Factory6Demo.Models;
using Factory6Demo.Step1_Product_Interface;
using Factory6Demo.Step2_Product_Concretes;
using Factory6Demo.Step3_Creator;

namespace Factory6Demo.step4_Concrete_Creator
{
    public class CryptoCurrencyFactory:ProcessFactory
    {
        public override IProcessor CreateProcessor(string exchangeName, float volume)
        {
           
            IProcessor processor = exchangeName switch
            {
                "BTC" => new BitcoinProcessor(Risk.High, volume),
                "ETH" => new EthereumProcessor(Risk.Medium, volume),
                _ => throw new NotImplementedException("Exchange unknown")
            };

            return processor;
        }

        public override double CalculateInterest()
        {
            return 100;
        }
    }
}
