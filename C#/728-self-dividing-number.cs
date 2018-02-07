public class Solution
{
    public IList<int> SelfDividingNumbers(int left, int right)
    {
        List<int> result = new List<int>();
        for (int i = left; i <= right; i++)
        {
            if (determine(i))
            {
                result.Add(i);
            }
        }
        return result;
    }

    private bool determine(int num)
    {
        int temp = num;
        List<int> digits = new List<int>();
        while(temp > 0) {
            digits.Add(temp % 10);
            temp /= 10;
        }
        foreach(int d in digits) {
            if(d == 0) {
                return false;
            }
            else if(num % d != 0) {
                return false;
            }
        }
        return true;
    }
}