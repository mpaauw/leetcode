//LeetCode.com
//#191: Number of 1 Bits

class Solution {
public:
    int hammingWeight(uint32_t n) {
        int count;
        for(count = 0; n; count++)
        {
            n &= n - 1;
        }
        return count;
    }
};