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
    public IList<double> AverageOfLevels(TreeNode root)
    {
        IList<double> averages = new List<double>();
        if(root == null) {
            return averages;
        }
        Queue<TreeNode> queue = new Queue<TreeNode>(); // use a queue structure to track node-level visitation in a BFS pattern
        queue.Enqueue(root);
        while(queue.Count > 0) {
            int n = queue.Count;
            double sum = 0.0;
            for(int i = 0; i < n; i++) {
                TreeNode node = queue.Dequeue();
                sum += node.val;
                if(node.left != null) {
                    queue.Enqueue(node.left);
                }
                if(node.right != null) {
                    queue.Enqueue(node.right);
                }
            }
            averages.Add(sum / n); // add the average of all node values counted at current level to the result variable.
        }
        return averages;
    }

}