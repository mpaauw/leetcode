public class Solution
{
    public TreeNode InvertTree(TreeNode root)
    {
        if(root == null) {
            return root;
        }

        if(root.left != null && root.right != null)
        {
            TreeNode temp = root.left;
            root.left = root.right;
            root.right = temp;
            root.left = InvertTree(root.left);
            root.right = InvertTree(root.right);
        }
        else if(root.left != null && root.right == null)
        {
            root.right = root.left;
            root.left = null;
            root.right = InvertTree(root.right);
        }
        else if(root.left == null && root.right != null)
        {
            root.left = root.right;
            root.right = null;
            root.left = InvertTree(root.left);
        }
        return root;
    }
}