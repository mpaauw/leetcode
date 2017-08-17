public class Solution
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        Stack<int> stack1 = this.buildStack(l1);
        Stack<int> stack2 = this.buildStack(l2);
        ListNode output = null;
        bool carry = false;

        while(stack1.Count > 0 && stack2.Count > 0)
        {
            int sum = (carry) ? stack1.Pop() + stack2.Pop() + 1 : stack1.Pop() + stack2.Pop();
            if(sum > 9)
            {
                carry = true;
                sum = sum % 10;
            }
            else
            {
                carry = false;
            }
            output = this.commuteOutput(output, sum);
        }

        while(stack1.Count > 0)
        {
            int sum = (carry) ? stack1.Pop() + 1 : stack1.Pop();
            if(sum > 9)
            {
                carry = true;
                sum = sum % 10;
            }
            else
            {
                carry = false;
            }
            output = this.commuteOutput(output, sum);
        }

        while(stack2.Count > 0)
        {
            int sum = (carry) ? stack2.Pop() + 1 : stack2.Pop();
            if(sum > 9)
            {
                carry = true;
                sum = sum % 10;
            }
            else
            {
                carry = false;
            }
            output = this.commuteOutput(output, sum);
        }

        if(carry)
        {
            output = this.commuteOutput(output, 1);
        }

        return output;
    }

    private ListNode commuteOutput(ListNode output, int sum)
    {
        ListNode oldPtr = output;
        output = new cSharp_test.Program.ListNode(sum);
        output.next = oldPtr;
        return output;
    }

    private Stack<int> buildStack(ListNode list)
    {
        Stack<int> stack = new Stack<int>();
        while(list != null)
        {
            stack.Push(list.val);
            list = list.next;
        }
        return stack;
    }
}

public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int x) { val = x; }
}