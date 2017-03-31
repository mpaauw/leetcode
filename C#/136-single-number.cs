public class Solution {
  public int SingleNumber(int[] nums)
        {
            int solution = Int32.MaxValue;
            Dictionary<int, int> numberCounts = new Dictionary<int, int>(); // <num, count>
            for (int i = 0; i < nums.Length; i++)
            {
                if (numberCounts.ContainsKey(nums[i]))
                {
                    numberCounts[nums[i]] += 1;
                }
                else
                {
                    numberCounts.Add(nums[i], 1);
                }
            }
             foreach(int key in numberCounts.Keys)
            {
                if (numberCounts[key] == 1)
                {
                    solution = key;
                }
            }
            return solution;
        }
}