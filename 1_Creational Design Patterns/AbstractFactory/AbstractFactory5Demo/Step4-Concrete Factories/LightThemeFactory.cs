using AbstractFactory5Demo.Step1_Abstract_Products;
using AbstractFactory5Demo.Step2_Concrete_Products;
using AbstractFactory5Demo.Step3_Abstract_Factories;

namespace AbstractFactory5Demo.Step4_Concrete_Factories;

public class LightThemeFactory:IThemeFactory
{
    public IButton CreateButton()
    {
        return new LightButton();
    }

    public ITextBox CreateTextBox()
    {
        return new LightTextBox();
    }
}