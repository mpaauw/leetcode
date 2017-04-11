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
    public int MaxDepth(TreeNode root)
    {
        return findHeight(root, 0);
    }

    private int findHeight(TreeNode root, int height)
    {
        if (root == null)
        {
            return height;
        }
        height++;
        return Math.Max(findHeight(root.left, height), findHeight(root.right, height));
    }
}

public class TreeNode {
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int x) { val = x; }
}