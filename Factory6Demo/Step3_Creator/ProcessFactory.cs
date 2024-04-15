using Factory6Demo.Models;
using Factory6Demo.Step1_Product_Interface;

namespace Factory6Demo.Step3_Creator
{
    public abstract class ProcessFactory
    {
        public abstract IProcessor CreateProcessor(string exchangeName, float volume);// it has own logic

        public abstract double CalculateInterest(); // it has own logic


        /// <summary>
        /// it can be invoked without implementing  
        /// </summary>
        /// <param name="exchangeName"></param>
        /// <param name="volume"></param>
        /// <returns></returns>
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
