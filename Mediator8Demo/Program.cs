
        using Mediator8Demo._02_CreateConcreteMediator;

        var mediator = new RegistrationFormMediator();

        // Simulate user input and interactions
        mediator.nameTextBox.Text = "John Doe";
        mediator.nameTextBox.TextChanged();

        mediator.emailTextBox.Text = "john@example.com";
        mediator.emailTextBox.TextChanged();

        mediator.passwordTextBox.Text = "Secure123!";
        mediator.passwordTextBox.TextChanged();

        mediator.termsCheckbox.Checked();

        // Output the status of the register button
        Console.WriteLine("Register button enabled: " + mediator.registerButton.IsEnabled);
