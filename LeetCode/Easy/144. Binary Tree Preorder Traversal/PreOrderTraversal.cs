using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAndAlgo.LeetCode.Easy._144._Binary_Tree_Preorder_Traversal
{
    internal class PreOrderTraversal
    {

        /**
  * Definition for a binary tree node.
  * public class TreeNode {
  *     public int val;
  *     public TreeNode left;
  *     public TreeNode right;
  *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
  *         this.val = val;
  *         this.left = left;
  *         this.right = right;
  *     }
  * }
  */
        public class Solution
        {
            public IList<int> PreorderTraversal(TreeNode root)
            {
                IList<int> result = new List<int>();
                PreorderTraversalRecursive(root, result);
                return result;
            }

            public void PreorderTraversalRecursive(TreeNode node, IList<int> resultList)
            {
                if (node == null)
                    return;

                resultList.Add(node.val);
                PreorderTraversalRecursive(node.left, resultList);
                PreorderTraversalRecursive(node.right, resultList);
            }
            public IList<int> PreorderTraversalIterative(TreeNode root)
            {
                IList<int> result = new List<int>();
                TreeNode current;
                Stack<TreeNode> myStack = new Stack<TreeNode>();
                myStack.Push(root);

                while (myStack.Count != 0)
                {
                    current = myStack.Pop();

                    if (current != null)
                    {
                        result.Add(current.val);

                        myStack.Push(current.right);

                        myStack.Push(current.left);
                    }

                }
                return result;
            }
        }
    }
}
