using System;

namespace Adapter3Demo
{
    internal class Program
    {
        /// <summary>
        /// MainApp startup class for Real-World 
        /// Adapter Design Pattern.
        /// </summary>
        private static void Main(string[] args)
        {

                // Non-adapted chemical compound
                Compound unknown = new Compound("Unknown");
                unknown.Display();

                // Adapted chemical compounds
                Compound water = new RichCompound("Water");
                water.Display();

                Compound benzene = new RichCompound("Benzene");
                benzene.Display();

                Compound ethanol = new RichCompound("Ethanol");
                ethanol.Display();

                // Wait for user

                Console.ReadKey();
        }
    }
}
