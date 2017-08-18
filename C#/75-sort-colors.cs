public class Solution {

    private const int RED = 0;
    private const int WHITE = 1;
    private const int BLUE = 2;

    public void SortColors(int[] nums) {
        int redCount = 0, whiteCount = 0, blueCount = 0;
        for(int i = 0; i < nums.Length; i++) {
            if(nums[i] == RED) {
                redCount++;
            }
            else if(nums[i] == WHITE) {
                whiteCount++;
            }
            else if(nums[i] == BLUE) {
                blueCount++;
            }
        }

        int iter = 0;
        for(int i = 0; i < redCount; i++) {
            nums[iter] = RED;
            iter++;
        }
        for(int i = 0; i < whiteCount; i++) {
            nums[iter] = WHITE;
            iter++;
        }
        for(int i = 0; i < blueCount; i++) {
            nums[iter] = BLUE;
            iter++;
        }
    }
}