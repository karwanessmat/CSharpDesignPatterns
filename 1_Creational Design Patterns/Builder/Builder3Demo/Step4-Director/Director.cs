using Builder3Demo.Step2_Builder_Interface;

namespace Builder3Demo.Step4_Director;

public class Director(IBuilder builder)
{
    public void Construct()
    {
        builder.BuildPartA();
        builder.BuildPartB();
    }

}