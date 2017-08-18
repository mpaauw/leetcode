/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public IList<IList<int>> ZigzagLevelOrder(TreeNode root) {
        IList<IList<int>> order = new List<List<int>>();

        Stack<TreeNode> stack = new Stack<TreeNode>(); // FIFO
        stack.Push(root);

        traverse(order, stack, false);
    }

    private void traverse(IList<IList<int>> order,  Stack<TreeNode> stack, bool flag) {
        IList<int> currentRow = new IList<int>();
        Stack<TreeNode> nextRow = new Stack<TreeNode>();
        flag = (flag) ? false : true; // flip traversal direction
        while(stack.Count > 0) {
            TreeNode currentNode = queue.Pop();
            currentRow.Add(currentNode.val);
            if(flag) { // traverse right --> left (add to stack in reverse)
                if(currentNode.left != null) {
                    nextRow.Push(currentNode.left);
                } 
                if(currentNode.right != null) {
                    nextRow.Push(currentNode.right);
                }                          
            }
            else { // traverse left --> right (add to stack in rerverse)
                if(currentNode.right != null) {
                    nextRow.Push(currentNode.right);
                }  
                if(currentNode.left != null) {
                    nextRow.Push(currentNode.left);
                }                           
            }
        }
        order.Add(currentRow);
        if(nextRow.Count > 0) {           
            traverse(order, nextRow, flag);
        }
        return;   
    }
}