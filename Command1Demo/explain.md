
### Step 1: Define the Command Interface
The `ICommand` interface declares the essential structure for command objects, defining methods for executing and undoing actions.

```csharp
// ICommand interface defines the structure for command objects with execution and undo capabilities
public interface ICommand
{
    void ExecuteAction(); // Method to execute the command
    void UndoAction();    // Method to undo the command
}
```

### Step 2:(Create Concrete Commands:) Implement the Command for Product Price Modification
`ProductCommand` implements `ICommand` to execute and undo price modifications on a `Product`.

```csharp
// ProductCommand class for executing and undoing price modifications on a product
public class ProductCommand : ICommand
{
    private readonly Product product;
    private readonly PriceAction priceAction;
    private readonly int amount;
    public bool IsCommandExecuted { get; private set; }

    // Initialize the command with product details and the price modification action
    public ProductCommand(Product product, PriceAction priceAction, int amount)
    {
        this.product = product;
        this.priceAction = priceAction;
        this.amount = amount;
    }

    // Execute price modification based on the specified action
    public void ExecuteAction()
    {
        if (priceAction == PriceAction.Increase)
        {
            product.IncreasePrice(amount);
            IsCommandExecuted = true;
        }
        else
        {
            IsCommandExecuted = product.DecreasePrice(amount);
        }
    }

    // Undo the price modification action
    public void UndoAction()
    {
        if (!IsCommandExecuted)
            return;

        if (priceAction == PriceAction.Increase)
            product.DecreasePrice(amount);
        else
            product.IncreasePrice(amount);
    }
}
```

### Step 3:(Define the Receiver:) Create the Product Class
`Product` represents the item whose price will be modified, providing methods to increase and decrease its price.

```csharp
// Product class represents an item with a name and price
public class Product
{
    public string Name { get; set; }
    public int Price { get; set; }

    // Initialize product with name and initial price
    public Product(string name, int price)
    {
        Name = name;
        Price = price;
    }

    // Method to increase the product's price
    public void IncreasePrice(int amount)
    {
        Price += amount;
        Console.WriteLine($"The price for {Name} has been increased by {amount:C0}. Current Price: {Price:C0}");
    }

    // Method to decrease the product's price, ensuring it doesn't go below 0
    public bool DecreasePrice(int amount)
    {
        if (amount >= Price) return false;
        Price -= amount;
        Console.WriteLine($"The price for {Name} has been decreased by {amount:C0}. Current Price: {Price:C0}");
        return true;
    }

    public override string ToString()
    {
        return $"Current price for {Name} is {Price:C0}.";
    }
}
```

### Step 4:(Create the Invoker:) Manage Command Execution with ModifyPrice
`ModifyPrice` manages the execution and undoing of commands, allowing multiple commands to be tracked and reversed if needed.

```csharp
// ModifyPrice class manages the execution and undoing of product price commands
public class ModifyPrice
{
    private readonly List<ICommand> _commands = new();
    private ICommand _command;

    // Set the command to be executed
    public void SetCommand(ICommand command)
    {
        _command = command;
    }

    // Execute the command and add it to the command list
    public void Invoke()
    {
        _commands.Add(_command);
        _command.ExecuteAction();
    }

    // Undo all executed commands in reverse order
    public void UndoActions()
    {
        foreach (var command in Enumerable.Reverse(_commands))
        {
            command.UndoAction();
        }
    }
}
```

### Step 5: Define the PriceAction Enumeration
`PriceAction` defines the types of price modification actions that can be performed on a product.

```csharp
// PriceAction enumeration defines the types of actions that can be performed on a product's price
public enum PriceAction
{
    Increase, // Represents an increase in price
    Decrease  // Represents a decrease in price
}
```

### Step 6: Implement the Main Method
The `Main` method serves as the entry point of the program, demonstrating the use of the command pattern to modify product prices and then undo those changes.

```csharp
// Main method to demonstrate price modification commands
private static void Main()
{
    var modifyPrice = new ModifyPrice();
    var product = new Product("Phone", 500);

    // Execute price increase and decrease commands
    Execute(product, modifyPrice, new ProductCommand(product, PriceAction.Increase

, 100));
    Execute(product, modifyPrice, new ProductCommand(product, PriceAction.Increase, 50));
    Execute(product, modifyPrice, new ProductCommand(product, PriceAction.Decrease, 70));

    Console.WriteLine(product); // Display product price after modifications
    modifyPrice.UndoActions();  // Undo the executed price modifications
    Console.WriteLine(product); // Display product price after undoing modifications

    Console.ReadLine();
}

// Helper method to execute a product command using ModifyPrice
private static void Execute(Product product, ModifyPrice modifyPrice, ICommand productCommand)
{
    modifyPrice.SetCommand(productCommand);
    modifyPrice.Invoke();
}
```

Each step above outlines the creation of the command pattern components, demonstrating how to encapsulate requests as objects, allowing parameterization and queuing of requests, and enabling undo operations.