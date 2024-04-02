using Factory3Demo.Step1_Product;
using Factory3Demo.Step2_Concretes;
using Factory3Demo.Step3_Creator;

namespace Factory3Demo.step4_ConcreteCreator
{
    internal class LinuxPlayerCreator:PlayerCreator
    {
        public override Player CreatePlayer()
        {
            return new LinuxPlayer();
        }
    }
}
