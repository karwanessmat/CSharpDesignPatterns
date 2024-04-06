using System;

namespace Adapter3Demo
{

    /// <summary>
    /// The 'Target' class
    /// </summary>
    public class Compound
    {
        protected string Chemical;
        protected float BoilingPoint;
        protected float MeltingPoint;
        protected double MolecularWeight;
        protected string MolecularFormula;

        public Compound(string chemical)
        {
            Chemical = chemical;
        }

        public virtual void Display()
        {
            Console.WriteLine("\nCompound: {0} ------ ", Chemical);
        }
    }
}



