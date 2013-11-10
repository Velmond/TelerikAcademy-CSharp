//06*. Define the data structure binary search tree with operations for "adding new element",
//     "searching element" and "deleting elements". It is not necessary to keep the tree balanced.
//     Implement the standard methods from System.Object – ToString(), Equals(…), GetHashCode()
//     and the operators for comparison  == and !=. Add and implement the ICloneable interface
//     for deep copy of the tree. Remark: Use two types – structure BinarySearchTree (for the
//     tree) and class TreeNode (for the tree elements). Implement IEnumerable<T> to traverse the tree.

namespace BinarySearchTree
{
    using System;

    class TestApplication
    {
        static void Main()
        {
            // Didn't finish this one before the deadline for the homework so I couldn't test if some of parts that I managed to
            // ... implement actually work.

            BinarySearchTree<int> tree = new BinarySearchTree<int>();   // Adding works
            tree.Add(7); tree.Add(6); tree.Add(5); tree.Add(4); tree.Add(3); tree.Add(2); tree.Add(1); tree.Add(6);
            tree.Add(5); tree.Add(4); tree.Add(3); tree.Add(2); tree.Add(6); tree.Add(5); tree.Add(4); tree.Add(3);
            tree.Add(6); tree.Add(5); tree.Add(4); tree.Add(6); tree.Add(5); tree.Add(6); tree.Add(7); tree.Add(15);
            tree.Add(14);tree.Add(13);tree.Add(12);tree.Add(11);tree.Add(10);tree.Add(14);tree.Add(13);tree.Add(12);
            tree.Add(11);tree.Add(14);tree.Add(13);tree.Add(12);tree.Add(14);tree.Add(13);tree.Add(14);tree.Add(20);
            tree.Add(19);tree.Add(16);tree.Add(16);tree.Add(17);tree.Add(18);tree.Add(19);tree.Add(21);tree.Add(20);
            tree.Add(22);

            // tree written down
            //                             7
            //                  6                     15
            //                5   7               14      20
            //            4    6              13      19      21
            //        3    5  6         12     14   16   20     22
            //    2    4  5  6      11    13  14   16 17 
            //1    3  4  5  6   10   12  13  14         18 
            // 2  3  4  5  6     11 12  13  14            19

            BinarySearchTree<int> clonedTree = (BinarySearchTree<int>)tree.Clone(); // Cloneing works as far as I can see by debugging

            // Find() goes into an infinite loop
            TreeNode<int> node = clonedTree.Find(100);  // Null
            PrintNode(node);
            node = clonedTree.Find(-100);   // Null
            PrintNode(node);
            node = clonedTree.Find(9);      // Null
            PrintNode(node);
            node = clonedTree.Find(13);     // Data: 13 (L: 12, R: 14) -> Depth: 4, Offset: -1 ? I think
            PrintNode(node);
        }

        private static void PrintNode(TreeNode<int> node)
        {
            if (node == null)
            {
                Console.WriteLine("Null");
            }
            else
            {
                Console.WriteLine(node);
            }
        }
    }
}
