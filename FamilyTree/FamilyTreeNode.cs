using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyTree
{
    public class FamilyTreeNode
    {
        public RoyalMember Member { get; set; }
        public List<FamilyTreeNode> Children { get; set; }

        public FamilyTreeNode(RoyalMember member)
        {
            Member = member;
            Children = new List<FamilyTreeNode>();
        }
        public void AddChild(FamilyTreeNode child)
        {
            Children.Add(child);
            Children.Sort((a, b) => a.Member.BirthDate.CompareTo(b.Member.BirthDate));

        }
    }
}
