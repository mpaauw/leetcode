public class Solution {
    public IList<int> FindDisappearedNumbers(int[] nums) {
        IList<int> list = new List<int>();
        bool[] indexes = new bool[nums.Length + 1];
        for(int i = 0; i < indexes.Length; i++) {
            indexes[i] = false;
        }
        for(int i = 0; i < nums.Length; i++) {
            indexes[nums[i]] = true;
        }
        for(int i = 1; i < indexes.Length; i++) {
            if(!indexes[i]) {
                list.Add(i);
            }
        }
        return list;
    }
}