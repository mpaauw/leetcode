public static ListNode reverseLinkedList(ListNode root)
{
    ListNode reversedList = null;
    while (root != null)
    {
        ListNode oldReversedRoot = reversedList;
        reversedList = new ListNode(root.val);
        reversedList.next = oldReversedRoot;
        root = root.next;
    }
    return reversedList;
}

public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int x)
    {
        val = x;
    }
}