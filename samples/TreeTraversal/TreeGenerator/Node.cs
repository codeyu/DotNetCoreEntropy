using System;
using System.Collections.Generic;
namespace TreeTraversal.TreeGenerator
{
    public class Node
    {
        public Guid Id { get; set; }
        public List<Node> ChildNodes { get; set; }
        public bool IsTargetNode { get; set; }
        public Node ParentNode { get; set; }

        public Node()
        {
            ChildNodes = new List<Node>();
            Id = Guid.NewGuid();
        }   
    }
}