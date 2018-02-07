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
    public TreeNode ConstructMaximumBinaryTree(int[] nums)
    {
        return buildTree(nums, 0, nums.Length - 1);
    }

    private TreeNode buildTree(int[] nums, int left, int right)
    {
        if (left > right)
        {
            return null;
        }

        int maxIndex = left;
        for (int i = left + 1; i <= right; i++)
        {
            if (nums[i] > nums[maxIndex])
            {
                maxIndex = i;
            }
        }

        TreeNode node = new TreeNode(nums[maxIndex]);
        node.left = buildTree(nums, left, maxIndex - 1);
        node.right = buildTree(nums, maxIndex + 1, right);

        return node;
    }
}