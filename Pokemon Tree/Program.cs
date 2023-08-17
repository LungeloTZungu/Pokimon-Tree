using System;

namespace Pokemon_Tree
{
    // Binary Search Tree
    // This is hierachical data structure since it has a Root,Parents,Children (ONLY 2),Nodes and Sorted
    // 3 Basic Rules for Binary Search tree
    // 1. Ony have two models per parent
    // 2. Every node to the left is less
    // 3. Every node to the right of the parent is greater.
    // since its not linear the first index is the root 
    // uses recursion
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree tree = new BinarySearchTree();
            tree.Insert(7, "Squirtle");
            tree.Insert(23, "Ekans");
            tree.Insert(151, "Mew");
            tree.Insert(4, "Charmander");
            tree.Insert(1, "Bulbasaur");

            Console.WriteLine(tree.Find(151));
        }
    }
}
