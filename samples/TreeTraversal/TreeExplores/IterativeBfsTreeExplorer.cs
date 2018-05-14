using System;
using System.Collections.Generic;
using System.Linq;
using TreeTraversal.TreeGenerator;
namespace TreeTraversal.TreeExplores
{
    public class IterativeBfsTreeExplorer
    {
        private readonly HashSet<Node> _visitedNodes;

        private readonly Queue<Node> _queuedNodes;

        public IterativeBfsTreeExplorer(Node startNode)
        {
            _visitedNodes = new HashSet<Node>();
            _queuedNodes = new Queue<Node>();
            _queuedNodes.Enqueue(startNode);
        }

        public Node FindTarget()
        {
            Node currentNode;

            // While queue is not empty
            while (_queuedNodes.TryDequeue(out currentNode))
            {
                // Just a safety measure, since null is a valid value to enqueue.
                if (currentNode == null)
                    continue;

                _visitedNodes.Add(currentNode);

                foreach (var node in currentNode.ChildNodes.Where(n => !_visitedNodes.Contains(n) && !_queuedNodes.Contains(n)))
                {
                    // There is no reason to wait until node is dequeued to find out it's the target.
                    if (node.IsTargetNode)
                        return node;

                    _queuedNodes.Enqueue(node);
                }
            }
            return null;
        }
    }
}