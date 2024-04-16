namespace Template6Demo.AbstractClass
;
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
