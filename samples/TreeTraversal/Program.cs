using System;
using TreeTraversal.TreeGenerator;
using TreeTraversal.TreeExplores;
namespace TreeTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            var treeEntryNode = GenerateSampleTree();
            var treeExplorer = new IterativeDfsTreeExplorer(treeEntryNode); // Modify the explorer to test different behaviours.

            var exitNode = treeExplorer.FindTarget();

            Console.WriteLine("Found target at: " + exitNode.Id);

            var x = Console.ReadLine();
        }
        static Node GenerateSampleTree()
        {
            var treeGenerator = new Generator(3);

            var tree = treeGenerator.CreateTree(10, false);

            treeGenerator.PrintTree(tree, "", false);

            return tree;
        }
    }
}
