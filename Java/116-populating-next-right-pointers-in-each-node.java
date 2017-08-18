public class Solution
{
    public void connect(TreeLinkNode root)
    {
        if(root == null) {
            return;
        }

        TreeLinkNode previousNode = root;
        TreeLinkNode currentNode = null;
        while(previousNode.left != null) {
            currentNode = previousNode;
            while(currentNode != null) {
                currentNode.left.next = currentNode.right;
                if(currentNode.next != null) {
                    currentNode.right.next = currentNode.next.left;
                }
                currentNode = currentNode.next;
            }
            previousNode = previousNode.left;
        }
    }

}


public class TreeLinkNode {
    int val;
    TreeLinkNode left, right, next;
    TreeLinkNode(int x) { val = x; }
}