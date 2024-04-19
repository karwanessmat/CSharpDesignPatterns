using AbstractFactory5Demo.Step1_Abstract_Products;

namespace AbstractFactory5Demo.Step2_Concrete_Products;

// Concrete Product for Light Theme
public class LightButton : IButton
{
    public void Render()
    {
        Console.WriteLine("Rendering a light-themed button.");
    }
}

