using AbstractFactory5Demo.Step1_Abstract_Products;
using AbstractFactory5Demo.Step3_Abstract_Factories;

namespace AbstractFactory5Demo.Step5_Client
{
    public class Application(IThemeFactory themeFactory)
    {
        
        public void Render()
        {
            IButton button = themeFactory.CreateButton();
            ITextBox textBox = themeFactory.CreateTextBox();

            button.Render();
            textBox.Render();
        }
    }
}
