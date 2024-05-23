using Factory3Demo.Step1_Product_Interface;
using Factory3Demo.Step2_Product_Concretes;
using Factory3Demo.Step3_Creator;

namespace Factory3Demo.step4_Concrete_Creator;

public class WindowsPlayerCreator:PlayerCreator
{
    public override Player CreatePlayer()
    {
        return new WindowsPlayer();
    }
}