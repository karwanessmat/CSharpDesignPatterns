using AbstractFactory5Demo.Step1_Abstract_Products;

namespace AbstractFactory5Demo.Step2_Concrete_Products;

public class DarkTextBox : ITextBox
{
    public void Render()
    {
        Console.WriteLine("Rendering a dark-themed text box.");
    }
}