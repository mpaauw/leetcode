public class Solution
{
    public int[] NextGreaterElement(int[] findNums, int[] nums)
    {
        int max = -1;
        if(nums.Length > 0) {
            max = nums[0];
        }
        
        for (int i = 0; i < nums.Length; i++)
        { // find max
            if (nums[i] > max)
            {
                max = nums[i];
            }
        }

        int[] outputArr = new int[findNums.Length];
        for(int i = 0; i < outputArr.Length; i++)
        {
            outputArr[i] = -1;
        }

        for (int i = 0; i < findNums.Length; i++)
        {
            if (findNums[i] >= max)
            {
                continue;
            }
            else
            {
                bool found = false;
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[j] == findNums[i])
                    {
                        found = true;
                    }                
                    if (found)
                    {
                        if (nums[j] > findNums[i])
                        {
                            outputArr[i] = nums[j];
                            break;
                        }
                    }
                }
            }        
        }
        return outputArr;
    }
}