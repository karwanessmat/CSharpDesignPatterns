using System;

namespace Adapter3Demo
{

    /// <summary>
    /// The 'Target' class
    /// </summary>
    class Compound
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

    /// <summary>
    /// The 'Adapter' class
    /// </summary>
    class RichCompound : Compound
    {
        private ChemicalDatabank _bank;
        public RichCompound(string chemical) : base(chemical)
        {
        }


        public override void Display()
        {
            // The Adaptee

            _bank = new ChemicalDatabank();

            BoilingPoint = _bank.GetCriticalPoint(Chemical, "B");
            MeltingPoint = _bank.GetCriticalPoint(Chemical, "M");
            MolecularWeight = _bank.GetMolecularWeight(Chemical);
            MolecularFormula = _bank.GetMolecularStructure(Chemical);

            base.Display();
            Console.WriteLine(" Formula: {0}", MolecularFormula);
            Console.WriteLine(" Weight : {0}", MolecularWeight);
            Console.WriteLine(" Melting Pt: {0}", MeltingPoint);
            Console.WriteLine(" Boiling Pt: {0}", BoilingPoint);
        }
    }

    /// <summary>
    /// The 'Adaptee' class
    /// </summary>
    class ChemicalDatabank
    {
        // The databank 'legacy API'
        public float GetCriticalPoint(string compound, string point)
        {
            // Melting Point
            if (point == "M")
            {
                return compound.ToLower() switch
                {
                    "water" => 0.0f,
                    "benzene" => 5.5f,
                    "ethanol" => -114.1f,
                    _ => 0f
                };
            } // Boiling Point

            return compound.ToLower() switch
            {
                "water" => 100.0f,
                "benzene" => 80.1f,
                "ethanol" => 78.3f,
                _ => 0f
            };
        }

        public string GetMolecularStructure(string compound)
        {
            return compound.ToLower() switch
            {
                "water" => "H20",
                "benzene" => "C6H6",
                "ethanol" => "C2H5OH",
                _ => ""
            };
        }

        public double GetMolecularWeight(string compound)
        {
            return compound.ToLower() switch
            {
                "water" => 18.015,
                "benzene" => 78.1134,
                "ethanol" => 46.0688,
                _ => 0d
            };
        }
    }

}



