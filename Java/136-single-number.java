class Solution {
    // Efficiency: Time: O(n), Space: O(n)
    // Explanation: iterate through the array of integers, storing each integer's count in a map, then finding which integer has a count of 1.
    public int singleNumber(int[] nums) throws IllegalArgumentException {
        HashMap<Integer, Integer> map = new HashMap<>(); // integer, count
        for(int i = 0; i < nums.length; i++) {
            int current = nums[i];
            if(map.containsKey(current)) {
                int count = map.get(current);
                count += 1;
                map.put(current, count);
            } else {
                map.put(current, 1);
            }
        }
        for(Integer key : map.keySet()) {
            int val = map.get(key);
            if(val == 1) {
                return key;
            }
        }
        return -1;
    }
}