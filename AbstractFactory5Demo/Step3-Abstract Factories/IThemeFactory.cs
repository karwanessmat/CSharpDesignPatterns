using AbstractFactory5Demo.Step1_Abstract_Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory5Demo.Step3_Abstract_Factories;

// Abstract Factory Interface for UI themes
public interface IThemeFactory
{
    IButton CreateButton();
    ITextBox CreateTextBox();
}