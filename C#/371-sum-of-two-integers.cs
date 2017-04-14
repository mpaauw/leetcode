public class Solution
{
    // 0001, 0010
    public int GetSum(int a, int b)
    {
        if(b == 0) {
            return a;
        }

        return GetSum(a ^ b, (a & b) << 1);
    }
}