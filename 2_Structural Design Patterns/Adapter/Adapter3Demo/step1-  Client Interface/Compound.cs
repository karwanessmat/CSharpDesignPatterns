using System;

namespace Adapter3Demo.step1___Client_Interface;

/// <summary>
/// The 'Target' class
/// </summary>
public class Compound(string chemical)
{
    protected string Chemical = chemical;
    protected float BoilingPoint;
    protected float MeltingPoint;
    protected double MolecularWeight;
    protected string MolecularFormula;

    public virtual void Display()
    {
        Console.WriteLine("\nCompound: {0} ------ ", Chemical);
    }
}