using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class Tree<TI> where TI : IComparable<TI>
    {
        public TI NodeData { get; set; }
        public Tree<TI> LeftTree { get; set; }
        public Tree<TI> RightTree { get; set; }
        public Tree(TI nodeValue)
        {
            this.NodeData = nodeValue;
            this.LeftTree = null;
            this.RightTree = null;
        }
        public void Insert(TI newItem)
        {
            TI currentNodeValue = NodeData;
            if (currentNodeValue.CompareTo(newItem) > 0)
            {
                if (LeftTree == null)
                {
                    LeftTree = new Tree<TI>(newItem);
                }
                else
                {
                    LeftTree.Insert(newItem);
                }
            }
            else
            {
                if (RightTree == null)
                {
                    RightTree = new Tree<TI>(newItem);
                }
                else
                {
                    RightTree.Insert(newItem);
                }
            }
            }
        public string WalkTree()
        {
            string result = "";
            if (LeftTree != null)
            {
                result = LeftTree.WalkTree();
            }
            result += $" {NodeData.ToString()} ";
            if (this.RightTree != null)
            {
                result += RightTree.WalkTree();
            }
            return result;
        }
    }
}
