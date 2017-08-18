public class Solution {
    public int MaxSubArray(int[] nums) {
        int n = nums.Length;
        int[] sums = new int[n];
        sums[0] = nums[0];
        int max = sums[0];

        for(int i = 1; i < n; i++) {
            sums[i] = nums[i] + (sums[i - 1] > 0 ? sums[i - 1] : 0);
            if(sums[i] > max) {
                max = sums[i];
            }
        }
        return max;
    }
}