﻿using System;
using Adapter3Demo.step1___Client_Interface;
using Adapter3Demo.Step3__Adaptee;

namespace Adapter3Demo.step2_Adapter_Class;

/// <summary>
/// The 'Adapter' class
/// </summary>
internal class RichCompound(string chemical) : Compound(chemical)
{

    // The Adaptee
    private readonly ChemicalDataBank _bank = new();
    
    
    public override void Display()
    {
        
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