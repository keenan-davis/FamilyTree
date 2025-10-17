using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyTree
{
    public class FamilyTree
    {
        public FamilyTreeNode Root { get; set; }
        public FamilyTree(RoyalMember rootMember)
        {
            Root = new FamilyTreeNode(rootMember);
        }

        public void DisplayTree(FamilyTreeNode node, string indent = "")
        {
            if (node == null) return;
            Console.WriteLine(indent + node.Member);
            foreach (var child in node.Children)
            {
                DisplayTree(child, indent + "  ");
            }
        }
        public void BFS()
        {
            Console.WriteLine("\n--- BFS Traversal ---");
            var queue = new Queue<FamilyTreeNode>();
            queue.Enqueue(Root);

            while (queue.Count > 0)
            {
                var current = queue.Dequeue();
                Console.WriteLine(current.Member);
                foreach (var child in current.Children)
                {
                    queue.Enqueue(child);
                }
            }
        }

        public void DFS(FamilyTreeNode node)
        {
            if (node == null) return;
            Console.WriteLine(node.Member);
            foreach (var child in node.Children)
            {
                DFS(child);
            }
        }
        public FamilyTreeNode Search(string name)
        {
            var queue = new Queue<FamilyTreeNode>();
            queue.Enqueue(Root);
            while (queue.Count > 0)
            {
                var current = queue.Dequeue();
                if (current.Member.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    return current;
                }
                foreach (var child in current.Children)
                {
                    queue.Enqueue(child);
                }
            }
            return null;
        }
        public void AddMember(string parentName, RoyalMember newMember)
        {
            var parentNode = Search(parentName);
            if (parentNode != null)
            {
                var newNode = new FamilyTreeNode(newMember);
                parentNode.AddChild(newNode);
            }
            else
            {
                Console.WriteLine($"Parent with name {parentName} not found.");
            }
        }
    }
}
