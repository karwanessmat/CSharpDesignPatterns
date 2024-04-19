using AbstractFactory5Demo.Step1_Abstract_Products;

namespace AbstractFactory5Demo.Step3_Abstract_Factories;

// Abstract Factory Interface for UI themes
public interface IThemeFactory
{
    IButton CreateButton();
    ITextBox CreateTextBox();
}