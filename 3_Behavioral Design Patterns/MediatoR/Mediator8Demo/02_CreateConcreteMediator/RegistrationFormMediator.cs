using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mediator8Demo._01_DefineMediatorInterface;
using Mediator8Demo._04_CreateConcreteComponents;

namespace Mediator8Demo._02_CreateConcreteMediator;
public class RegistrationFormMediator : IMediator
{
    public TextBox nameTextBox;
    public TextBox emailTextBox;
    public TextBox passwordTextBox;
    public Checkbox termsCheckbox;
    public Checkbox newsletterCheckbox;
    public Button registerButton;

    public RegistrationFormMediator()
    {
        // Create components and pass this mediator to them
        nameTextBox = new TextBox(this);
        emailTextBox = new TextBox(this);
        passwordTextBox = new TextBox(this);
        termsCheckbox = new Checkbox(this);
        newsletterCheckbox = new Checkbox(this);
        registerButton = new Button(this);

        registerButton.IsEnabled = false; // Initially, the register button is disabled
    }

    public void Notify(object sender, string event_)
    {
        // Logic to handle notifications from components
        if (sender is Checkbox && event_ == "checked")
        {
            // Enable the register button if all conditions are met
            registerButton.IsEnabled = AreFormConditionsMet();
        }
        else if (sender is TextBox && event_ == "textChanged")
        {
            // Enable the register button if all conditions are met
            registerButton.IsEnabled = AreFormConditionsMet();
        }
    }

    private bool AreFormConditionsMet()
    {
        // Check if all text fields are filled and terms are accepted
        return !string.IsNullOrEmpty(nameTextBox.Text) &&
               !string.IsNullOrEmpty(emailTextBox.Text) &&
               !string.IsNullOrEmpty(passwordTextBox.Text) &&
               termsCheckbox.IsChecked;
    }
}
