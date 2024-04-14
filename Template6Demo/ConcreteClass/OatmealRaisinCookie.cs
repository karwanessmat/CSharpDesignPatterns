using Template6Demo.AbstractClass;

namespace Template6Demo.ConcreteClass;

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