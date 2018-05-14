using System;
using System.Collections.Generic;
using System.Linq;
using TreeTraversal.TreeGenerator;
namespace TreeTraversal.TreeExplores
{
    public class IterativeDfsTreeExplorer
    {
        private readonly HashSet<Node> _visitedNodes;
        private readonly Stack<Node> _nodesStack;

        public IterativeDfsTreeExplorer(Node startNode)
        {
            _visitedNodes = new HashSet<Node>();
            _nodesStack = new Stack<Node>();
            _nodesStack.Push(startNode);
        }

        public Node FindTarget()
        {
            Node currentNode;

            // While stack is not empty.
            while (_nodesStack.TryPop(out currentNode))
            {
                // Just a safety measure, since null is a valid value to push.
                if (currentNode == null)
                    continue;

                _visitedNodes.Add(currentNode);

                foreach (var node in currentNode.ChildNodes.Where(n => !_visitedNodes.Contains(n) && !_nodesStack.Contains(n)))
                {
                    // There is no reason to wait until node is popped to find out it's the target.
                    if (node.IsTargetNode)
                        return node;

                    _nodesStack.Push(node);
                }
            }
            return null;
        }
    }
}