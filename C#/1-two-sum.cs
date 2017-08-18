public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] indices = new int[2];
        for(int i = 0; i < nums.Length; i++) {
            bool found = false;
            for(int j = i + 1; j < nums.Length; j++) {
                if(nums[i] + nums[j] == target) {
                    indices[0] = i;
                    indices[1] = j;
                    found = true;
                    break;
                }
            }
            if(found) {
                break;
            }
        }
        return indices;
    }
}