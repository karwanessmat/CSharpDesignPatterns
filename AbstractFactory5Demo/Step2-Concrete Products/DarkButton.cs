using AbstractFactory5Demo.Step1_Abstract_Products;

namespace AbstractFactory5Demo.Step2_Concrete_Products;
// Concrete Product for Dark Theme
public class DarkButton : IButton
{
    public void Render()
    {
        Console.WriteLine("Rendering a dark-themed button.");
    }
}