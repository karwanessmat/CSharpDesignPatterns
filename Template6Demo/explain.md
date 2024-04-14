

# Cookie Recipe Application

This application demonstrates the Template Method design pattern by providing a framework for baking different types of cookies, such as Chocolate Chip Cookies and Oatmeal Raisin Cookies. Each type of cookie follows the same basic procedure with specific variations in ingredients and baking time.

## Step 1: Define the Abstract Base Class

The `CookieRecipe` abstract class defines the template method `MakeCookie()` which outlines the steps for making cookies. Some methods are concrete and shared among all subclasses, while others are abstract and must be implemented by each subclass to cater to different cookie types.

### Related Code

```csharp
public abstract class CookieRecipe
{
    // The template method defines the sequence of steps to make a cookie.
    public void MakeCookie()
    {
        MixIngredients();
        PrepareDough();
        Bake();
        Cool();
        Serve();
    }

    protected abstract void MixIngredients(); // Subclasses will provide their own implementation.

    protected void PrepareDough()
    {
        Console.WriteLine("Preparing the dough by kneading the mixed ingredients.");
    }

    protected abstract void Bake(); // Subclasses will provide their own implementation.

    protected void Cool()
    {
        Console.WriteLine("Cooling the cookies for 20 minutes.");
    }

    protected void Serve()
    {
        Console.WriteLine("Serving the delicious cookies.");
    }
}
```

## Step 2: Create Concrete Subclasses

Each subclass represents a specific type of cookie. They override the abstract methods `MixIngredients()` and `Bake()` to provide specific details about the ingredients and baking instructions for that cookie type.

### Related Code

```csharp
public class ChocolateChipCookie : CookieRecipe
{
    protected override void MixIngredients()
    {
        Console.WriteLine("Mixing flour, sugar, butter, and chocolate chips.");
    }

    protected override void Bake()
    {
        Console.WriteLine("Baking the chocolate chip cookies at 350 degrees for 12 minutes.");
    }
}

public class OatmealRaisinCookie : CookieRecipe
{
    protected override void MixIngredients()
    {
        Console.WriteLine("Mixing flour, sugar, butter, oats, and raisins.");
    }

    protected override void Bake()
    {
        Console.WriteLine("Baking the oatmeal raisin cookies at 350 degrees for 15 minutes.");
    }
}
```

## Step 3: Usage

This final step involves creating instances of the concrete subclasses and calling their `MakeCookie` method. This will execute the steps defined in the template method of the base class while utilizing the specific implementations of the abstract methods provided by the subclasses.

### Related Code

```csharp
class Program
{
    static void Main(string[] args)
    {
        CookieRecipe chocolateChip = new ChocolateChipCookie();
        chocolateChip.MakeCookie();

        Console.WriteLine();

        CookieRecipe oatmealRaisin = new OatmealRaisinCookie();
        oatmealRaisin.MakeCookie();
    }
}
```

---

This `README.md` provides a clear and detailed guide to implementing the Template Method pattern in a C# application. It outlines the structure of the code and the responsibilities of each class and method, making it easy for other developers to understand and use the framework for additional types of cookies.