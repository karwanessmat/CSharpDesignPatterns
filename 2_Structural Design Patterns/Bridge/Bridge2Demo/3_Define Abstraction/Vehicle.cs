using Bridge2Demo._1_Define_Implementor_Interface;

namespace Bridge2Demo._3_Define_Abstraction
{
    // abstraction in bridge pattern 
    public abstract class Vehicle(IWorkshop workShop1, IWorkshop workShop2)
    {
        /// <summary>
        /// they are bridges
        /// </summary>
        protected IWorkshop Workshop1 = workShop1;
        protected IWorkshop Workshop2 = workShop2;
        public abstract void Manufacture();
    }
}
