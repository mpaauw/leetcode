class Solution {
    public int[] twoSum(int[] nums, int target) {
        HashMap<Integer, Integer> map = new HashMap<>();
        int[] result = new int[2];
        
        // build set while scanning:
        for(int i = 0; i < nums.length; i++) {
            // compare diffs with set elements
            int current = nums[i];
            int diff = target - current;
            if(map.containsKey(diff)) {
                result[1] = i;
                result[0] = map.get(diff);
                break;
            } else {
                map.put(current, i);
            }
        }

        // return result
        return result;
    }
}