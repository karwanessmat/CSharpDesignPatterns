using Template6Demo.AbstractClass;

namespace Template6Demo.ConcreteClass;

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