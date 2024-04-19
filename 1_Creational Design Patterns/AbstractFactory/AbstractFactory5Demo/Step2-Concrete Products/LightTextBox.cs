using AbstractFactory5Demo.Step1_Abstract_Products;

namespace AbstractFactory5Demo.Step2_Concrete_Products;

public class LightTextBox : ITextBox
{
    public void Render()
    {
        Console.WriteLine("Rendering a light-themed text box.");
    }
}