public int countLevels(TreeNode root) {
    if(root == null) {
        return -1;
    }

    // keep track of tree depth:
    int count = 0;

    // use queue
    Queue<TreeNode> queue = new LinkedList<>();
    queue.add(root);
    queue.add(null);

    // traverse tree, add null after every level:
    while(!queue.isEmpty()) {
        TreeNode current = queue.poll();
        if(current == null) {
            count++;
            queue.add(null);
            if(queue.peek() == null) {
                break;
            } else {
                continue;
            }
        } else {
            if(current.right != null) {
                queue.add(current.right);
            }
            if(current.left != null) {
                queue.add(current.left);
            }
        }
    }

    return count + 1;
}

public class TreeNode {
    int data;
    TreeNode left;
    TreeNode right;

    public TreeNode(int d) {
        data = d;
    }
}