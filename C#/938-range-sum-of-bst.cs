/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution
{
    public int RangeSumBST(TreeNode root, int L, int R)
    {
        return TraverseForSum(root, 0, L, R);
    }

    private int TraverseForSum(TreeNode node, int sum, int L, int R)
    {
        if (node == null)
        {
            return sum;
        }

        if (node.val >= L && node.val <= R)
        {
            sum += node.val;
        }

        sum = TraverseForSum(node.left, sum, L, R);
        sum = TraverseForSum(node.right, sum, L, R);
        return sum;
    }
}

 public class TreeNode {
     public int val;
     public TreeNode left;
     public TreeNode right;
     public TreeNode(int x) { val = x; }
 }