using AbstractFactory5Demo.Step1_Abstract_Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory5Demo.Step2_Concrete_Products;

// Concrete Product for Light Theme
public class LightButton : IButton
{
    public void Render()
    {
        Console.WriteLine("Rendering a light-themed button.");
    }
}

