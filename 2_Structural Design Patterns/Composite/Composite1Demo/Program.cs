﻿using System;
using Composite1Demo.Step2___Composite_Class;
using Composite1Demo.Step3___Composite_Class;

namespace Composite1Demo;

class Program
{
    static void Main()
    {

        // Create a tree structure

        var root = new Composite("root");
        root.Add(new Leaf("Leaf A"));
        root.Add(new Leaf("Leaf B"));

        var comp = new Composite("Composite X");
        comp.Add(new Leaf("Leaf XA"));
        comp.Add(new Leaf("Leaf XB"));

        root.Add(comp);
        root.Add(new Leaf("Leaf C"));

        // Add and remove a leaf

        var leaf = new Leaf("Leaf D");
        root.Add(leaf);
        // root.Remove(leaf);

        // Recursively display tree
        root.Display(0);

        // Wait for user

        Console.ReadKey();

    }
}