using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory6Demo.Creator_Factories;
using Factory6Demo.Models;
using Factory6Demo.Processors_ConcreteProduct;
using Factory6Demo.Product;

namespace Factory6Demo.Factory_Product__ConcreteCreator
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
