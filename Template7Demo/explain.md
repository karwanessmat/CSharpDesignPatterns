
# Template Cooking Application

## Introduction
This application demonstrates the use of the Template Method design pattern in a culinary context. The pattern helps in organizing the cooking process into a series of steps (like preparing the crust, adding toppings, and baking). This approach ensures that each type of food is prepared consistently while allowing for variations specific to each dish.

## Why Use the Template Method Pattern?
The Template Method pattern is crucial for:
- **Maintaining consistency** in the sequence of operations while allowing the steps themselves to be customized for different types of dishes.
- **Reducing code duplication** by centralizing common functionality in a base class and only changing the behavior where necessary in subclass implementations.
- **Encapsulating algorithms** in a method, minimizing the risk of errors and ensuring that the necessary steps are performed in the correct order.

## Project Structure
- **PanFood**: Abstract base class for any food that can be cooked in a pan.
- **PanFoodServiceBase<T>**: Generic abstract base class that defines the template method and the sequence of cooking steps.
- **Concrete Classes**: Specific implementations for different types of food like `Pizza`, `Pie`, and `ColdVeggiePizza`.

## Implementation Details

### Step 1: Define Abstract Base Classes

#### PanFood
Defines a basic property `RequiresBaking` that dictates whether the food needs to be baked.
```csharp
public abstract class PanFood
{
    public bool RequiresBaking { get; set; } = true;
}
```

#### PanFoodServiceBase<T>
This generic class uses the Template Method pattern to define the sequence of cooking steps. Each step is either a concrete implementation or an abstract method that must be implemented by subclasses.
```csharp
public abstract class PanFoodServiceBase<T> where T : PanFood, new()
{
    protected readonly LoggerAdapter _logger;
    protected T _item;

    public PanFoodServiceBase(LoggerAdapter logger)
    {
        _logger = logger;
    }

    public T Prepare()
    {
        _item = new T();

        PrepareCrust();
        AddToppings();
        Cover();
        if (_item.RequiresBaking)
        {
            Bake();
        }
        Slice();

        return _item;
    }

    protected abstract void PrepareCrust();
    protected abstract void AddToppings();
    protected virtual void Bake()
    {
        _logger.Log("Bake the item.");
    }
    protected abstract void Slice();
    protected virtual void Cover()
    {
        // does nothing by default
    }
}
```

### Step 2: Implement Concrete Classes

#### PizzaBakingService
Handles the preparation of a pizza, including crust preparation, adding toppings, baking, and slicing.
```csharp
public class PizzaBakingService : PanFoodServiceBase<Pizza>
{
    // Implementations of abstract methods
}
```

#### ColdVeggiePizzaBakingService
Prepares a veggie pizza that does not require baking. It demonstrates the flexibility of the Template Method pattern by skipping the baking step.
```csharp
public class ColdVeggiePizzaBakingService : PanFoodServiceBase<ColdVeggiePizza>
{
    // Implementations of abstract methods
}
```

### Step 3: Usage
Demonstrates how to use the classes to prepare different types of food.
```csharp
static void Main(string[] args)
{
    var logger = new LoggerAdapter();

    var pizzaService = new PizzaBakingService(logger);
    var pizza = pizzaService.Prepare();
    Console.WriteLine(logger.Dump());

    var coldVeggiePizzaService = new ColdVeggiePizzaBakingService(new LoggerAdapter());
    var coldVeggiePizza = coldVeggiePizzaService.Prepare();
    Console.WriteLine(logger.Dump());
}
```

## Conclusion
This application illustrates the power and flexibility of the Template Method design pattern in a practical cooking application. By defining a standard process and allowing for specific customizations, it simplifies code management while accommodating variations in food preparation. This pattern is especially useful in applications where the process steps are fixed, but the details of those steps vary.

---