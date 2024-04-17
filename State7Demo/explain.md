
# E-Commerce Order Management System

This project demonstrates the use of the State design pattern to manage the lifecycle of orders in an e-commerce system. The system handles different states of an order: Placed, Paid, Shipped, and Delivered, each allowing specific operations.

## Implementation Details

### 1. Abstract State Class 📘

The abstract `OrderState` class defines a common interface for all concrete state classes. It ensures that all states can interact with the `OrderContext` and defines the mandatory methods that all states must implement.

**Code:**
```csharp
public abstract class OrderState
{
    protected OrderContext Order;

    public void SetContext(OrderContext order)
    {
        this.Order = order;
    }

    public abstract void Pay();
    public abstract void Ship();
    public abstract void Deliver();
}
```

### 2. Concrete State Classes 🏷️

Each state of the order lifecycle is represented by a concrete state class. These classes implement the behaviors associated with a state's specific actions.

#### Placed State
Handles the transition from "Placed" to "Paid".

**Code:**
```csharp
public class OrderedState : OrderState
{
    public override void Pay()
    {
        Console.WriteLine("Order has been paid.");
        Order.TransitionTo(new PaidState());
    }

    public override void Ship()
    {
        Console.WriteLine("Order must be paid before it can be shipped.");
    }

    public override void Deliver()
    {
        Console.WriteLine("Order must be shipped before it can be delivered.");
    }
}
```

#### Paid State
Allows an order to be shipped after payment.

**Code:**
```csharp
public class PaidState : OrderState
{
    public override void Pay()
    {
        Console.WriteLine("Order is already paid.");
    }

    public override void Ship()
    {
        Console.WriteLine("Order has been shipped.");
        Order.TransitionTo(new ShippedState());
    }

    public override void Deliver()
    {
        Console.WriteLine("Order must be shipped before it can be delivered.");
    }
}
```

#### Shipped State
Allows an order to be delivered after shipping.

**Code:**
```csharp
public class ShippedState : OrderState
{
    public override void Pay()
    {
        Console.WriteLine("Order is already paid.");
    }

    public override void Ship()
    {
        Console.WriteLine("Order is already shipped.");
    }

    public override void Deliver()
    {
        Console.WriteLine("Order has been delivered.");
        Order.TransitionTo(new DeliveredState());
    }
}
```

#### Delivered State
Marks an order as completed upon delivery.

**Code:**
```csharp
public class DeliveredState : OrderState
{
    public override void Pay()
    {
        Console.WriteLine("Order is already paid and delivered.");
    }

    public override void Ship()
    {
        Console.WriteLine("Order is already delivered.");
    }

    public override void Deliver()
    {
        Console.WriteLine("Order is already delivered.");
    }
}
```

### 3. Context Class 🌐

The `OrderContext` class holds the current state of the order and allows state transitions. It acts as the primary interface for client interaction.

**Code:**
```csharp
public class OrderContext
{
    private OrderState _state;

    public OrderContext(OrderState state)
    {
        TransitionTo(state);
    }

    public void TransitionTo(OrderState state)
    {
        Console.WriteLine($"Transitioning to {state.GetType().Name}");
        this._state = state;
        this._state.SetContext(this);
    }

    public void Pay()
    {
        this._state.Pay();
    }

    public void Ship()
    {
        this._state.Ship();
    }

    public void Deliver()
    {
        this._state.Deliver();
    }
}
```

### 4. Usage Example 🚀

Demonstrates how to use the context and states to process an order through its lifecycle stages.

**Code:**
```csharp
public class Program
{
    public static void Main(string[] args)
    {
        var order = new OrderContext(new OrderedState());
        order.Pay();   // Pay for the order
        order.Ship();  // Attempt to ship, will transition to ShippedState
        order.Deliver(); // Finally, mark the order as delivered
    }
}
```

## Conclusion

This system illustrates how the State design pattern can effectively manage state transitions in complex systems, ensuring that operations are valid for the current state and simplifying the management of state-dependent behaviors.
```
