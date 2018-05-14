using System;
using System.Collections.Generic;
using System.Linq;
using TreeTraversal.TreeGenerator;
namespace TreeTraversal.TreeExplores
{
    public class RecursiveBfsTreeExplorer
    {
        private readonly HashSet<Node> _visitedNodes;

        private readonly Queue<Node> _queuedNodes;

        public RecursiveBfsTreeExplorer(Node startNode)
        {
            _visitedNodes = new HashSet<Node>();
            _queuedNodes = new Queue<Node>();
            _queuedNodes.Enqueue(startNode);
        }

        public Node FindTarget()
        {
            Node currentNode;

            // Scanned the entire tree and didn't find the target.
            if (!_queuedNodes.TryDequeue(out currentNode))
                return null;

            // Just a safety measure, since null is a valid value to enqueue.
            if (currentNode == null)
                return FindTarget();

            _visitedNodes.Add(currentNode);

            foreach (var node in currentNode.ChildNodes.Where(n => !_visitedNodes.Contains(n) && !_queuedNodes.Contains(n)))
            {
                // There is no reason to wait until node is popped to find out it's the target.
                if (node.IsTargetNode)
                    return node;

                _queuedNodes.Enqueue(node);
            }

            return FindTarget();
        }
    }
}