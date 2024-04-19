
## Composite Pattern Implementation in C#

### This repository contains a simple implementation of the Composite design pattern in C#. The Composite pattern allows you to treat individual objects and compositions of objects uniformly through a common interface. This example simulates a graphic application where shapes can be single entities or composed of multiple shapes.

##  Frequency of use:4/5 medium-high

## Structure

The implementation includes the following components:

- **Component**: An interface for all objects in the structure.
- **Leaf**: Represents individual objects in the composition.
- **Composite**: A composition of leaves or other composites.

## Steps to Implement

### Step 1: Define the Component Interface

Create an interface named `IGraphic` that will declare common operations for both simple and complex components.

```csharp
public interface IGraphic
{
    void Draw();
    void Add(IGraphic graphic);
    void Remove(IGraphic graphic);
    IGraphic GetChild(int index);
}
```

### Step 2: Create Leaf Classes

Implement the `IGraphic` interface in a simple element class that represents a leaf in the structure. Leafs perform actual operations and cannot have children.

```csharp
public class Rectangle : IGraphic
{
    public void Draw()
    {
        Console.WriteLine("Drawing a rectangle");
    }

    public void Add(IGraphic graphic)
    {
        throw new InvalidOperationException("Cannot add to a leaf");
    }

    public void Remove(IGraphic graphic)
    {
        throw new InvalidOperationException("Cannot remove from a leaf");
    }

    public IGraphic GetChild(int index)
    {
        throw new InvalidOperationException("No children available");
    }
}
```

### Step 3: Create Composite Classes

Implement the `IGraphic` interface in a class that can contain other `IGraphic` objects. Composites can manage children and delegate operations to them.

```csharp
public class CompositeGraphic : IGraphic
{
    private List<IGraphic> _graphics = new List<IGraphic>();

    public void Draw()
    {
        Console.WriteLine("Composite Graphic");
        foreach (var graphic in _graphics)
        {
            graphic.Draw();
        }
    }

    public void Add(IGraphic graphic)
    {
        _graphics.Add(graphic);
    }

    public void Remove(IGraphic graphic)
    {
        _graphics.Remove(graphic);
    }

    public IGraphic GetChild(int index)
    {
        return _graphics[index];
    }
}
```

### Step 4: Implement Client Code

Use the `IGraphic` interface to interact with elements in the structure. The client can manipulate both individual and composite elements uniformly.

```csharp
class Program
{
    static void Main(string[] args)
    {
        var compositeGraphic = new CompositeGraphic();
        var rectangle = new Rectangle();
        var secondComposite = new CompositeGraphic();

        compositeGraphic.Add(rectangle);
        compositeGraphic.Add(secondComposite);

        // Drawing all components and their children
        compositeGraphic.Draw();
    }
}
```

## Summary

This example demonstrates how to implement the Composite design pattern in C#. By structuring the code into components like `IGraphic`, `Rectangle`, and `CompositeGraphic`, we achieve flexibility and ease of maintenance, allowing for the uniform treatment of individual and composed objects.

```

This README.md provides a clear guide to implementing the Composite pattern in C#, suitable for inclusion in a GitHub repository or similar version control systems. Each step is explained with corresponding C# code to demonstrate the pattern effectively.