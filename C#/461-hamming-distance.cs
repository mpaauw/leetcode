public class Solution {
    public int HammingDistance(int x, int y) {
        int z = x ^ y;
    int n = 0;
    while(z > 0) {
        z = z & (z - 1);
        ++n;
    }
    return n;
    }
}