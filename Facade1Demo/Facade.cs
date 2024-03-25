namespace Facade1Demo
{
    /// <summary>
    /// The 'Facade' class
    /// </summary>
 public   class Facade
    {
        private readonly SubSystemOne _subSystemOne;
        private readonly SubSystemThree _subSystemThree;
        private readonly SubSystemTwo _subSystemTwo;

        public Facade()
        {
            _subSystemOne = new SubSystemOne();
            _subSystemThree = new SubSystemThree();
            _subSystemTwo = new SubSystemTwo();
        }


        public void CallSubSystemsMethod()
        {
            _subSystemOne.SystemOneMethodOne();
            _subSystemThree.SystemOneMethodThree();
            _subSystemTwo.SystemOneMethodTow();
        }
    }
}
