public class Solution {
    public int CalPoints(string[] ops) {
        int pointsSum = 0;
        if(ops.Length < 1) { // edge case
            return pointsSum;
        }
        int pointSum = 0;
        Stack<int> stack = new Stack<int>();
        for(int i = 0; i < ops.Length; i++) {
            string command = ops[i];
            int points = 0;
            if(Int32.TryParse(command, out points)) {
                stack.Push(points);
            }
            else if(command.Equals("+")) {
                if(stack.Count >= 2) {
                    int last = stack.Pop();
                    int beforeLast = stack.Peek();
                    stack.Push(last);
                    stack.Push(last + beforeLast);
                }
                else if(stack.Count == 1) {
                    int last = stack.Peek();
                    stack.Push(last);
                }
            }
            else if(command.Equals("D")) {
                if(stack.Count >= 1) {
                    int last = stack.Peek();
                    stack.Push(last * 2);
                }
            }
            else if(command.Equals("C")) {
                if(stack.Count >= 1) {
                    stack.Pop();
                }
            }
        }
        while(stack.Count > 0) {
            int points = stack.Pop();
            pointSum += points;
        }
        return pointSum;        
    }
}