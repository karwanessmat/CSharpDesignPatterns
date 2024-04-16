using Facade1Demo.Subsystem_Classes;

namespace Facade1Demo
{
    /// <summary>
    /// The 'Facade' class
    /// </summary>
 public   class Facade
    {
        private readonly SubSystemOne _subSystemOne = new();
        private readonly SubSystemThree _subSystemThree = new();
        private readonly SubSystemTwo _subSystemTwo = new();


        public void CallSubSystemsMethod()
        {
            _subSystemOne.SystemOneMethodOne();
            _subSystemThree.SystemOneMethodThree();
            _subSystemTwo.SystemOneMethodTow();
        }
    }
}
