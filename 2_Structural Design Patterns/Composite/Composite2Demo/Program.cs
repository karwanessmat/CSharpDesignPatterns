using System;
using Composite2Demo._2_Leaf;
using Composite2Demo.Composite;

namespace Composite2Demo
{
    class Program
    {
        static void Main(string[] args)
        {

            //create a tree structure 
            var root =new CompositeElement("Picture");
           root.Add(new PrimitiveElement("Red Line"));
           root.Add(new PrimitiveElement("Blue Circle"));
           root.Add(new PrimitiveElement("Green Box"));
           
            // create a branch 
           var comp = new CompositeElement("Two Circles");
           comp.Add(new PrimitiveElement("Black Circle"));
           comp.Add(new PrimitiveElement("White Circle"));
           root.Add(comp);


            //Add and remove a PrimitiveElement
            var pe = new PrimitiveElement("Yellow line");
            root.Add(pe);
          //  root.Remove(pe);


            // recursively display nodes
            root.Display(1);


            // Wait for user
            Console.ReadKey();
        }
    }
}
