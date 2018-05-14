using System;
namespace TreeTraversal.TreeGenerator
{
    public class Generator
    {
        private readonly int _maxChildNodes;
        private readonly Random _rnd;

        private bool targetNodeExist;

        public Generator(int maxChildNodes)
        {
            _maxChildNodes = maxChildNodes;
            _rnd = new Random();
        }

        public Node CreateTree(int maxDepth, bool singleTarget = true)
        {
            var node = new Node();

            if (maxDepth > 0)
            {
                var childNodesNumber = _rnd.Next(1, _maxChildNodes);

                for (var i = 0; i < childNodesNumber; ++i)
                {
                    node.ChildNodes.Add(CreateTree(maxDepth - 1, singleTarget));
                }
            }
            else
            {
                if (!targetNodeExist)
                {
                    node.IsTargetNode = true;

                    if (singleTarget)
                        targetNodeExist = true;
                }
            }
            return node;
        }

        public void PrintTree(Node node, string indent, bool last)
        {
            Console.Write(indent);

            if (last)
            {
                Console.Write("\\-");
                indent += "  ";
            }
            else
            {
                Console.Write("|-");
                indent += "| ";
            }

            var targetNodeMark = string.Empty;

            if (node.IsTargetNode)
                targetNodeMark = ": Target Node!";

            Console.WriteLine(node.Id + targetNodeMark);

            for (int i = 0; i < node.ChildNodes.Count; i++)
                PrintTree(node.ChildNodes[i], indent, i == node.ChildNodes.Count - 1);
        }
    }
}