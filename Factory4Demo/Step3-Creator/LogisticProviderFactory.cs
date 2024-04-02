using Factory4Demo.Step1_Product;

namespace Factory4Demo.Step3_Creator
{
    /// <summary>
    /// 2. Add an empty factory method inside the creator class.
    /// The return type of the method should match the common product interface
    ///
    /// The Creator class declares the factory method that returns new product objects.
    /// It’s important that the return type of this method matches the product
    /// interface. You can declare the factory method as abstract to force all
    /// subclasses to implement their own versions of the method.
    /// As an alternative, the base factory method can return
    /// some default product type.
    /// </summary>
    public abstract class LogisticProviderFactory
    {
        /// <summary>
        /// declare a factory method 
        /// </summary>
        /// <returns></returns>
        public abstract ITransport CreateTransport();

        public void PlanDelivery()
        {
            var transport = CreateTransport();
            transport.Deliver();
        }
    }
}
